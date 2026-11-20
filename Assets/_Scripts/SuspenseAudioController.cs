using UnityEngine;

public class SuspenseAudioController : MonoBehaviour
{
    public static SuspenseAudioController Instance { get; private set; }

    [Header("Configuración de Audio de Suspenso (Solo Lvl 2)")]
    public AudioSource suspenseSource;
    public AudioClip suspenseClip;

    [Header("Tiempos e Intervalos (segundos)")]
    public float minCooldown = 28f;
    public float minRandomInterval = 30f;
    public float maxRandomInterval = 45f;
    [Range(0f, 1f)]
    public float volume = 0.85f;

    private float lastPlayTime = -999f;
    private float nextRandomPulseTime;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
            return;
        }
        Instance = this;
    }

    private void Start()
    {
        nextRandomPulseTime = Time.time + Random.Range(minRandomInterval, maxRandomInterval);
    }

    private void OnDestroy()
    {
        if (Instance == this)
        {
            Instance = null;
        }
    }

    private void Update()
    {
        if (Time.timeScale <= 0f)
            return;

        if (Time.time >= nextRandomPulseTime)
        {
            TryPlaySuspense();
            if (Time.time >= nextRandomPulseTime)
            {
                nextRandomPulseTime = Time.time + Random.Range(minRandomInterval, maxRandomInterval);
            }
        }
    }

    public void TryPlaySuspense()
    {
        if (Time.timeScale <= 0f)
            return;

        if (Time.time - lastPlayTime < minCooldown)
            return;

        if (suspenseSource == null || suspenseClip == null || suspenseSource.isPlaying)
            return;

        lastPlayTime = Time.time;
        nextRandomPulseTime = Time.time + Random.Range(minRandomInterval, maxRandomInterval);
        suspenseSource.PlayOneShot(suspenseClip, volume);
    }
}
