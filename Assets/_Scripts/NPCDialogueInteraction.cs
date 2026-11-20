using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class NPCDialogueInteraction : MonoBehaviour
{
    [Header("UI Elements")]
    public GameObject promptUI;           // Mensaje "Presiona [E] para hablar"
    public GameObject dialoguePanel;       // Panel principal de diálogo
    public TextMeshProUGUI npcNameText;    // Encabezado "Remy"
    public TextMeshProUGUI dialogueText;   // Cuerpo del diálogo

    [Header("NPC Data")]
    public string npcName = "Remy";
    [TextArea(3, 6)]
    public string[] dialogues;

    private int currentIndex = 0;
    private bool isTalking = false;
    private bool playerInRange = false;

    private void Start()
    {
        if (promptUI != null) promptUI.SetActive(false);
        if (dialoguePanel != null) dialoguePanel.SetActive(false);
        if (npcNameText != null) npcNameText.text = npcName;

        currentIndex = 0;
        isTalking = false;
        playerInRange = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = true;
            if (!isTalking && promptUI != null)
            {
                promptUI.SetActive(true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerInRange = false;
            isTalking = false;
            currentIndex = 0;

            if (promptUI != null) promptUI.SetActive(false);
            if (dialoguePanel != null) dialoguePanel.SetActive(false);
        }
    }

    private void Update()
    {
        if (playerInRange && Time.timeScale > 0f && Keyboard.current != null && Keyboard.current.eKey.wasPressedThisFrame)
        {
            if (!isTalking)
            {
                if (dialogues != null && dialogues.Length > 0)
                {
                    isTalking = true;
                    currentIndex = 0;

                    if (promptUI != null) promptUI.SetActive(false);
                    if (dialoguePanel != null) dialoguePanel.SetActive(true);
                    if (npcNameText != null) npcNameText.text = npcName;
                    if (dialogueText != null) dialogueText.text = dialogues[currentIndex];
                }
            }
            else
            {
                currentIndex++;
                if (dialogues != null && currentIndex < dialogues.Length)
                {
                    if (dialogueText != null) dialogueText.text = dialogues[currentIndex];
                }
                else
                {
                    // Finaliza la conversación
                    isTalking = false;
                    currentIndex = 0;

                    if (dialoguePanel != null) dialoguePanel.SetActive(false);
                    if (promptUI != null) promptUI.SetActive(true);
                }
            }
        }
    }
}
