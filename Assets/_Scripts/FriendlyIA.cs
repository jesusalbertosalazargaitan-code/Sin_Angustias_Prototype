using System.Collections;
using System.Collections.Generic;
using UnityEditor.Advertisements;
using UnityEngine;
using UnityEngine.AI;

public class FriendlyIA : MonoBehaviour
{
    private NavMeshAgent agent;
    public float tiempodeEspera = 60f; // Tiempo que el NPC esperará en cada punto de interés antes de moverse al siguiente
    public float timer = 0f; 
    public float speed = 10f;
    public float visionRate;
    public float wanderRate;
    public Vector3[] wayPoints; // Array de puntos de interés para que el NPC se mueva entre ellos
    public int arrayVector = 0; // Variable para llevar la cuenta del índice actual en el array de puntos de interés
    public bool advance = false; // Variable para controlar si el NPC debe avanzar hacia el siguiente punto de interés
    public bool tipPlayer = false; // Variable para controlar si el NPC ha dado la pista al jugador
    public int hitCount;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        HitCountPlayer(0);
    }

    void Update()
    {
        agent.speed = speed;
        if(advance == true)
        {
            timer += Time.deltaTime; // Si el agente ha llegado a su destino, puedes realizar alguna acción adicional aquí si lo deseas
            MoveToPoint();
        }else advance = false;

        if (hitCount == 3)
        {
            StartCoroutine(DestroyGuide());
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            advance = true; // Si el NPC colisiona con el jugador, se activa la variable advance para que el NPC comience a avanzar hacia el siguiente punto de interés
            if (tipPlayer == false)
            {
                arrayVector++; // Incrementa el índice del array de puntos de interés para que el NPC se dirija al siguiente punto en la próxima actualización
                tipPlayer = true; // Reinicia la variable tipPlayer para que el NPC no dé la pista nuevamente hasta que vuelva a colisionar con el jugador
                timer = 0f;
                HitCountPlayer(1); // Incrementa el contador de colisiones con el jugador para llevar la cuenta de cuántas veces el NPC ha dado la pista al jugador
            }
            else if(tipPlayer == true)
            {
                StartCoroutine(WaitsecondsToken()); // Si el NPC ya ha dado la pista al jugador, se inicia una corrutina para esperar un tiempo antes de permitir que el NPC dé la pista nuevamente
            }
        }
    }
    public void MoveToPoint()
    {
        if (!agent.pathPending && agent.remainingDistance <= agent.stoppingDistance)
        {
            if (advance == false) return;
            
            agent.SetDestination(wayPoints[arrayVector]);
            if (timer >= tiempodeEspera)
            {
                agent.SetDestination(wayPoints[0]);
                arrayVector = 0;
                timer = 0f;
            }
        }
    }
    public void HitCountPlayer(int add)
    {
        hitCount += add;
    }
    IEnumerator WaitsecondsToken()
    {
        yield return new WaitForSeconds(10f);
        tipPlayer = false;
    }
    IEnumerator DestroyGuide()
    {
        yield return new WaitForSeconds(10f);
        Destroy(gameObject);
    }
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, visionRate);

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, wanderRate);
    }
}
