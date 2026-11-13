using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{   public PlayerController playerController; // Referencia al PlayerController para verificar el estado del juego
    private Vector2 inputMove; // Variable para almacenar la entrada del mouse
    public Transform player; // Referencia al transform del jugador para rotarlo horizontalmente
    public float sensibylity; // Variable para ajustar la sensibilidad del mouse, configurable desde el inspector
    private float rotationVertical = 0;
    void Start()
    {
        // Obtiene la referencia al PlayerController buscando el objeto con el nombre "Player" en la escena y accediendo a su componente PlayerController
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
        Cursor.lockState = CursorLockMode.Locked; // Bloqueamos el cursor para que no se vea ni se mueva fuera de la ventana del juego
        Cursor.visible = false; // Hacemos invisible el cursor para que no distraiga durante el juego
    }
    void Update()
    {
        // Solo permite mover la cámara si el juego no ha terminado, evitando que el jugador pueda seguir moviendo la cámara después de ganar o perder
        if (playerController.GameOver == false) 
            MoveMouse(); // Llama al método para mover la cámara basado en la entrada del mouse
    }
    // Método para recibir la entrada del mouse, se llama automáticamente al mover el mouse según lo configurado en el Input System
    public void OnCamera(InputValue value) 
    {
        inputMove = value.Get<Vector2>(); // Almacena la entrada del mouse en la variable inputMove, que se utilizará para mover la cámara en el método MoveMouse
    }
    // Método para mover la cámara basado en la entrada del mouse, ajustando la sensibilidad y el tiempo para que el movimiento sea suave y consistente
    void MoveMouse()
    {
        // Calcula el movimiento horizontal y vertical multiplicando la entrada del mouse por la sensibilidad y el tiempo delta para que el movimiento sea suave y consistente
        float MoveX = inputMove.x * sensibylity * Time.deltaTime;
        float MoveY = inputMove.y * sensibylity * Time.deltaTime;
        // Rota la cámara verticalmente restando el movimiento vertical al ángulo de rotación vertical, y luego clampa ese ángulo para evitar que la cámara gire demasiado hacia arriba o hacia abajo
        rotationVertical -= MoveY;
        // Clampa el ángulo de rotación vertical entre -60 y 60 grados para evitar que la cámara gire demasiado hacia arriba o hacia abajo, lo que podría resultar incómodo para el jugador
        rotationVertical = Mathf.Clamp(rotationVertical, -60, 60);
        // Aplica la rotación vertical a la cámara utilizando un quaternion que representa una rotación en el eje X, lo que permite que la cámara gire hacia arriba y hacia abajo sin afectar la rotación horizontal del jugador
        transform.localRotation = Quaternion.Euler(rotationVertical, 0f, 0f);
        // Rota el jugador horizontalmente multiplicando el movimiento horizontal por un vector que representa la rotación en el eje Y, lo que permite que el jugador gire hacia los lados sin afectar la rotación vertical de la cámara
        player.Rotate(Vector3.up * MoveX);
        
            
        
    }
}