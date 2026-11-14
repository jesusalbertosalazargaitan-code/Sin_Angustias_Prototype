using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelTransitionTrigger : MonoBehaviour
{
    [Header("Scene Transition")]
    public string targetSceneName = "Lvl 2";
    private bool transitioning = false;

    private void OnTriggerEnter(Collider other)
    {
        if (transitioning) return;

        if (other.CompareTag("Player"))
        {
            transitioning = true;
            Debug.Log($"[LevelTransitionTrigger] Player entered level transition trigger. Loading '{targetSceneName}'...");

            if (targetSceneName == "MainMenú" || targetSceneName == "0")
            {
                Time.timeScale = 1f;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }

            SceneManager.LoadScene(targetSceneName);
        }
    }
}

