using System.Collections;
using UnityEngine;
using Cinemachine;
using UnityEngine.SceneManagement;

public class PitFallCutsceneController : MonoBehaviour
{
    [Header("Cinemachine Cutscene Cameras")]
    public CinemachineVirtualCamera vcamStep1;
    public CinemachineVirtualCamera vcamStep2;
    public CinemachineVirtualCamera vcamStep3;

    [Header("Timing")]
    public float step1To2Duration = 1.1f;
    public float step2To3Duration = 1.2f;
    public float holdAtBottomDuration = 0.4f;

    [Header("Scene Transition")]
    public string targetSceneName = "Lvl 2";

    private bool hasTriggered = false;

    private void Start()
    {
        if (vcamStep1 != null) vcamStep1.Priority = 5;
        if (vcamStep2 != null) vcamStep2.Priority = 5;
        if (vcamStep3 != null) vcamStep3.Priority = 5;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (hasTriggered || !other.CompareTag("Player")) return;

        hasTriggered = true;

        // 1. Inmovilizar y ocultar visualmente al Player
        PlayerController playerController = other.GetComponent<PlayerController>();
        if (playerController == null)
        {
            playerController = other.GetComponentInParent<PlayerController>();
        }
        if (playerController != null)
        {
            if (playerController.footstepSource != null && playerController.footstepSource.isPlaying)
            {
                playerController.footstepSource.Pause();
            }
            playerController.enabled = false;
        }

        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (rb == null)
        {
            rb = other.GetComponentInParent<Rigidbody>();
        }
        if (rb != null)
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
            rb.isKinematic = true;
        }

        Renderer[] renderers = other.gameObject.GetComponentsInChildren<Renderer>(true);
        foreach (Renderer r in renderers)
        {
            if (r != null && (r is SkinnedMeshRenderer || r is MeshRenderer))
            {
                r.enabled = false;
            }
        }

        // 2. Desactivar CameraController para evitar que sobreescriba Main Camera o reactive el InputProvider
        Camera mainCam = Camera.main;
        CameraController camController = mainCam != null ? mainCam.GetComponent<CameraController>() : null;
        if (camController == null)
        {
            camController = FindFirstObjectByType<CameraController>();
        }
        if (camController != null)
        {
            camController.enabled = false;
        }

        // 3. Desactivar CinemachineInputProvider de CM vcam_FirstPerson si está activo
        GameObject firstPersonVcam = GameObject.Find("CM vcam_FirstPerson");
        if (firstPersonVcam != null)
        {
            CinemachineInputProvider inputProvider = firstPersonVcam.GetComponent<CinemachineInputProvider>();
            if (inputProvider != null && inputProvider.enabled)
            {
                inputProvider.enabled = false;
            }
        }
        else
        {
            CinemachineInputProvider fallbackProvider = FindFirstObjectByType<CinemachineInputProvider>();
            if (fallbackProvider != null && fallbackProvider.enabled)
            {
                fallbackProvider.enabled = false;
            }
        }

        StartCoroutine(PlayPitFallSequence());
    }

    private IEnumerator PlayPitFallSequence()
    {
        Camera mainCam = Camera.main;
        CinemachineBrain brain = mainCam != null ? mainCam.GetComponent<CinemachineBrain>() : null;
        if (brain == null)
        {
            brain = FindFirstObjectByType<CinemachineBrain>();
        }

        if (brain != null)
        {
            brain.enabled = true;
            brain.m_DefaultBlend.m_Style = CinemachineBlendDefinition.Style.EaseInOut;
            brain.m_DefaultBlend.m_Time = 0.45f;
        }

        // Paso 1: Encuadrar la entrada del templo
        if (vcamStep1 != null) vcamStep1.Priority = 30;
        yield return new WaitForSeconds(0.5f);

        // Paso 2: Inclinar la mirada hacia el pozo
        if (brain != null) brain.m_DefaultBlend.m_Time = step1To2Duration;
        if (vcamStep2 != null) vcamStep2.Priority = 35;
        yield return new WaitForSeconds(step1To2Duration);

        // Paso 3: Descender verticalmente mirando el fondo del pozo (Rotation X = 90)
        if (brain != null) brain.m_DefaultBlend.m_Time = step2To3Duration;
        if (vcamStep3 != null) vcamStep3.Priority = 40;
        yield return new WaitForSeconds(step2To3Duration + holdAtBottomDuration);

        // Cargar Lvl 2
        DynamicGI.UpdateEnvironment();
        SceneManager.LoadScene(targetSceneName);
    }
}
