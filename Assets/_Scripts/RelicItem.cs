using UnityEngine;

public enum RelicType
{
    Sol,
    Luna,
    Mezcla
}

public class RelicItem : MonoBehaviour
{
    [Header("Relic Configuration")]
    public RelicType relicType;
    public float rotationSpeed = 60f;
    public float bobbingSpeed = 2f;
    public float bobbingAmount = 0.12f;

    private Vector3 startPos;
    private bool collected = false;

    private void Start()
    {
        startPos = transform.position;
    }

    private void Update()
    {
        // Smooth rotation & gentle bobbing for visual feedback in the catacombs
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime, Space.World);
        transform.position = startPos + new Vector3(0f, Mathf.Sin(Time.time * bobbingSpeed) * bobbingAmount, 0f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (collected) return;

        if (other.CompareTag("Player"))
        {
            collected = true;
            RelicInventoryUI inventory = Object.FindObjectOfType<RelicInventoryUI>();
            if (inventory != null)
            {
                inventory.CollectRelic(relicType);
            }
            else
            {
                GameManager gm = Object.FindObjectOfType<GameManager>();
                if (gm != null) gm.UpdateScore(1);
            }

            Debug.Log($"[RelicItem] ¡Reliquia recolectada: {relicType}!");
            gameObject.SetActive(false);
            Destroy(gameObject, 0.1f);
        }
    }
}

