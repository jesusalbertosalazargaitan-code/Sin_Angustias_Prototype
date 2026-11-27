using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [Header("Configuración de Ventana")]
    public int anchoVentana = 1270;
    public int altoVentana = 720;

    public int sceneChange; // Variable para cambiar la escena del juego desde el inspector
    public bool menuOff = false; // Variable para controlar el estado del menú de pausa
    public bool activeEnemy = true;
    public bool lvl1 = false;
    public GameObject pause; // Referencia al menú de pausa
    public GameObject options; // Referencia al menú de opciones 
    public GameObject menu; // Referencia al menú principal para desactivarlo al entrar en opciones
    public GameObject score; // Referencia al prefab del objeto que se recogerá para sumar puntos
    public GameObject enemy; // Referencia al prefab del enemigo para instanciarlo en la escena
    public GameObject end;
    public Vector3[] vectors3; // Array de posiciones para instanciar los objetos de puntuación
    public Light lightF; // Referencia a la luz que se encenderá y apagará con la tecla L
    public int objectScore; // Variable para llevar la cuenta de los objetos recogidos
    void Awake()
    {
        float savedVolume = PlayerPrefs.GetFloat("MasterVolume", 1.0f);
        AudioListener.volume = Mathf.Clamp01(savedVolume);
        DynamicGI.UpdateEnvironment();
    }

    void Start()
    {
        DynamicGI.UpdateEnvironment();
        if (options != null)
        {
            Slider volumeSlider = options.GetComponentInChildren<Slider>(true);
            if (volumeSlider != null)
            {
                volumeSlider.SetValueWithoutNotify(AudioListener.volume);
                volumeSlider.onValueChanged.RemoveListener(SetVolume);
                volumeSlider.onValueChanged.AddListener(SetVolume);
            }
        }
        UpdateScore(0); // Inicializamos el contador de objetos recogidos a 0
        if (vectors3.Length >= 3) // Verificamos que hay al menos 6 posiciones disponibles para instanciar los objetos
        {
            InstansObjects(); // Llamamos al método para instanciar los objetos de puntuación en posiciones aleatorias
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F11))
        {
            ScreenVision();
        }
        if (objectScore == 3 && activeEnemy == true)
        {
            Instantiate(enemy, new Vector3(84.32f, 0.675f, 68.73f), Quaternion.Euler(0, 0, 0)); // Instanciamos el prefab del enemigo en la posición del prefab con una rotación sin cambios
            end.SetActive(true);
            activeEnemy = false;
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
        if (menuOff || GameOverUIController.IsGameOverActive) return;

        if (Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Escape)) //Condición tecla menu de pausa
        {
            if (pause != null && !pause.activeSelf && (options == null || !options.activeSelf))
            {
                Cursor.lockState = CursorLockMode.None; // desbloqueamos el cursor
                Cursor.visible = true; // hacemos visible el cursor
                Time.timeScale = 0; // pausamos el tiempo del juego
                pause.SetActive(true); // activamos el menú de pausa
                return;
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape) && lvl1 == false)
        {
            Cursor.lockState = CursorLockMode.Locked; // bloqueamos el cursor
            Cursor.visible = false; // hacemos invisible el cursor
            Time.timeScale = 1; // reanudamos el tiempo del juego
            if (pause != null) pause.SetActive(false); // desactivamos el menú de pausa
            if (options != null) options.SetActive(false);
        }
    }

    public void RestartLevel()
    {
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        DynamicGI.UpdateEnvironment();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ReturnToMainMenu()
    {
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        DynamicGI.UpdateEnvironment();
        SceneManager.LoadScene(0);
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
        DynamicGI.UpdateEnvironment();
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
    public void SetVolume(float value)
    {
        AudioListener.volume = Mathf.Clamp01(value);
        PlayerPrefs.SetFloat("MasterVolume", AudioListener.volume);
        PlayerPrefs.Save();
    }
    public void ExitGame() // Metodo para salir del juego
    {
        Application.Quit(); // Salimos del juego
    }
    public void ScreenVision()
    {
        if (Screen.fullScreen)
        {
            // Pasar a modo ventana con resolución 1270x720
            Screen.SetResolution(anchoVentana, altoVentana, FullScreenMode.Windowed);
        }
        else
        {
            // Volver a pantalla completa usando la resolución nativa del monitor actual
            int anchoNativo = Screen.currentResolution.width;
            int altoNativo = Screen.currentResolution.height;
            Screen.SetResolution(anchoNativo, altoNativo, FullScreenMode.FullScreenWindow);
        }
    }
}
