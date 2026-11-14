using UnityEngine;
using TMPro;

public class AltarInteraction : MonoBehaviour
{
    [Header("UI Pop-up")]
    [Tooltip("Panel UI que muestra la traducción o mensaje del altar")]
    public GameObject panelAltarPopup;

    [Tooltip("Componente TextMeshProUGUI del mensaje del pop-up")]
    public TextMeshProUGUI popupText;

    [Header("Pedestales / Ofrendas en el Altar")]
    public GameObject pedestalSol;
    public GameObject pedestalLuna;
    public GameObject pedestalMezcla;

    [Header("Salida Caver 1")]
    public GameObject puertaSalidaCaver1;

    [Header("Estado")]
    public bool altarRestaurado = false;

    private const string TEXTO_INCOMPLETO = "Este es el altar de la diosa del sol y la luna. Busca las 3 reliquias para abrir el paso.";
    private const string TEXTO_RESTAURADO = "¡Has restaurado el Altar del Sol y la Luna! La salida en la caverna se ha abierto.";

    private void Start()
    {
        if (panelAltarPopup != null)
        {
            panelAltarPopup.SetActive(false);
        }

        // Asegurar que los pedestales visuales inicien apagados si no está restaurado
        if (!altarRestaurado)
        {
            if (pedestalSol != null) pedestalSol.SetActive(false);
            if (pedestalLuna != null) pedestalLuna.SetActive(false);
            if (pedestalMezcla != null) pedestalMezcla.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            RelicInventoryUI inventory = Object.FindObjectOfType<RelicInventoryUI>();
            bool hasAll = (inventory != null && inventory.HasAllRelics);

            if (hasAll || altarRestaurado)
            {
                altarRestaurado = true;
                if (pedestalSol != null) pedestalSol.SetActive(true);
                if (pedestalLuna != null) pedestalLuna.SetActive(true);
                if (pedestalMezcla != null) pedestalMezcla.SetActive(true);

                if (puertaSalidaCaver1 != null)
                {
                    DoorSlideController doorSlide = puertaSalidaCaver1.GetComponent<DoorSlideController>();
                    if (doorSlide != null)
                    {
                        doorSlide.OpenDoor();
                    }
                    else
                    {
                        puertaSalidaCaver1.SetActive(false);
                    }
                    Debug.Log("[AltarInteraction] ¡Puerta de salida en Caver (1) desbloqueada!");
                }

                SetMessage(TEXTO_RESTAURADO);
            }
            else
            {
                SetMessage(TEXTO_INCOMPLETO);
            }

            if (panelAltarPopup != null)
            {
                panelAltarPopup.SetActive(true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (panelAltarPopup != null)
            {
                panelAltarPopup.SetActive(false);
            }
        }
    }

    private void SetMessage(string message)
    {
        if (popupText != null)
        {
            popupText.text = message;
        }
        else if (panelAltarPopup != null)
        {
            TextMeshProUGUI tmp = panelAltarPopup.GetComponentInChildren<TextMeshProUGUI>(true);
            if (tmp != null) tmp.text = message;
        }
    }
}
