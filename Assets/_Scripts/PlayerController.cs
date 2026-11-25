using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float suavizadoAnimacion = 0.1f; // Variable para controlar la suavización de las animaciones,
    public float speed = 3.5f; // Variable para controlar la velocidad de movimiento del jugador, que se puede ajustar en el Inspector de Unity para encontrar la velocidad que mejor se adapte al juego
    public float velocidad = 0.0f; // Variable para almacenar la velocidad actual del jugador, que se actualizará en función del input de movimiento y se utilizará para controlar las animaciones de movimiento (caminando o corriendo) en el Animator
    private float velocidadSmooth;// Variable para almacenar la velocidad suavizada del jugador, que se calculará utilizando Mathf.MoveTowards para crear transiciones suaves entre las animaciones de movimiento en el Animator
    public bool GameOver = false;// Variable para indicar si el juego ha terminado, lo que puede afectar la lógica del movimiento, las animaciones y las interacciones del jugador con el entorno, como desactivar el movimiento o mostrar una pantalla de Game Over
    public bool safeZone = false;// Variable para indicar si el jugador está en una zona segura, lo que puede afectar la lógica del juego relacionada con la seguridad del jugador y la interacción con enemigos o eventos peligrosos
    
    
    public GameManager gameManager;// Variable para almacenar una referencia al GameManager en la escena, lo que nos permitirá acceder a la puntuación del jugador y otras variables relacionadas con la lógica del juego para controlar el flujo del juego en función de la puntuación y el estado del juego
    [Header("Audio")]
    public AudioSource footstepSource;
    public AudioSource sfxSource;
    public AudioClip flashlightClip;

    private Vector2 inputMove; //Variable para almacenar el input de movimiento del jugador, que se actualizará en función de las entradas del jugador (como WASD o el joystick) y se utilizará para calcular la dirección y la velocidad del movimiento del jugador en el método Move
    private PlayerStamina stamina;
    private bool sprintInputHeld = false;
    public bool IsSprinting => speed > 4.5f && inputMove.sqrMagnitude > 0.01f && !GameOver;
    Rigidbody rb; // Variable para almacenar una referencia al componente Rigidbody del jugador, lo que nos permitirá controlar el movimiento del jugador aplicando fuerzas o estableciendo la velocidad del Rigidbody en el método Move
    Animator anim;// Variable para almacenar una referencia al componente Animator del jugador, lo que nos permitirá controlar las animaciones del jugador estableciendo parámetros en el Animator en el método Animations y otras partes del código para activar animaciones específicas como caminar, correr, atacar o morir
    void Awake()
    {
        // En el método Awake, obtenemos referencias a los componentes Animator y Rigidbody del jugador, así como al GameManager en la escena, lo que nos permitirá controlar las animaciones, el movimiento y la lógica del juego en función de la puntuación y el estado del juego
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        stamina = GetComponent<PlayerStamina>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }
    void Update()
    {
        // Llamamos al método Move para controlar el movimiento del jugador y al método Animations para controlar las animaciones del jugador en cada frame, siempre y cuando el juego no haya terminado
        Move();
        // Llamamos al método Animations para controlar las animaciones del jugador en cada frame, verificando si se presiona la tecla de ataque y actualizando los parámetros del Animator en función del input de movimiento y la velocidad actual del jugador, siempre y cuando el juego no haya terminado
        Animations();
    }
    // Método que se llama cuando se recibe una entrada de movimiento, actualizando el vector de inputMove con el valor del input de movimiento recibido
    public void OnMove(InputValue value) 
    {
        // Actualizamos el vector de inputMove con el valor del input de movimiento recibido, que es un Vector2 que representa la dirección del movimiento en los ejes horizontal (x) y vertical (y)
        inputMove = value.Get<Vector2>(); 
    }
    // Método que se llama cuando se recibe una entrada de sprint, actualizando la velocidad del jugador en función de si el botón de sprint está presionado o no
    public void OnSprint(InputValue value)
    {
        sprintInputHeld = value.isPressed;
        if (!sprintInputHeld || GameOver)
        {
            speed = 3.5f;
        }
    }
    public void OnFlashlight()
    {
        if (sfxSource != null && flashlightClip != null && !GameOver && Time.timeScale > 0f)
        {
            sfxSource.PlayOneShot(flashlightClip, 0.85f);
        }
    }
    // Método que se llama para mover al jugador, calculando la dirección deseada en función del input de movimiento y estableciendo la velocidad del Rigidbody en consecuencia, siempre y cuando el juego no haya terminado
    public void Move()
    {
        // Si el juego no ha terminado, calculamos la dirección deseada en función del input de movimiento y establecemos la velocidad del Rigidbody para mover al jugador en consecuencia, manteniendo la componente vertical de la velocidad para permitir el salto o la gravedad
        if (GameOver == false)
        {
            bool isMoving = inputMove.sqrMagnitude > 0.01f;
            bool wantsToSprint = sprintInputHeld && isMoving && !GameOver;
            if (stamina != null)
            {
                stamina.SetSprintIntent(wantsToSprint);
            }
            bool canActuallySprint = wantsToSprint && (stamina == null || stamina.CanSprint);
            speed = canActuallySprint ? 7f : 3.5f;

            // Calculamos la dirección deseada en función del input de movimiento, utilizando el eje forward para el movimiento hacia adelante/atrás y el eje right para el movimiento lateral
            Vector3 direccionDeseada = (transform.forward * inputMove.y) + (transform.right * inputMove.x);
            // Si la magnitud de la dirección deseada es mayor que 1, normalizamos el vector para evitar que el jugador se mueva más rápido en diagonal
            if (direccionDeseada.magnitude > 1)
            {
                // Normalizamos el vector de dirección deseada para mantener una velocidad constante en todas las direcciones, evitando que el jugador se mueva más rápido en diagonal
                direccionDeseada.Normalize();
            }
            // Establecemos la velocidad del Rigidbody en función de la dirección deseada multiplicada por la velocidad actual, manteniendo la componente vertical de la velocidad para permitir el salto o la gravedad
            rb.velocity = new Vector3(direccionDeseada.x * speed, rb.velocity.y, direccionDeseada.z * speed);
            if (footstepSource != null)
            {
                if (isMoving && Time.timeScale > 0f)
                {
                    footstepSource.pitch = IsSprinting ? 1.35f : 1.0f;
                    if (!footstepSource.isPlaying)
                    {
                        footstepSource.Play();
                    }
                }
                else if (footstepSource.isPlaying)
                {
                    footstepSource.Pause();
                }
            }
        }
        else
        {
            if (stamina != null)
            {
                stamina.SetSprintIntent(false);
            }
            if (footstepSource != null && footstepSource.isPlaying)
            {
                footstepSource.Pause();
            }
        }
    }
    // Método que se llama para controlar las animaciones del jugador, verificando si se presiona la tecla de ataque y actualizando los parámetros del Animator en función del input de movimiento y la velocidad actual del jugador, siempre y cuando el juego no haya terminado
    public void Animations()
    {
        // Si se presiona la tecla F y el juego no ha terminado
        if (Input.GetKeyDown(KeyCode.F) && GameOver == false)
        {
            // Activamos la animación de linterna estableciendo el parámetro "Light" en el Animator a true
            anim.SetBool("Light", true);
            OnFlashlight();
        }
        // Si la tecla F no está presionada, desactivamos la animación de linterna estableciendo el parámetro "Light" en el Animator a false
        else anim.SetBool("Light", false);
        // Calculamos el objetivo de velocidad para la animación en función de la magnitud del input de movimiento y la relación entre la velocidad actual y la velocidad máxima (7f es la velocidad máxima de sprint)
        float objetivo = inputMove.magnitude * (speed / 7f);
        // Suavizamos la transición de la velocidad de la animación utilizando Mathf.MoveTowards
        velocidadSmooth = Mathf.MoveTowards(velocidadSmooth, objetivo, Time.deltaTime * 3f);
        // Establecemos el parámetro "Velocidad" en el Animator con la velocidad suavizada para controlar las animaciones de movimiento (caminando o corriendo) en función de la velocidad actual del jugador
        anim.SetFloat("Velocidad", velocidadSmooth);
    }
    // Método que se llama cuando el jugador colisiona con otro objeto, verificando si el objeto colisionado es una zona segura, un enemigo o el final del nivel, y actuando en consecuencia
    private void OnCollisionEnter(Collision collision)
    {
        // Si el jugador colisiona con una zona segura y el juego no ha terminado, se establece safeZone en true para indicar que el jugador está en una zona segura
        if (collision.collider.CompareTag("SafeZone") && GameOver == false)
            safeZone = true;
        // Si el jugador colisiona con un enemigo y el juego no ha terminado, se activa la animación de muerte y se establece GameOver en true para indicar que el juego ha terminado
        if (collision.collider.CompareTag("Enemy") && GameOver == false)
        {
            // Activa la animación de muerte estableciendo el parámetro "Dead" en el Animator a true, lo que hará que el jugador muera visualmente en el juego
            anim.SetBool("Dead", true);
            // Establece GameOver en true para indicar que el juego ha terminado, lo que puede desactivar otras funcionalidades del jugador y mostrar una pantalla de Game Over o reiniciar el nivel
            GameOver = true;
        }

        // Si el jugador colisiona con el objeto final del nivel y el juego no ha terminado, se verifica si el jugador ha alcanzado la puntuación necesaria para completar el nivel (en este caso, 3 objetos recogidos), y si es así, se carga la escena principal (índice 0) y se desbloquea el cursor para permitir que el jugador interactúe con el menú o la interfaz de usuario después de completar el nivel
        if (collision.collider.CompareTag("End") && GameOver == false)
        {
            // Verificamos si el jugador ha alcanzado la puntuación necesaria para completar el nivel (3 objetos o más recogidos)
            if (gameManager.objectScore >= 3)
            {
                Time.timeScale = 1f;
                // Desbloqueamos el cursor para permitir que el jugador interactúe con el menú o la interfaz de usuario después de completar el nivel
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                // Cargamos la escena principal (índice 0) después de completar el nivel
                SceneManager.LoadScene(0);
            }
        }
    }

    // Respaldo de seguridad para cuando el objeto final del nivel es un Trigger
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("End") && GameOver == false && gameManager.objectScore >= 3)
        {
            Time.timeScale = 1f;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
    }
    // Método que se llama cuando el jugador deja de colisionar con otro objeto, verificando si el objeto dejado de colisionar es una zona segura, y si es así, se establece safeZone en false para indicar que el jugador ya no está en una zona segura
    private void OnCollisionExit(Collision collision) 
    {
        // Si el jugador deja de colisionar con una zona segura y el juego no ha terminado, se establece safeZone en false para indicar que el jugador ya no está en una zona segura, lo que puede afectar la lógica del juego relacionada con la seguridad del jugador y la interacción con enemigos o eventos peligrosos
        if (collision.collider.CompareTag("SafeZone") && GameOver == false) 
            safeZone = false;
    }
}
