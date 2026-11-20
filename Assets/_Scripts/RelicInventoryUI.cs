using UnityEngine;
using TMPro;

public class RelicInventoryUI : MonoBehaviour
{
    [Header("Inventory Status")]
    public bool hasSol = false;
    public bool hasLuna = false;
    public bool hasMezcla = false;

    public bool HasAllRelics => hasSol && hasLuna && hasMezcla;

    [Header("UI Slots (TextMeshProUGUI)")]
    public TextMeshProUGUI slotSolText;
    public TextMeshProUGUI slotLunaText;
    public TextMeshProUGUI slotMezclaText;

    [Header("Salida Caver 1")]
    public DoorSlideController exitDoor;

    [Header("Audio Recolección")]
    public AudioSource pickupAudioSource;
    public AudioClip pickupClip;

    private readonly Color colorIncompleto = new Color(0.70f, 0.70f, 0.70f, 0.85f);
    private readonly Color colorSol = new Color(1.0f, 0.85f, 0.2f, 1.0f);        // Dorado
    private readonly Color colorLuna = new Color(0.4f, 0.8f, 1.0f, 1.0f);        // Azul celeste
    private readonly Color colorMezcla = new Color(0.6f, 1.0f, 0.6f, 1.0f);      // Esmeralda/Brillante

    private void Start()
    {
        UpdateUI();
    }

    public void CollectRelic(RelicType type)
    {
        switch (type)
        {
            case RelicType.Sol:
                hasSol = true;
                break;
            case RelicType.Luna:
                hasLuna = true;
                break;
            case RelicType.Mezcla:
                hasMezcla = true;
                break;
        }

        // Actualizar visualmente la UI
        UpdateUI();

        if (pickupAudioSource != null && pickupClip != null)
        {
            pickupAudioSource.PlayOneShot(pickupClip);
        }

        // Notificar al GameManager para compatibilidad con contador y EnemyIA
        GameManager gm = Object.FindObjectOfType<GameManager>();
        if (gm != null)
        {
            gm.UpdateScore(1);
        }

        int total = (hasSol ? 1 : 0) + (hasLuna ? 1 : 0) + (hasMezcla ? 1 : 0);
        Debug.Log($"[RelicInventoryUI] Reliquia registrada: {type}. Progreso: {total}/3.");

        if (HasAllRelics)
        {
            if (exitDoor != null)
            {
                exitDoor.OpenDoor();
            }
            else
            {
                DoorSlideController foundDoor = Object.FindObjectOfType<DoorSlideController>();
                if (foundDoor != null)
                {
                    foundDoor.OpenDoor();
                }
            }
            Debug.Log("[RelicInventoryUI] ¡Todas las reliquias reunidas! Abriendo la puerta de salida en Caver (1).");
        }
    }

    public void UpdateUI()
    {
        if (slotSolText != null)
        {
            slotSolText.text = hasSol ? "[X] Reliquia del Sol" : "[ ] Reliquia del Sol";
            slotSolText.color = hasSol ? colorSol : colorIncompleto;
        }

        if (slotLunaText != null)
        {
            slotLunaText.text = hasLuna ? "[X] Reliquia de la Luna" : "[ ] Reliquia de la Luna";
            slotLunaText.color = hasLuna ? colorLuna : colorIncompleto;
        }

        if (slotMezclaText != null)
        {
            slotMezclaText.text = hasMezcla ? "[X] Reliquia Sol y Luna" : "[ ] Reliquia Sol y Luna";
            slotMezclaText.color = hasMezcla ? colorMezcla : colorIncompleto;
        }
    }
}

