using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FriendlyIA : MonoBehaviour
{
    private NavMeshAgent agent;
    public float tiempodeEspera = 60f; // Tiempo que el NPC esperar� en cada punto de inter�s antes de moverse al siguiente
    public float timer = 0f; 
    public float speed = 10f;
    public float visionRate;
    public float wanderRate;
    public Vector3[] wayPoints; // Array de puntos de inter�s para que el NPC se mueva entre ellos
    public int arrayVector = 0; // Variable para llevar la cuenta del �ndice actual en el array de puntos de inter�s
    public bool advance = false; // Variable para controlar si el NPC debe avanzar hacia el siguiente punto de inter�s
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
            timer += Time.deltaTime; // Si el agente ha llegado a su destino, puedes realizar alguna acci�n adicional aqu� si lo deseas
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
            advance = true; // Si el NPC colisiona con el jugador, se activa la variable advance para que el NPC comience a avanzar hacia el siguiente punto de inter�s
            if (tipPlayer == false)
            {
                arrayVector++; // Incrementa el �ndice del array de puntos de inter�s para que el NPC se dirija al siguiente punto en la pr�xima actualizaci�n
                tipPlayer = true; // Reinicia la variable tipPlayer para que el NPC no d� la pista nuevamente hasta que vuelva a colisionar con el jugador
                timer = 0f;
                HitCountPlayer(1); // Incrementa el contador de colisiones con el jugador para llevar la cuenta de cu�ntas veces el NPC ha dado la pista al jugador
            }
            else if(tipPlayer == true)
            {
                StartCoroutine(WaitsecondsToken()); // Si el NPC ya ha dado la pista al jugador, se inicia una corrutina para esperar un tiempo antes de permitir que el NPC d� la pista nuevamente
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
