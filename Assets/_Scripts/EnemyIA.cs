using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyIA : MonoBehaviour
{
    // Variables configurables
    
    public float visionRate = 10f; // Distancia a la que te ve
    public float roadRate = 30f; // Qué tan lejos puede ir al deambular
    public float tiempoDeEspera = 3f;  // Tiempo que espera en cada punto al deambular
    public float run = 3f; // Velocidad al perseguir
    public float walk = 1.5f; // Velocidad al deambular
    private float cronometro; // Para contar el tiempo de espera al deambular
    private GameManager gameManager; // Referencia al GameManager para verificar el puntaje
    public Transform jugador; // Arrastra aquí al Player
    Animator anim; // Referencia al Animator para controlar las animaciones
    private NavMeshAgent agente; // Componentes y estado interno
    private PlayerController playerController; // Referencia al PlayerController para verificar si el jugador está en la zona segura
    private bool jugadorEnVista; // Si el jugador está dentro del radio de visión
    private bool persiguiendoJugador = false;
    public bool walkUp = false; // Si el enemigo está caminando erguido (después de recoger 3 objetos)
    [Header("Sincronización de Muerte")]
    public float killSyncDistance = 0.95f;
    public float deathSequenceDuration = 7.0f;
    bool GameOver = false; // Si el juego ha terminado (para evitar que la IA siga actuando después de ganar o perder)
    private bool isKilling = false;
    private bool transformado = false; // Bandera para que la transformación de score 3 solo se ejecute una única vez
    void Start()
    {
        // Obtener referencias a componentes y objetos necesarios
        GameObject playerGO = GameObject.FindWithTag("Player");
        if (playerGO == null) playerGO = GameObject.Find("Player");
        if (playerGO != null)
        {
            playerController = playerGO.GetComponent<PlayerController>();
            jugador = playerGO.transform;
        }
        anim = GetComponent<Animator>();
        GameObject gmGO = GameObject.Find("Game Manager");
        if (gmGO != null) gameManager = gmGO.GetComponent<GameManager>();
        agente = GetComponent<NavMeshAgent>();
        // Empezamos deambulando a un punto aleatorio
        SetNuevoPuntoAleatorio();
        // Iniciar la corrutina para cambiar a caminar erguido después de 30 segundos
        StartCoroutine(StateAnim());
    }

    void Update()
    {
        if (GameOver || isKilling || jugador == null) return;

        // Detección: ¿El jugador está cerca?
        float distanciaAlJugador = Vector3.Distance(transform.position, jugador.position);
        // El jugador está en vista si está dentro del radio de visión y el juego no ha terminado
        if (distanciaAlJugador <= visionRate && GameOver == false)
        {
            jugadorEnVista = true; // El jugador está dentro del radio de visión
        }
        else
        {
            jugadorEnVista = false; // El jugador está fuera del radio de visión o el juego ha terminado
        }
        // Comportamiento: Si el jugador está en vista y no está en la zona segura, perseguirlo. Si no, deambular.
        bool isSafeZone = playerController != null && playerController.safeZone;
        if (jugadorEnVista && PuedoVerAlJugador() && !isSafeZone && GameOver == false)
        {
            if (!persiguiendoJugador)
            {
                persiguiendoJugador = true;
                if (SuspenseAudioController.Instance != null)
                {
                    SuspenseAudioController.Instance.TryPlaySuspense();
                }
            }
            PerseguirJugador();
        }
        else
        {
            persiguiendoJugador = false;
            DeambularAletorio();// Si el jugador no está en vista o está en la zona segura, deambular
        }
        // Cambios de estado basados en el puntaje del jugador
        if (gameManager != null && gameManager.objectScore == 3 && GameOver == false && !transformado)
        {
            transformado = true;
            walkUp = true; // El enemigo empieza a caminar erguido después de recoger 3 objetos
            anim.SetBool("Up", true); // Activa la animación de caminar erguido
            anim.SetBool("Walk", true); // Activa la animación de caminar
            run = 5f; // Aumenta la velocidad al perseguir después de recoger 3 objetos
            walk = 3f; // Aumenta la velocidad al deambular después de recoger 3 objetos
            roadRate = 15f; // Aumenta el radio de deambulación después de recoger 3 objetos
            visionRate = 20f; // Aumenta el radio de visión después de recoger 3 objetos
            StartCoroutine(StateStop()); // Inicia la corrutina para volver a caminar normal después de 7.5 segundos
        }
        // Si el jugador ha recogido 3 objetos, el enemigo se vuelve aún más rápido y agresivo
        if (gameManager != null && gameManager.objectScore == 3)
        {
            run = 6f; // Velocidad máxima al perseguir después de recoger 6 objetos
            walk = 5f; // Velocidad máxima al deambular después de recoger 6 objetos
            roadRate = 30f; // Radio de deambulación máximo después de recoger 6 objetos
            visionRate = 40f; // Radio de visión máximo después de recoger 6 objetos
        }
        if (walkUp == true && agente != null && agente.enabled && agente.isOnNavMesh)
        {
            agente.isStopped = true;
            agente.ResetPath();
        }
    }
    // Función para perseguir al jugador
    void PerseguirJugador() 
    {
        // Si el jugador está en vista y el juego no ha terminado, perseguirlo
        if (walkUp == false && GameOver == false && agente != null && agente.enabled)
        {
            // El NavMesh Agent se encarga de ir hacia el jugador sin chocarse
            agente.SetDestination(jugador.position);
            agente.speed = run; // Opcional: Aumentar velocidad al perseguir
            anim.SetFloat("Runing", 1); // Activa la animación de correr estableciendo el parámetro "Runing" en el Animator a 1
        }
    }
    // Si el jugador no está en vista o está en la zona segura, deambular
    void DeambularAletorio() 
    {
        if (agente == null || !agente.enabled) return;
        agente.speed = walk; // Volver a velocidad normal
        anim.SetFloat("Runing", 0); // Desactiva la animación de correr estableciendo el parámetro "Runing" en el Animator a 0

        // Si el agente no tiene un camino pendiente y ha llegado a su destino, elegir un nuevo punto aleatorio para deambular
        if (!agente.pathPending && agente.remainingDistance <= agente.stoppingDistance && walkUp == false)
        {
            // Si el agente no tiene un camino pendiente y ha llegado a su destino, esperar un poco antes de elegir un nuevo punto aleatorio para deambular
            cronometro += Time.deltaTime;
            // Esperamos un poco antes de ir al siguiente punto
            if (cronometro >= tiempoDeEspera && !GameOver)
            {
                // Elegir un nuevo punto aleatorio para deambular
                SetNuevoPuntoAleatorio();
                // Reiniciar el cronómetro para la próxima espera
                cronometro = 0;
            }
        }
    }

    // Función auxiliar para calcular un punto aleatorio en el NavMesh
    void SetNuevoPuntoAleatorio()
    {
        if (agente == null || !agente.enabled || !agente.isOnNavMesh) return;
        // Creamos un círculo imaginario alrededor de la IA
        Vector3 puntoAleatorio = Random.insideUnitSphere * roadRate;
        // Lo movemos a la posición de la IA para que el círculo esté centrado en ella
        puntoAleatorio += transform.position;
        // Creamos una variable para almacenar la información del punto más cercano en el NavMesh
        NavMeshHit hit;
        // Si encontramos un punto válido en el NavMesh dentro del radio de deambulación y el juego no ha terminado, establecemos ese punto como destino para el agente
        if (NavMesh.SamplePosition(puntoAleatorio, out hit, roadRate, 1) && !GameOver) 
        {
            // El NavMesh Agent se encarga de ir hacia el punto aleatorio sin chocarse
            agente.SetDestination(hit.position);
        }
        
    }
    bool PuedoVerAlJugador()
    {
        // 1. Calcular dirección y distancia hacia el jugador
        Vector3 direccionAlJugador = (jugador.position - transform.position).normalized;
        float distanciaAlJugador = Vector3.Distance(transform.position, jugador.position);

        // 2. Verificar si está dentro del rango de visión
        if (distanciaAlJugador <= visionRate)
        {
            // 3. Lanzar un Raycast desde el enemigo hacia el jugador
            // Ajustamos la altura de origen (p. ej. transform.position + Vector3.up * 1.5f) para simular los ojos
            Vector3 origenOjos = transform.position + Vector3.up * 1.5f;
            RaycastHit hit;

            if (Physics.Raycast(origenOjos, direccionAlJugador, out hit, visionRate))
            {
                // Comprobar si lo primero que impacta el Raycast es el jugador
                if (hit.transform == jugador || hit.transform.CompareTag("Player"))
                {
                    return true; // El enemigo ve al jugador sin obstáculos
                }
            }
        }

        return false; // El jugador está fuera de rango o cubierto tras un obstáculo
    }
    // Para ver el radio de visión en escena
    void OnDrawGizmosSelected()
    {
        // Dibujamos un círculo rojo para el radio de visión y un círculo azul para el radio de deambulación
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, visionRate);

        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, roadRate);

        // Dibujar línea del Raycast hacia el jugador en tiempo de ejecución (si existe)
        if (jugador != null)
        {
            Vector3 origenOjos = transform.position + Vector3.up * 30f;
            Gizmos.color = PuedoVerAlJugador() ? Color.green : Color.red;
            Gizmos.DrawLine(origenOjos, jugador.position);
        }

    }  
    IEnumerator StateAnim() // Cambia a caminar erguido después de 30 segundos
    {
        yield return new WaitForSeconds(30f); // Espera 30 segundos antes de cambiar a caminar erguido
        if (!GameOver && !isKilling && anim != null)
        {
            anim.SetBool("Up", true); // Activa la animación de caminar erguido
            anim.SetBool("Walk", true); // Activa la animación de caminar
            walkUp = true; // El enemigo empieza a caminar erguido después de 30 segundos
            StartCoroutine(StateStop()); // Inicia la corrutina para volver a caminar normal después de 7.5 segundos
        }
    }
    // Vuelve a caminar normal después de 7.5 segundos
    IEnumerator StateStop() 
    {
        yield return new WaitForSeconds(7.5f); // Espera 7.5 segundos antes de volver a caminar normal
        walkUp = false; // El enemigo deja de caminar erguido después de 7.5 segundos
    }

    public void TriggerKillOnPlayer(PlayerController targetPlayer)
    {
        if (isKilling || GameOver) return;
        isKilling = true;
        GameOver = true;

        if (agente != null && agente.enabled)
        {
            if (agente.isOnNavMesh)
            {
                agente.isStopped = true;
                agente.ResetPath();
                agente.velocity = Vector3.zero;
            }
            agente.updatePosition = false;
            agente.updateRotation = false;
            agente.enabled = false;
        }

        PlayerController victim = targetPlayer != null ? targetPlayer : playerController;
        if (victim != null)
        {
            victim.TriggerSyncedDeath(transform, anim, killSyncDistance);
        }
        else if (anim != null)
        {
            anim.speed = 1f;
            anim.SetBool("Dead", true);
            anim.Play("DeadPlayerforEnemy", 0, 0f);
            anim.Update(0f);
        }

        StartCoroutine(DeadTime());
    }

    // Detecta colisiones con el jugador para activar la animación de muerte y la secuencia de Game Over
    public void OnCollisionEnter(Collision collision) 
    {
        // Si colisiona con el jugador y el juego no ha terminado, sincroniza la animación de muerte
        if (collision.gameObject.CompareTag("Player") && GameOver == false && !isKilling) 
        {
            PlayerController pc = collision.gameObject.GetComponentInParent<PlayerController>();
            TriggerKillOnPlayer(pc);
        }
    }
    // Espera tras la secuencia sincronizada de muerte para cargar la escena de Game Over
    IEnumerator DeadTime() 
    {
        yield return new WaitForSeconds(deathSequenceDuration);
        SceneManager.LoadScene(1); // Carga la escena de Game Over (asegúrate de que la escena de Game Over esté en el índice 1 en la configuración de escenas)
    }
}
