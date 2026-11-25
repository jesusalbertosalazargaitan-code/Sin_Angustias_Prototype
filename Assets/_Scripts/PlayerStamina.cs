using System;
using UnityEngine;

public class PlayerStamina : MonoBehaviour
{
    [Header("Configuración de Estamina")]
    public float maxStamina = 100f;
    public float currentStamina = 100f;
    public float drainRate = 25f;
    public float regenRate = 18f;
    public float exhaustedRegenRate = 12f;
    public float exhaustionCooldown = 2.5f;
    public float minSprintThreshold = 25f;

    [Header("Referencias")]
    public PlayerController playerController;

    private bool wantsToSprint = false;
    private float cooldownTimer = 0f;

    public bool IsExhausted { get; private set; }
    public bool CanSprint => !IsExhausted && currentStamina > 0.1f;
    public float NormalizedStamina => maxStamina > 0f ? Mathf.Clamp01(currentStamina / maxStamina) : 0f;

    public event Action<float, bool> OnStaminaUpdated;

    private void Awake()
    {
        if (playerController == null)
        {
            playerController = GetComponent<PlayerController>();
        }
        currentStamina = Mathf.Clamp(currentStamina, 0f, maxStamina);
    }

    private void Start()
    {
        OnStaminaUpdated?.Invoke(NormalizedStamina, IsExhausted);
    }

    public void SetSprintIntent(bool intent)
    {
        wantsToSprint = intent;
    }

    private void Update()
    {
        if (Time.timeScale <= 0f) return;
        if (playerController != null && (!playerController.enabled || playerController.GameOver)) return;

        if (wantsToSprint && CanSprint)
        {
            currentStamina -= drainRate * Time.deltaTime;
            if (currentStamina <= 0f)
            {
                currentStamina = 0f;
                IsExhausted = true;
                cooldownTimer = exhaustionCooldown;
            }
        }
        else
        {
            if (IsExhausted)
            {
                if (cooldownTimer > 0f)
                {
                    cooldownTimer -= Time.deltaTime;
                }
                currentStamina = Mathf.Min(maxStamina, currentStamina + exhaustedRegenRate * Time.deltaTime);

                if (cooldownTimer <= 0f && currentStamina >= minSprintThreshold)
                {
                    IsExhausted = false;
                    cooldownTimer = 0f;
                }
            }
            else
            {
                if (currentStamina < maxStamina)
                {
                    currentStamina = Mathf.Min(maxStamina, currentStamina + regenRate * Time.deltaTime);
                }
            }
        }

        OnStaminaUpdated?.Invoke(NormalizedStamina, IsExhausted);
    }
}
