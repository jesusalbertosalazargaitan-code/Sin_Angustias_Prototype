using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objects : MonoBehaviour
{
    Rigidbody rb; // Variable para almacenar la referencia al componente Rigidbody del objeto, que se utilizará para aplicar fuerzas y detectar colisiones
    private GameManager gameManager; // Variable para almacenar la referencia al GameManager, que se utilizará para actualizar el puntaje del jugador al recoger el objeto
    void Start()
    {
        // Obtiene la referencia al componente Rigidbody del objeto utilizando el método GetComponent, lo que permite aplicar fuerzas y detectar colisiones con otros objetos en la escena
        rb = GetComponent<Rigidbody>();
        // Obtiene la referencia al GameManager buscando el objeto con el nombre "Game Manager" en la escena y accediendo a su componente GameManager, lo que permite actualizar el puntaje del jugador al recoger el objeto
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>(); 
    }
    void Update()
    {
        // Rota el objeto constantemente alrededor del eje Z (Vector3.forward) a una velocidad de 40 grados por segundo multiplicada por el tiempo delta para que la rotación sea suave y consistente, lo que hace que el objeto sea más visible y atractivo para el jugador
        transform.Rotate(Vector3.forward * 40f * Time.deltaTime);
    }
    public void OnCollisionEnter(Collision collision)
    {
        // Si el objeto colisiona con el jugador, se actualiza el puntaje del jugador sumando 1 al contador de objetos recogidos en el GameManager y se destruye el objeto para simular que ha sido recogido
        if (collision.collider.CompareTag("Player"))
        {
            // Llama al método UpdateScore del GameManager para sumar 1 al contador de objetos recogidos, lo que permite llevar la cuenta de cuántos objetos ha recogido el jugador
            gameManager.UpdateScore(1);
            Destroy(gameObject);
        }
        // Si el objeto colisiona con el suelo, se aplica una fuerza hacia arriba utilizando el método AddForce del Rigidbody para simular un rebote, lo que hace que el objeto sea más dinámico y atractivo para el jugador
        if (collision.collider.CompareTag("Floor"))
        {
            // Aplica una fuerza hacia arriba multiplicando el vector Vector3.up por un valor de 40f para determinar la intensidad del rebote, y utilizando el modo de fuerza ForceMode.Impulse para aplicar la fuerza de manera instantánea, lo que hace que el objeto rebote de manera realista al colisionar con el suelo
            rb.AddForce(Vector3.up * 40f, ForceMode.Impulse);
        }
    }
}
