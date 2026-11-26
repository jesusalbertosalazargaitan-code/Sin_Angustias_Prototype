using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using Cinemachine;

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

    [Header("Control de Suelo y Rampas")]
    public float groundCheckDistance = 0.45f;
    public float maxSlopeAngle = 50f;
    public float slopeStickForce = 1.5f;

    private Vector2 inputMove; //Variable para almacenar el input de movimiento del jugador, que se actualizará en función de las entradas del jugador (como WASD o el joystick) y se utilizará para calcular la dirección y la velocidad del movimiento del jugador en el método Move
    private PlayerStamina stamina;
    private bool sprintInputHeld = false;
    private bool isDying = false;
    private Transform headBone;
    private CapsuleCollider capsuleCol;
    private bool wasOnSlope = false;
    private Vector3 latestDesiredDir = Vector3.zero;
    private bool latestIsMoving = false;
    public bool IsSprinting => speed > 4.5f && inputMove.sqrMagnitude > 0.01f && !GameOver;
    Rigidbody rb; // Variable para almacenar una referencia al componente Rigidbody del jugador, lo que nos permitirá controlar el movimiento del jugador aplicando fuerzas o estableciendo la velocidad del Rigidbody en el método Move
    Animator anim;// Variable para almacenar una referencia al componente Animator del jugador, lo que nos permitirá controlar las animaciones del jugador estableciendo parámetros en el Animator en el método Animations y otras partes del código para activar animaciones específicas como caminar, correr, atacar o morir
    void Awake()
    {
        // En el método Awake, obtenemos referencias a los componentes Animator y Rigidbody del jugador, así como al GameManager en la escena, así controlamos animaciones, movimiento y lógica del juego
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        stamina = GetComponent<PlayerStamina>();
        capsuleCol = GetComponent<CapsuleCollider>();
        headBone = FindChildNamed("mixamorig:Head") ?? FindChildNamed("mixamorig12:Head");
        GameObject gmObj = GameObject.Find("Game Manager");
        if (gmObj != null) gameManager = gmObj.GetComponent<GameManager>();
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
    void FixedUpdate()
    {
        if (GameOver == false && rb != null && !rb.isKinematic)
        {
            ApplyGroundAndSlopePhysics(latestDesiredDir, latestIsMoving);
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

            latestDesiredDir = direccionDeseada;
            latestIsMoving = isMoving;
            ApplyGroundAndSlopePhysics(direccionDeseada, isMoving);

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
            latestDesiredDir = Vector3.zero;
            latestIsMoving = false;
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

    private void ApplyGroundAndSlopePhysics(Vector3 direccionDeseada, bool isMoving)
    {
        if (rb == null || rb.isKinematic) return;

        if (TryGetGroundHit(out RaycastHit hit, out float slopeAngle) && slopeAngle <= maxSlopeAngle)
        {
            if (slopeAngle > 1.0f)
            {
                wasOnSlope = true;
                if (isMoving)
                {
                    Vector3 slopeDir = Vector3.ProjectOnPlane(direccionDeseada, hit.normal).normalized;
                    rb.velocity = slopeDir * speed - hit.normal * slopeStickForce;
                }
                else
                {
                    rb.velocity = Vector3.zero;
                }
            }
            else
            {
                float vy = (wasOnSlope || rb.velocity.y > 0f) ? -slopeStickForce : rb.velocity.y;
                wasOnSlope = false;
                rb.velocity = new Vector3(direccionDeseada.x * speed, vy, direccionDeseada.z * speed);
            }
        }
        else
        {
            if (wasOnSlope && rb.velocity.y > 0f)
            {
                rb.velocity = new Vector3(rb.velocity.x, 0f, rb.velocity.z);
            }
            wasOnSlope = false;
            rb.velocity = new Vector3(direccionDeseada.x * speed, rb.velocity.y, direccionDeseada.z * speed);
        }
    }

    private bool TryGetGroundHit(out RaycastHit groundHit, out float slopeAngle)
    {
        groundHit = default;
        slopeAngle = 0f;

        float scaleY = Mathf.Abs(transform.lossyScale.y);
        if (scaleY < 0.01f) scaleY = 1f;

        Vector3 centerWorld = capsuleCol != null
            ? transform.TransformPoint(capsuleCol.center)
            : transform.position + Vector3.up * (0.875f * scaleY);
        float halfHeight = capsuleCol != null ? (capsuleCol.height * 0.5f) * scaleY : 0.875f * scaleY;
        Vector3 bottomWorld = centerWorld + Vector3.down * halfHeight;

        float startOffset = 0.15f * scaleY;
        float maxDist = (groundCheckDistance + 0.15f) * scaleY;
        Vector3 origin = bottomWorld + Vector3.up * startOffset;

        RaycastHit[] hits = Physics.RaycastAll(origin, Vector3.down, maxDist, ~0, QueryTriggerInteraction.Ignore);
        float closestDist = float.MaxValue;
        bool found = false;

        foreach (RaycastHit hit in hits)
        {
            if (hit.collider == null) continue;
            if (hit.collider.transform == transform || hit.collider.transform.IsChildOf(transform)) continue;
            if (hit.distance < closestDist)
            {
                closestDist = hit.distance;
                groundHit = hit;
                found = true;
            }
        }

        if (found)
        {
            slopeAngle = Vector3.Angle(groundHit.normal, Vector3.up);
        }

        return found;
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
        // Si el jugador colisiona con un enemigo y el juego no ha terminado, sincroniza la animación de muerte
        if (collision.collider.CompareTag("Enemy") && GameOver == false && !isDying)
        {
            EnemyIA enemyIA = collision.collider.GetComponentInParent<EnemyIA>();
            if (enemyIA != null)
            {
                enemyIA.TriggerKillOnPlayer(this);
            }
            else
            {
                Animator enemyAnim = collision.collider.GetComponentInParent<Animator>();
                TriggerSyncedDeath(collision.transform, enemyAnim, 1.15f);
            }
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

    public void TriggerSyncedDeath(Transform enemyTransform, Animator enemyAnim, float killSyncDistance = 1.15f)
    {
        if (isDying) return;
        isDying = true;
        GameOver = true;

        if (stamina != null)
        {
            stamina.SetSprintIntent(false);
        }

        if (footstepSource != null && footstepSource.isPlaying)
        {
            footstepSource.Pause();
        }

        if (rb != null)
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            rb.isKinematic = true;
        }

        PlayerInput pInput = GetComponent<PlayerInput>();
        if (pInput != null)
        {
            pInput.enabled = false;
        }

        Transform mainCamT = transform.Find("Main Camera");
        if (mainCamT == null && Camera.main != null && Camera.main.transform.IsChildOf(transform))
        {
            mainCamT = Camera.main.transform;
        }

        if (mainCamT != null)
        {
            CameraController camCtrl = mainCamT.GetComponent<CameraController>();
            if (camCtrl != null)
            {
                camCtrl.activeCam = false;
                camCtrl.enabled = false;
            }

            CinemachineBrain brain = mainCamT.GetComponent<CinemachineBrain>();
            if (brain != null) brain.enabled = false;

            mainCamT.localPosition = new Vector3(0f, 1.54f, 0.093f);
            mainCamT.localRotation = Quaternion.identity;
        }

        if (headBone == null)
        {
            headBone = FindChildNamed("mixamorig:Head") ?? FindChildNamed("mixamorig12:Head");
        }
        if (headBone != null)
        {
            StartCoroutine(HideHeadOnDecapitation());
        }

        if (enemyTransform != null)
        {
            Vector3 dirToEnemy = enemyTransform.position - transform.position;
            dirToEnemy.y = 0f;
            if (dirToEnemy.sqrMagnitude < 0.0001f)
            {
                dirToEnemy = transform.forward;
                dirToEnemy.y = 0f;
            }
            dirToEnemy.Normalize();

            transform.rotation = Quaternion.LookRotation(dirToEnemy, Vector3.up);
            enemyTransform.position = new Vector3(
                transform.position.x + dirToEnemy.x * killSyncDistance,
                transform.position.y,
                transform.position.z + dirToEnemy.z * killSyncDistance
            );
            enemyTransform.rotation = Quaternion.LookRotation(-dirToEnemy, Vector3.up);
        }

        if (anim != null)
        {
            anim.speed = 1f;
            anim.SetBool("Dead", true);
            anim.Play("Player dead", 0, 0f);
            anim.Update(0f);
        }

        if (enemyAnim != null)
        {
            enemyAnim.speed = 1f;
            enemyAnim.SetBool("Dead", true);
            enemyAnim.Play("DeadPlayerforEnemy", 0, 0f);
            enemyAnim.Update(0f);
        }

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    private IEnumerator HideHeadOnDecapitation()
    {
        yield return new WaitForSeconds(0.45f);
        if (headBone != null)
        {
            headBone.localScale = Vector3.zero;
        }
    }

    private Transform FindChildNamed(string targetName)
    {
        foreach (Transform t in GetComponentsInChildren<Transform>(true))
        {
            if (t.name == targetName) return t;
        }
        return null;
    }
}
