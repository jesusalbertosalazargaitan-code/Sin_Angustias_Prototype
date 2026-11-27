using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverUIController : MonoBehaviour
{
    public static GameOverUIController Instance { get; private set; }
    public static bool IsGameOverActive => Instance != null && Instance.isShown;

    [Header("Referencias UI")]
    public GameObject panelGameOver;
    public CanvasGroup panelCanvasGroup;

    [Header("Transición")]
    public float fadeInDuration = 0.45f;

    private bool isShown = false;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
            return;
        }
        Instance = this;

        if (panelGameOver != null)
        {
            panelGameOver.SetActive(false);
        }
    }

    private void OnDestroy()
    {
        if (Instance == this)
        {
            Instance = null;
        }
    }

    public void ShowGameOver()
    {
        if (isShown) return;
        isShown = true;

        InteraccionHistoria.CerrarTodosLosAvisosYPaneles(null);

        GameManager gm = Object.FindObjectOfType<GameManager>();
        if (gm != null)
        {
            gm.menuOff = true;
            if (gm.pause != null) gm.pause.SetActive(false);
            if (gm.options != null) gm.options.SetActive(false);
        }

        if (panelGameOver != null)
        {
            panelGameOver.SetActive(true);
        }

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 0f;

        if (panelCanvasGroup != null)
        {
            panelCanvasGroup.interactable = true;
            panelCanvasGroup.blocksRaycasts = true;
            StartCoroutine(FadeInRoutine());
        }
    }

    public void RestartLevel()
    {
        GameManager gm = Object.FindObjectOfType<GameManager>();
        if (gm != null)
        {
            gm.RestartLevel();
            return;
        }
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        DynamicGI.UpdateEnvironment();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ReturnToMainMenu()
    {
        GameManager gm = Object.FindObjectOfType<GameManager>();
        if (gm != null)
        {
            gm.ReturnToMainMenu();
            return;
        }
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        DynamicGI.UpdateEnvironment();
        SceneManager.LoadScene(0);
    }

    private IEnumerator FadeInRoutine()
    {
        float duration = Mathf.Max(0.05f, fadeInDuration);
        float elapsed = 0f;
        panelCanvasGroup.alpha = 0f;

        while (elapsed < duration)
        {
            elapsed += Time.unscaledDeltaTime;
            panelCanvasGroup.alpha = Mathf.Clamp01(elapsed / duration);
            yield return null;
        }

        panelCanvasGroup.alpha = 1f;
    }
}
