using System.Collections;
using UnityEngine;

public class DoorSlideController : MonoBehaviour
{
    [Header("Door Movement Settings")]
    [Tooltip("Distancia que descenderá la puerta hacia el suelo (Vector3.down)")]
    public float slideDistance = 4.2f;

    [Tooltip("Velocidad de movimiento en unidades por segundo")]
    public float slideSpeed = 1.5f;

    [Tooltip("Fuente de audio opcional para sonido de apertura")]
    public AudioSource audioSource;

    private Vector3 startPosition;
    private Vector3 targetPosition;
    private bool isOpen = false;
    private Collider doorCollider;

    public bool IsOpen => isOpen;

    private void Awake()
    {
        startPosition = transform.position;
        targetPosition = startPosition + Vector3.down * slideDistance;
        doorCollider = GetComponent<Collider>();
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }
    }
    
    public void OpenDoor()
    {
        if (isOpen) return;
        isOpen = true;

        if (audioSource != null && audioSource.clip != null)
        {
            audioSource.Play();
        }

        StartCoroutine(SlideRoutine());
    }

    private IEnumerator SlideRoutine()
    {
        yield return new WaitForSeconds(5f);

        while (Vector3.Distance(transform.position, targetPosition) > 0.01f)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, slideSpeed * Time.deltaTime);
            yield return null;
        }

        transform.position = targetPosition;

        // Desactivar collider al finalizar para garantizar paso completamente libre hacia Trigger_Escape_MVP
        if (doorCollider != null)
        {
            doorCollider.enabled = false;
        }

        Debug.Log("[DoorSlideController] La puerta de salida se ha abierto completamente.");
    }
}
