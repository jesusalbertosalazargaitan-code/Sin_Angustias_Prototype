using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ElementsMove : MonoBehaviour
{
    private GameManager gameManager; // Referencia al GameManager para verificar el puntaje y la posición del objeto next
    private Vector3 startPosition; // Variable para almacenar la posición inicial del objeto
    void Start()
    {// Obtiene la referencia al GameManager buscando el objeto con el nombre "Game Manager" en la escena y accediendo a su componente GameManager
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>(); 
    }

    void Update()
    {
        startPosition = transform.position; //Guarda la posición inicial del objeto

        if (transform.position.x <= 4.69f && gameManager.objectScore == 6) //Si el objeto está en la posición de la puerta y se han recogido los 6 objetos, se mueve hacia adelante
        {
            transform.Translate(Vector3.forward * 0.5f * Time.deltaTime); // Mueve el objeto hacia adelante a una velocidad de 0.5 unidades por segundo
        }
        else transform.position = startPosition; // Si el objeto no está en la posición de la puerta o no se han recogido los 6 objetos, se mantiene en su posición inicial

    }
}
