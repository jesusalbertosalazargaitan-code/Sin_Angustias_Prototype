using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int sceneChange; // Variable para cambiar la escena del juego desde el inspector
    public bool menuOff = false; // Variable para controlar el estado del menú de pausa
    public bool prefab1; // Variable para controlar si el prefab del enemigo se ha instanciado al recoger 3 objetos
    public bool prefab2;
    public TextMeshProUGUI count; // Referencia al texto que muestra el contador de objetos recogidos
    public GameObject countOut; // Referencia al objeto que contiene el texto del contador para activarlo o desactivarlo
    public GameObject pause; // Referencia al menú de pausa
    public GameObject next; // Referencia al objeto que se desactivará al recoger los 6 objetos
    public GameObject options; // Referencia al menú de opciones 
    public GameObject menu; // Referencia al menú principal para desactivarlo al entrar en opciones
    public GameObject score; // Referencia al prefab del objeto que se recogerá para sumar puntos
    public GameObject enemy; // Referencia al prefab del enemigo para instanciarlo en la escena
    public Vector3[] vectors3; // Array de posiciones para instanciar los objetos de puntuación
    public Light lightF; // Referencia a la luz que se encenderá y apagará con la tecla L
    public int objectScore; // Variable para llevar la cuenta de los objetos recogidos
    void Start()
    {
        UpdateScore(0); // Inicializamos el contador de objetos recogidos a 0
        if (vectors3.Length >= 3) // Verificamos que hay al menos 6 posiciones disponibles para instanciar los objetos
        {
            InstansObjects(); // Llamamos al método para instanciar los objetos de puntuación en posiciones aleatorias
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (count != null)
        {
            count.text = "Score: " + objectScore.ToString("0"); // Actualizamos el texto del contador de objetos recogidos con el valor actual del contador
        }
        if (next != null)
        {
            if (objectScore == 3 && next.transform.rotation.x == 4.69f) // Si se han recogido los 6 objetos y el objeto next está en la posición de la puerta, se desactiva el objeto next para permitir el paso
            {
                next.SetActive(false); // Desactivamos el objeto next para permitir el paso
            }
        }
        if (objectScore == 3 && prefab1 == false)
        {
            Instantiate(enemy, new Vector3(25.727f, 0f, 14.237f), Quaternion.Euler(0, 0, 0)); // Instanciamos el prefab del enemigo en la posición del prefab con una rotación sin cambios
            prefab1 = true;
        }
        if (objectScore == 3 && prefab2 == false)
        {
            Instantiate(enemy, new Vector3(-13.76f, 0f, 2.045f), Quaternion.Euler(0, 0, 0)); // Instanciamos el prefab del enemigo en la posición del prefab con una rotación sin cambios
            prefab2 = true;
        }
        MenuPause(); // Llamamos al método para controlar el menú de pausa
    }
    public void UpdateScore(int add) // Método para actualizar el contador de objetos recogidos, se le pasa un valor que se suma al contador actual
    {
        objectScore += add; // Sumamos el valor pasado al contador de objetos recogidos
    }
    public void OnLight(InputValue value) // Método para controlar la luz con la tecla L, se llama automáticamente al presionar la tecla asignada en el Input System
    {
        if (value.isPressed) // Si la tecla está presionada, se cambia el estado de la luz (encendida o apagada)
            lightF.enabled = !lightF.enabled; // Cambiamos el estado de la luz utilizando el operador lógico NOT para alternar entre encendida y apagada
    }
    void InstansObjects()
    {

        List<Vector3> listaTemporal = new List<Vector3>(vectors3); // Creamos una lista temporal a partir del array de posiciones para poder barajarla


        for (int i = 0; i < listaTemporal.Count; i++) // Recorremos la lista temporal para barajarla utilizando el algoritmo de Fisher-Yates
        {
            Vector3 temp = listaTemporal[i]; // Guardamos el elemento actual en una variable temporal
            int randomIndex = Random.Range(i, listaTemporal.Count); // Generamos un índice aleatorio entre el índice actual y el final de la lista
            listaTemporal[i] = listaTemporal[randomIndex]; // Asignamos el elemento del índice aleatorio al índice actual
            listaTemporal[randomIndex] = temp; // Asignamos el elemento guardado en la variable temporal al índice aleatorio, completando el intercambio de elementos
        }

        for (int i = 0; i < 3; i++) // Recorremos las primeras 3 posiciones de la lista temporal (que ahora está barajada) para instanciar los objetos de puntuación en esas posiciones
        {
            Instantiate(score, listaTemporal[i], Quaternion.Euler(90, 0, 0)); // Instanciamos el prefab del objeto de puntuación en la posición correspondiente de la lista temporal, con una rotación de 90 grados en el eje X para que quede orientado hacia arriba
        }
    }
    public void MenuPause() //Metodo menu de pausa
    {
        if (Input.GetKeyDown(KeyCode.P) && !menuOff) //Condición tecla menu de apusa
        {
            Cursor.lockState = CursorLockMode.None; // desbloqueamos el cursor
            Cursor.visible = true; // hacemos visible el cursor
            Time.timeScale = 0; // pausamos el tiempo del juego
            pause.SetActive(true); // activamos el menú de pausa
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.Locked; // bloqueamos el cursor
            Cursor.visible = false; // hacemos invisible el cursor
            Time.timeScale = 1; // reanudamos el tiempo del juego
            pause.SetActive(false); // desactivamos el menú de pausa
        }
    }
    public void Continue() // Metodo para continuar el juego
    {
        Cursor.lockState = CursorLockMode.Locked; // bloqueamos el cursor
        Cursor.visible = false; // hacemos invisible el cursor
        Time.timeScale = 1; // reanudamos el tiempo del juego
        pause.SetActive(false); // desactivamos el menú de pausa
    }
    public void PlayGame() // Metodo para iniciar el juego
    {
        SceneManager.LoadScene(sceneChange); // Cargamos la escena del juego con una variable para cambiarla desde el inspector
    }
    public void Options() // Metodo para ir a las opciones
    {
        options.SetActive(true); // activamos el menú de opciones
        menu.SetActive(false); // desactivamos el menú principal
    }
    public void Back() // Metodo para volver al menu de pausa o principal dependiendo la escena
    {
        options.SetActive(false); // desactivamos el menú de opciones
        menu.SetActive(true); // activamos el menú principal
    }
    public void ExitGame() // Metodo para salir del juego
    {
        Application.Quit(); // Salimos del juego
    }
}
