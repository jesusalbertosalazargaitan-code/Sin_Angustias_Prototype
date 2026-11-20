using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.InputSystem;

public class IntroCutsceneController : MonoBehaviour
{
    [Header("Cinemachine Cameras")]
    public CinemachineVirtualCamera introVcam;
    public CinemachineVirtualCamera playerVcam;

    [Header("Target Player")]
    public GameObject playerObject;

    [Header("Timing")]
    [Tooltip("Pausa inicial contemplando el bosque antes de descender")]
    public float holdAtStartDuration = 0.8f;
    [Tooltip("Duración del viaje suave hasta el Player")]
    public float blendDuration = 3.5f;

    [Header("Optional UI to Hide during cutscene")]
    public GameObject hudToHide;

    private List<Renderer> hiddenRenderers = new List<Renderer>();
    private PlayerController playerController;
    private CinemachineInputProvider inputProvider;
    private Rigidbody playerRb;

    private void Start()
    {
        if (playerObject == null)
        {
            playerObject = GameObject.FindWithTag("Player");
        }

        if (playerObject != null)
        {
            // 1. Ocultar visualmente al Player sin apagar su GameObject (para conservar Animator y Main Camera)
            Renderer[] allRenderers = playerObject.GetComponentsInChildren<Renderer>(true);
            hiddenRenderers.Clear();
            foreach (var r in allRenderers)
            {
                if (r != null && r.enabled)
                {
                    hiddenRenderers.Add(r);
                    r.enabled = false;
                }
            }

            // 2. Bloquear control durante la cinemática
            playerController = playerObject.GetComponent<PlayerController>();
            if (playerController != null)
            {
                playerController.enabled = false;
            }

            playerRb = playerObject.GetComponent<Rigidbody>();
            if (playerRb != null)
            {
                playerRb.velocity = Vector3.zero;
            }
        }

        if (playerVcam != null)
        {
            inputProvider = playerVcam.GetComponent<CinemachineInputProvider>();
            if (inputProvider != null)
            {
                inputProvider.enabled = false;
            }
            playerVcam.Priority = 10;
        }

        if (introVcam != null)
        {
            introVcam.Priority = 20;
        }

        // 3. Ajustar el CinemachineBrain de Main Camera
        Camera mainCam = Camera.main;
        if (mainCam != null)
        {
            CinemachineBrain brain = mainCam.GetComponent<CinemachineBrain>();
            if (brain != null)
            {
                brain.m_DefaultBlend.m_Style = CinemachineBlendDefinition.Style.EaseInOut;
                brain.m_DefaultBlend.m_Time = blendDuration;
            }
        }

        if (hudToHide != null)
        {
            hudToHide.SetActive(false);
        }

        StartCoroutine(PlayIntroSequence());
    }

    private IEnumerator PlayIntroSequence()
    {
        // 1. Espera holdAtStartDuration contemplando la panorámica
        yield return new WaitForSeconds(holdAtStartDuration);

        // 2. Cambiar prioridad de introVcam a 0 para disparar la transición suave
        if (introVcam != null)
        {
            introVcam.Priority = 0;
        }

        // 3. Esperar a que la cámara viaje hasta la posición del jugador
        yield return new WaitForSeconds(blendDuration);

        // 4. Reactivar renderers del jugador
        foreach (var r in hiddenRenderers)
        {
            if (r != null)
            {
                r.enabled = true;
            }
        }
        hiddenRenderers.Clear();

        // 5. Reactivar PlayerController e InputProvider
        if (playerController != null)
        {
            playerController.enabled = true;
        }

        if (inputProvider != null)
        {
            inputProvider.enabled = true;
        }

        if (hudToHide != null)
        {
            hudToHide.SetActive(true);
        }

        // 6. Desactivar introVcam para que no interfiera en gameplay
        if (introVcam != null)
        {
            introVcam.gameObject.SetActive(false);
        }
    }
}
