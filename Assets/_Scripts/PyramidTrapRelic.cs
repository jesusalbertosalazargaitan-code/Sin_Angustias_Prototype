using UnityEngine;

public class PyramidTrapRelic : MonoBehaviour
{
    [Header("Pyramid / Trap Settings")]
    [Tooltip("The collider of the pyramid to disable so the player falls through")]
    public Collider pyramidCollider;

    [Tooltip("Optional trapdoor or hatch object to deactivate or open")]
    public GameObject trapDoor;

    [Header("Audio Settings")]
    public AudioSource audioSource;
    public AudioClip trapSound;

    [Header("Visuals")]
    [Tooltip("Visual object to hide on collection, or defaults to this GameObject's renderer")]
    public GameObject visualModel;

    private bool triggered = false;

    private void Start()
    {
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }
        if (pyramidCollider == null)
        {
            GameObject pyramidGo = GameObject.Find("Pyramid");
            if (pyramidGo != null)
            {
                pyramidCollider = pyramidGo.GetComponent<Collider>();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (triggered) return;

        if (other.CompareTag("Player"))
        {
            triggered = true;
            Debug.Log("[PyramidTrapRelic] Relic collected! Triggering pyramid trap.");

            // Disable pyramid collider / trap door so player falls through
            if (pyramidCollider != null)
            {
                pyramidCollider.enabled = false;
            }
            if (trapDoor != null)
            {
                trapDoor.SetActive(false);
            }

            // Play audio
            if (audioSource != null && trapSound != null)
            {
                audioSource.PlayOneShot(trapSound);
            }
            else if (audioSource != null && audioSource.clip != null)
            {
                audioSource.Play();
            }

            // Hide relic visual
            if (visualModel != null)
            {
                visualModel.SetActive(false);
            }
            else
            {
                Renderer r = GetComponent<Renderer>();
                if (r != null) r.enabled = false;
                foreach (Renderer childRenderer in GetComponentsInChildren<Renderer>())
                {
                    childRenderer.enabled = false;
                }
            }

            // Disable trigger collider so it doesn't trigger again
            Collider c = GetComponent<Collider>();
            if (c != null)
            {
                c.enabled = false;
            }
        }
    }
}

