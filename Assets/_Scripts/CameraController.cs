using UnityEngine;
using UnityEngine.InputSystem;
using Cinemachine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class CameraController : MonoBehaviour
{
    [Header("Referencias Existentes")]
    public PlayerController playerController;
    public Transform player;
    public float sensibylity = 15f;
    public Transform flashlightTransform;
    public Transform armBone;

    [Header("Cinemachine First-Person")]
    public CinemachineVirtualCamera virtualCamera;
    public float baseFOV = 70f;
    public float sprintFOV = 75f;
    public float fovSmoothSpeed = 8f;

    private CinemachineBrain brain;
    private CinemachinePOV pov;
    private CinemachineInputProvider inputProvider;
    private Transform cameraRoot;
    public bool activeCam = false;

    void Start()
    {
        StartCoroutine(WaitsecondsCam());

        if (playerController == null)
        {
            GameObject pObj = GameObject.FindGameObjectWithTag("Player");
            if (pObj == null) pObj = GameObject.Find("Player");
            if (pObj != null) playerController = pObj.GetComponent<PlayerController>();
        }
        if (player == null)
        {
            if (playerController != null)
                player = playerController.transform;
            else
                player = GameObject.FindGameObjectWithTag("Player")?.transform;
        }

        if (player != null)
        {
            cameraRoot = player.Find("CameraRoot");
            if (armBone == null)
                armBone = FindChildRecursive(player, "RightArm");
            if (flashlightTransform == null)
            {
                Light spot = player.GetComponentInChildren<Light>(true);
                if (spot != null && spot.transform != transform && !spot.transform.IsChildOf(transform))
                    flashlightTransform = spot.transform;
            }
        }

        brain = GetComponent<CinemachineBrain>();
        if (virtualCamera == null) virtualCamera = FindFirstObjectByType<CinemachineVirtualCamera>();

        if (virtualCamera != null)
        {
            pov = virtualCamera.GetCinemachineComponent<CinemachinePOV>();
            inputProvider = virtualCamera.GetComponent<CinemachineInputProvider>();

            if (pov != null)
            {
                // Límites anatómicos naturales del cuello humano
                pov.m_VerticalAxis.m_MinValue = -60f;
                pov.m_VerticalAxis.m_MaxValue = 65f;
                pov.m_VerticalAxis.m_Wrap = false;
                pov.m_HorizontalAxis.m_MinValue = -180f;
                pov.m_HorizontalAxis.m_MaxValue = 180f;
                pov.m_HorizontalAxis.m_Wrap = true;

                if (player != null)
                    pov.m_HorizontalAxis.Value = player.eulerAngles.y;

                // Calibra velocidad para <Mouse>/delta (píxeles/frame)
                float gain = Mathf.Max(0.05f, sensibylity * 0.015f);
                pov.m_VerticalAxis.m_SpeedMode = AxisState.SpeedMode.InputValueGain;
                pov.m_HorizontalAxis.m_SpeedMode = AxisState.SpeedMode.InputValueGain;
                pov.m_VerticalAxis.m_MaxSpeed = gain;
                pov.m_HorizontalAxis.m_MaxSpeed = gain;
            }
        }

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Mantiene compatibilidad con UnityEvents antiguos de PlayerInput sin duplicar rotación
    public void OnCamera(InputValue value) { }

    void Update()
    {
        bool isDead = playerController != null && playerController.GameOver;
        bool isPaused = Time.timeScale == 0f;

        if (isDead && activeCam == true)
        {
            // Desactiva CinemachineBrain para que el Animator ejecute la animación de muerte sobre Main Camera
            if (brain != null && brain.enabled && activeCam == true) brain.enabled = false;
            if (inputProvider != null && inputProvider.enabled && activeCam == true) inputProvider.enabled = false;
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            return;
        }

        if (isPaused)
        {
            if (inputProvider != null && inputProvider.enabled && activeCam == true) inputProvider.enabled = false;
            return;
        }

        if (brain != null && !brain.enabled && activeCam == true) brain.enabled = true;
        if (inputProvider != null && !inputProvider.enabled && activeCam == true) inputProvider.enabled = true;

        // FOV Dinámico en la Virtual Camera
        if (virtualCamera != null && playerController != null && activeCam == true)
        {
            bool isSprinting = playerController.speed > 4.5f;
            float targetFOV = isSprinting ? sprintFOV : baseFOV;
            virtualCamera.m_Lens.FieldOfView = Mathf.Lerp(virtualCamera.m_Lens.FieldOfView, targetFOV, Time.deltaTime * fovSmoothSpeed);
        }
    }

    void LateUpdate()
    {
        if (playerController != null && playerController.GameOver && activeCam == true) return;

        float yaw = (pov != null) ? pov.m_HorizontalAxis.Value : transform.eulerAngles.y;
        float pitch = (pov != null) ? pov.m_VerticalAxis.Value : transform.localEulerAngles.x;
        if (pitch > 180f && activeCam == true) pitch -= 360f;

        // 1. Alinea horizontalmente el cuerpo 1:1 con la mirada para girar todo el cuerpo y nunca ver la espalda
        if (player != null && activeCam == true)
        {
            player.rotation = Quaternion.Euler(0f, yaw, 0f);
        }

        // Mantiene la posición exacta en los ojos (CameraRoot) y evita doble rotación heredada por ser hija de Player
        if (cameraRoot != null && activeCam == true)
        {
            transform.position = cameraRoot.position;
        }
        transform.rotation = Quaternion.Euler(pitch, yaw, 0f);

        // 2. Inclina el brazo derecho suavemente en el plano vertical
        if (armBone != null && player != null && activeCam == true)
        {
            armBone.Rotate(player.right, pitch * 0.6f, Space.World);
        }

        // 3. Garantiza que la linterna apunte exactamente a donde mira la cámara
        if (flashlightTransform != null && flashlightTransform != transform && activeCam == true)
        {
            flashlightTransform.rotation = Quaternion.LookRotation(transform.forward, transform.up);
        }
    }

    private Transform FindChildRecursive(Transform parent, string name)
    {
        foreach (Transform child in parent.GetComponentsInChildren<Transform>(true))
        {
            if (child.name.Contains(name))
                return child;
        }
        return null;
    }
    IEnumerator WaitsecondsCam()
    {
        yield return new WaitForSeconds(3f);
        activeCam = true;
    }
}
