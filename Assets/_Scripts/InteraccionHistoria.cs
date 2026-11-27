using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InteraccionHistoria : MonoBehaviour
{
    private static readonly List<InteraccionHistoria> instancias = new List<InteraccionHistoria>();
    private static InteraccionHistoria instanciaActiva;

    [Header("Contenido de la Historia")]
    [Tooltip("Escribe aquí el texto que aparecerá al presionar E")]
    [TextArea(6, 15)]
    public string historiaTexto = "Escribe aquí la historia del objeto...";

    [Header("Mensaje de Interacción")]
    public string mensajeAviso = "Presiona [E] para traducir";

    [Header("Referencias de UI (Canvas)")]
    [Tooltip("Objeto o texto que muestra 'Presiona [E] para traducir'")]
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

    private void OnEnable()
    {
        if (!instancias.Contains(this))
        {
            instancias.Add(this);
        }
    }

    private void OnDisable()
    {
        if (instanciaActiva == this)
        {
            ForzarCierreTotal(null);
            instanciaActiva = null;
        }
        else
        {
            jugadorCerca = false;
            leyendoHistoria = false;
        }
        instancias.Remove(this);
    }

    private void Start()
    {
        if (avisoUI != null) avisoUI.SetActive(false);
        if (panelHistoriaUI != null) panelHistoriaUI.SetActive(false);
    }

    private void Update()
    {
        if (!jugadorCerca || GameOverUIController.IsGameOverActive) return;
        if (instanciaActiva != null && instanciaActiva != this) return;

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

        if (leyendoHistoria && Input.GetKeyDown(KeyCode.Escape))
        {
            CerrarHistoria();
        }
    }

    public static void CerrarTodosLosAvisosYPaneles(InteraccionHistoria excepto = null)
    {
        for (int i = instancias.Count - 1; i >= 0; i--)
        {
            InteraccionHistoria inst = instancias[i];
            if (inst == null)
            {
                instancias.RemoveAt(i);
                continue;
            }
            if (inst != excepto)
            {
                inst.ForzarCierreTotal(excepto);
            }
        }

        if (excepto == null)
        {
            instanciaActiva = null;
        }
    }

    private void ForzarCierreTotal(InteraccionHistoria nuevaActiva)
    {
        leyendoHistoria = false;

        if (avisoUI != null && (nuevaActiva == null || nuevaActiva.avisoUI != avisoUI))
        {
            avisoUI.SetActive(false);
        }

        if (panelHistoriaUI != null && (nuevaActiva == null || nuevaActiva.panelHistoriaUI != panelHistoriaUI))
        {
            panelHistoriaUI.SetActive(false);
        }

        if (pausarJuegoAlLeer && Time.timeScale == 0f && !GameOverUIController.IsGameOverActive)
        {
            Time.timeScale = 1f;
        }
    }

    private void MostrarAvisoSiEnRango()
    {
        if (!jugadorCerca || leyendoHistoria || avisoUI == null) return;

        if (textoAvisoUI != null)
        {
            textoAvisoUI.text = string.IsNullOrEmpty(mensajeAviso) ? "Presiona [E] para traducir" : mensajeAviso.Trim();
        }
        avisoUI.SetActive(true);
    }

    private void AbrirHistoria()
    {
        CerrarTodosLosAvisosYPaneles(this);
        instanciaActiva = this;
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

        if (jugadorCerca && instanciaActiva == this)
        {
            MostrarAvisoSiEnRango();
        }

        if (pausarJuegoAlLeer && !GameOverUIController.IsGameOverActive)
        {
            Time.timeScale = 1f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player") || GameOverUIController.IsGameOverActive) return;

        CerrarTodosLosAvisosYPaneles(this);
        jugadorCerca = true;
        instanciaActiva = this;
        leyendoHistoria = false;

        MostrarAvisoSiEnRango();
    }

    private void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        jugadorCerca = false;
        leyendoHistoria = false;

        if (instanciaActiva == this)
        {
            ForzarCierreTotal(null);
            instanciaActiva = null;

            for (int i = 0; i < instancias.Count; i++)
            {
                InteraccionHistoria otra = instancias[i];
                if (otra != null && otra != this && otra.jugadorCerca && otra.isActiveAndEnabled)
                {
                    instanciaActiva = otra;
                    otra.MostrarAvisoSiEnRango();
                    break;
                }
            }
        }
        else
        {
            if (avisoUI != null && (instanciaActiva == null || instanciaActiva.avisoUI != avisoUI))
            {
                avisoUI.SetActive(false);
            }
            if (panelHistoriaUI != null && (instanciaActiva == null || instanciaActiva.panelHistoriaUI != panelHistoriaUI))
            {
                panelHistoriaUI.SetActive(false);
            }
        }
    }
}