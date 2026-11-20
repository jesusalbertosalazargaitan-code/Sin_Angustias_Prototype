using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InteraccionHistoria : MonoBehaviour
{
    [Header("Contenido de la Historia")]
    [Tooltip("Escribe aquí el texto que aparecerá al presionar E")]
    [TextArea(6, 15)]
    public string historiaTexto = "Escribe aquí la historia del objeto...";

    [Header("Mensaje de Interacción")]
    public string mensajeAviso = "Presiona [E] para leer historia";

    [Header("Referencias de UI (Canvas)")]
    [Tooltip("Objeto o texto que muestra 'Presiona [E] para leer historia'")]
    public GameObject avisoUI;
    public TextMeshProUGUI textoAvisoUI;

    [Tooltip("Panel completo donde se lee la historia")]
    public GameObject panelHistoriaUI;
    public TextMeshProUGUI textoHistoriaUI;

    [Header("Opciones")]
    public KeyCode teclaInteractuar = KeyCode.E;
    public bool pausarJuegoAlLeer = false;

    private bool jugadorCerca = false;
    private bool leyendoHistoria = false;

    private void Start()
    {
        if (avisoUI != null) avisoUI.SetActive(false);
        if (panelHistoriaUI != null) panelHistoriaUI.SetActive(false);
    }

    private void Update()
    {
        if (!jugadorCerca) return;

        // Abrir o cerrar con la tecla E
        if (Input.GetKeyDown(teclaInteractuar))
        {
            if (!leyendoHistoria)
            {
                AbrirHistoria();
            }
            else
            {
                CerrarHistoria();
            }
        }

        // Permitir cerrar también con Escape
        if (leyendoHistoria && Input.GetKeyDown(KeyCode.Escape))
        {
            CerrarHistoria();
        }
    }

    private void AbrirHistoria()
    {
        leyendoHistoria = true;

        if (avisoUI != null) avisoUI.SetActive(false);

        if (textoHistoriaUI != null)
        {
            textoHistoriaUI.text = historiaTexto;
        }

        if (panelHistoriaUI != null)
        {
            panelHistoriaUI.SetActive(true);
        }

        if (pausarJuegoAlLeer)
        {
            Time.timeScale = 0f;
        }
    }

    public void CerrarHistoria()
    {
        leyendoHistoria = false;

        if (panelHistoriaUI != null)
        {
            panelHistoriaUI.SetActive(false);
        }

        if (jugadorCerca && avisoUI != null)
        {
            avisoUI.SetActive(true);
        }

        if (pausarJuegoAlLeer)
        {
            Time.timeScale = 1f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            jugadorCerca = true;

            if (!leyendoHistoria && avisoUI != null)
            {
                if (textoAvisoUI != null)
                {
                    textoAvisoUI.text = mensajeAviso;
                }
                avisoUI.SetActive(true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            jugadorCerca = false;

            if (avisoUI != null) avisoUI.SetActive(false);
            if (leyendoHistoria) CerrarHistoria();
        }
    }

}
