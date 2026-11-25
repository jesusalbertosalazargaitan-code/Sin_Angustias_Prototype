using UnityEngine;
using UnityEngine.UI;

public class StaminaBarUI : MonoBehaviour
{
    [Header("Referencias")]
    public PlayerStamina playerStamina;
    public Image fillImage;
    public CanvasGroup canvasGroup;

    [Header("Colores de Estado")]
    public Color normalColor = new Color(0.2f, 0.85f, 0.45f, 1f);
    public Color lowColor = new Color(0.95f, 0.7f, 0.15f, 1f);
    public Color exhaustedColor = new Color(0.9f, 0.2f, 0.2f, 1f);

    private float targetNormalized = 1f;
    private bool isExhaustedState = false;

    private void Awake()
    {
        if (canvasGroup == null)
        {
            canvasGroup = GetComponent<CanvasGroup>();
        }
    }

    private void OnEnable()
    {
        ResolveAndSubscribe();
    }

    private void Start()
    {
        ResolveAndSubscribe();
        if (playerStamina != null)
        {
            HandleStaminaUpdated(playerStamina.NormalizedStamina, playerStamina.IsExhausted);
        }
    }

    private void OnDisable()
    {
        if (playerStamina != null)
        {
            playerStamina.OnStaminaUpdated -= HandleStaminaUpdated;
        }
    }

    private void ResolveAndSubscribe()
    {
        if (playerStamina == null)
        {
            GameObject playerObj = GameObject.FindGameObjectWithTag("Player");
            if (playerObj == null) playerObj = GameObject.Find("Player");
            if (playerObj != null)
            {
                playerStamina = playerObj.GetComponent<PlayerStamina>();
            }
        }

        if (playerStamina != null)
        {
            playerStamina.OnStaminaUpdated -= HandleStaminaUpdated;
            playerStamina.OnStaminaUpdated += HandleStaminaUpdated;
        }
    }

    private void HandleStaminaUpdated(float normalizedValue, bool isExhausted)
    {
        targetNormalized = Mathf.Clamp01(normalizedValue);
        isExhaustedState = isExhausted;
        UpdateVisuals();
    }

    private void Update()
    {
        if (playerStamina == null)
        {
            ResolveAndSubscribe();
        }
        UpdateVisuals();
    }

    private void UpdateVisuals()
    {
        if (fillImage != null)
        {
            fillImage.fillAmount = targetNormalized;

            if (isExhaustedState)
            {
                float pulse = Mathf.PingPong(Time.unscaledTime * 4f, 1f);
                Color pulseTarget = new Color(
                    Mathf.Clamp01(exhaustedColor.r * 0.55f),
                    Mathf.Clamp01(exhaustedColor.g * 0.55f),
                    Mathf.Clamp01(exhaustedColor.b * 0.55f),
                    exhaustedColor.a
                );
                fillImage.color = Color.Lerp(pulseTarget, exhaustedColor, pulse);
            }
            else if (targetNormalized < 0.30f)
            {
                float t = Mathf.Clamp01(targetNormalized / 0.30f);
                fillImage.color = Color.Lerp(lowColor, normalColor, t);
            }
            else
            {
                fillImage.color = normalColor;
            }
        }

        if (canvasGroup != null)
        {
            float targetAlpha = (targetNormalized >= 0.999f && !isExhaustedState) ? 0.65f : 1.0f;
            canvasGroup.alpha = Mathf.MoveTowards(canvasGroup.alpha, targetAlpha, Time.unscaledDeltaTime * 4f);
        }
    }
}
