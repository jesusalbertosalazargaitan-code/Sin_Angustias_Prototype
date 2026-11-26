using UnityEngine;

public enum NPCMode
{
    StaticIdle = 0,
    TalkingPair = 1,
    WaypointRoam = 2
}

public class AmbientNPCController : MonoBehaviour
{
    [Header("Behavior Mode")]
    public NPCMode mode = NPCMode.StaticIdle;

    [Header("Idle Variation Settings")]
    public float idleSwitchMinTime = 6f;
    public float idleSwitchMaxTime = 14f;
    public float idleBlendSpeed = 0.65f;

    [Header("Talking Pair Settings")]
    public Transform talkPartner;
    public float talkTurnMinTime = 4f;
    public float talkTurnMaxTime = 8f;

    [Header("Waypoint Roam Settings")]
    public Transform[] waypoints;
    public float walkSpeed = 1.45f;
    public float rotationSpeed = 5f;
    public float waitAtWaypointMin = 2.5f;
    public float waitAtWaypointMax = 5f;
    public float waypointThreshold = 0.25f;

    [Header("Obstacle Avoidance")]
    public float obstacleLookAhead = 1.0f;
    public float stuckTimeout = 1.5f;
    public float pushForce = 1.5f;

    private Animator animator;
    private CapsuleCollider bodyCollider;
    private float idleSwitchTimer;
    private float currentIdleVariant;
    private float targetIdleVariant;

    private float talkTimer;
    private bool isTalkingState;

    private int currentWaypointIndex;
    private float waypointWaitTimer;
    private float stuckTimer;

    private static readonly int SpeedHash = Animator.StringToHash("Speed");
    private static readonly int IdleVariantHash = Animator.StringToHash("IdleVariant");
    private static readonly int IsTalkingHash = Animator.StringToHash("IsTalking");

    private void Awake()
    {
        bodyCollider = GetComponent<CapsuleCollider>();
        animator = GetComponent<Animator>();
        if (animator == null)
        {
            animator = GetComponentInChildren<Animator>();
        }

        if (animator != null)
        {
            animator.applyRootMotion = false;
        }
    }

    private void Start()
    {
        currentIdleVariant = Random.value > 0.5f ? 1f : 0f;
        targetIdleVariant = currentIdleVariant;
        idleSwitchTimer = Random.Range(0f, 4f) + Random.Range(idleSwitchMinTime, idleSwitchMaxTime);

        SnapToGround();

        if (mode == NPCMode.TalkingPair)
        {
            isTalkingState = Random.value > 0.45f;
            talkTimer = Random.Range(1.0f, 3.0f) + Random.Range(talkTurnMinTime, talkTurnMaxTime);
        }
        else if (mode == NPCMode.WaypointRoam)
        {
            isTalkingState = false;
            EnsureWaypoints();
            waypointWaitTimer = Random.Range(0.2f, 2.5f);
        }
        else
        {
            isTalkingState = false;
        }

        if (animator != null)
        {
            animator.applyRootMotion = false;
            animator.SetFloat(IdleVariantHash, currentIdleVariant);
            animator.SetFloat(SpeedHash, 0f);
            animator.SetBool(IsTalkingHash, isTalkingState);
            animator.Play(0, 0, Random.Range(0f, 1f));
        }
    }

    private void Update()
    {
        if (Time.timeScale <= 0f) return;

        UpdateIdleVariation();

        switch (mode)
        {
            case NPCMode.StaticIdle:
                if (animator != null)
                {
                    animator.SetBool(IsTalkingHash, false);
                    animator.SetFloat(SpeedHash, 0f, 0.2f, Time.deltaTime);
                }
                break;

            case NPCMode.TalkingPair:
                UpdateTalkingPair();
                break;

            case NPCMode.WaypointRoam:
                UpdateWaypointRoam();
                break;
        }
    }

    private void UpdateIdleVariation()
    {
        idleSwitchTimer -= Time.deltaTime;
        if (idleSwitchTimer <= 0f)
        {
            targetIdleVariant = targetIdleVariant < 0.5f ? 1f : 0f;
            idleSwitchTimer = Random.Range(idleSwitchMinTime, idleSwitchMaxTime);
        }

        currentIdleVariant = Mathf.MoveTowards(currentIdleVariant, targetIdleVariant, idleBlendSpeed * Time.deltaTime);
        if (animator != null)
        {
            animator.SetFloat(IdleVariantHash, currentIdleVariant);
        }
    }

    private void UpdateTalkingPair()
    {
        if (talkPartner != null)
        {
            Vector3 toPartner = talkPartner.position - transform.position;
            toPartner.y = 0f;
            if (toPartner.sqrMagnitude > 0.001f)
            {
                Quaternion targetRot = Quaternion.LookRotation(toPartner.normalized, Vector3.up);
                transform.rotation = Quaternion.Slerp(transform.rotation, targetRot, rotationSpeed * Time.deltaTime);
            }
        }

        talkTimer -= Time.deltaTime;
        if (talkTimer <= 0f)
        {
            isTalkingState = !isTalkingState;
            talkTimer = Random.Range(talkTurnMinTime, talkTurnMaxTime);
        }

        if (animator != null)
        {
            animator.SetFloat(SpeedHash, 0f, 0.2f, Time.deltaTime);
            animator.SetBool(IsTalkingHash, isTalkingState);
        }
    }

    private void UpdateWaypointRoam()
    {
        if (animator != null)
        {
            animator.SetBool(IsTalkingHash, false);
        }

        if (waypoints == null || waypoints.Length == 0)
        {
            if (animator != null)
            {
                animator.SetFloat(SpeedHash, 0f, 0.2f, Time.deltaTime);
            }
            return;
        }

        if (waypointWaitTimer > 0f)
        {
            waypointWaitTimer -= Time.deltaTime;
            if (animator != null)
            {
                animator.SetFloat(SpeedHash, 0f, 0.2f, Time.deltaTime);
            }
            return;
        }

        Transform targetWP = waypoints[currentWaypointIndex];
        if (targetWP == null)
        {
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
            return;
        }

        Vector3 currentPos = transform.position;
        Vector3 flatCurrent = new Vector3(currentPos.x, 0f, currentPos.z);
        Vector3 flatTarget = new Vector3(targetWP.position.x, 0f, targetWP.position.z);

        Vector3 toTarget = flatTarget - flatCurrent;
        if (toTarget.magnitude <= waypointThreshold)
        {
            stuckTimer = 0f;
            waypointWaitTimer = Random.Range(waitAtWaypointMin, waitAtWaypointMax);
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
            if (animator != null)
            {
                animator.SetFloat(SpeedHash, 0f, 0.2f, Time.deltaTime);
            }
            return;
        }

        Vector3 desiredDir = toTarget.normalized;
        float stepDist = walkSpeed * Time.deltaTime;
        bool hasMoveDir = ComputeAvoidanceDirection(currentPos, desiredDir, obstacleLookAhead, stepDist, out Vector3 moveDir);

        Vector3 finalPos = currentPos;
        if (hasMoveDir)
        {
            Vector3 nextFlat = flatCurrent + moveDir * stepDist;
            float groundY = SampleGroundY(nextFlat.x, currentPos.y, nextFlat.z);
            finalPos = new Vector3(nextFlat.x, groundY, nextFlat.z);
            transform.position = finalPos;

            Quaternion targetRot = Quaternion.LookRotation(moveDir, Vector3.up);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRot, rotationSpeed * Time.deltaTime);
        }

        float movedDist = Vector3.Distance(
            new Vector3(currentPos.x, 0f, currentPos.z),
            new Vector3(finalPos.x, 0f, finalPos.z)
        );
        if (!hasMoveDir || movedDist < walkSpeed * 0.25f * Time.deltaTime)
        {
            stuckTimer += Time.deltaTime;
            if (stuckTimer >= stuckTimeout)
            {
                stuckTimer = 0f;
                waypointWaitTimer = 0.4f;
                currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
            }
        }
        else
        {
            stuckTimer = Mathf.Max(0f, stuckTimer - Time.deltaTime * 2f);
        }

        if (animator != null)
        {
            animator.SetFloat(SpeedHash, hasMoveDir ? 1f : 0f, 0.2f, Time.deltaTime);
        }
    }

    private bool ComputeAvoidanceDirection(
        Vector3 currentPos,
        Vector3 desiredDir,
        float lookAheadDist,
        float stepDist,
        out Vector3 bestDir)
    {
        bestDir = desiredDir;

        if (!IsDirectionBlocked(currentPos, desiredDir, lookAheadDist, out RaycastHit primaryHit))
        {
            return true;
        }

        // Prioritize steering along the tangent aligned with the obstacle surface
        Vector3 tangent = Vector3.ProjectOnPlane(desiredDir, primaryHit.normal);
        tangent.y = 0f;
        float sideSign = (tangent.sqrMagnitude > 0.001f && Vector3.SignedAngle(desiredDir, tangent.normalized, Vector3.up) < 0f)
            ? -1f
            : 1f;

        float[] angles = new float[]
        {
            35f * sideSign, -35f * sideSign,
            60f * sideSign, -60f * sideSign,
            90f * sideSign, -90f * sideSign,
            120f * sideSign, -120f * sideSign
        };

        float steerLookAhead = Mathf.Max(0.5f, lookAheadDist * 0.75f);
        float immediateDist = stepDist + 0.15f;

        foreach (float angle in angles)
        {
            Vector3 candidate = Quaternion.AngleAxis(angle, Vector3.up) * desiredDir;
            candidate.y = 0f;
            candidate.Normalize();

            if (!IsDirectionBlocked(currentPos, candidate, steerLookAhead, out _)
                && !IsDirectionBlocked(currentPos, candidate, immediateDist, out _))
            {
                bestDir = candidate;
                return true;
            }
        }

        // Last resort: check if the immediate step in tangent/any angle is clear even if lookAhead sees a distant wall
        foreach (float angle in angles)
        {
            Vector3 candidate = Quaternion.AngleAxis(angle, Vector3.up) * desiredDir;
            candidate.y = 0f;
            candidate.Normalize();

            if (!IsDirectionBlocked(currentPos, candidate, immediateDist, out _))
            {
                bestDir = candidate;
                return true;
            }
        }

        bestDir = Vector3.zero;
        return false;
    }

    private bool IsDirectionBlocked(Vector3 currentPos, Vector3 dir, float distance, out RaycastHit nearestHit)
    {
        nearestHit = default;
        float radius = 0.28f;
        float height = 1.5f;

        if (bodyCollider != null)
        {
            float maxXZ = Mathf.Max(transform.lossyScale.x, transform.lossyScale.z);
            radius = Mathf.Max(0.18f, bodyCollider.radius * maxXZ);
            height = Mathf.Max(radius * 2f + 0.1f, bodyCollider.height * transform.lossyScale.y);
        }

        float bottomClearance = 0.22f;
        Vector3 p1 = new Vector3(currentPos.x, currentPos.y + radius + bottomClearance, currentPos.z);
        Vector3 p2 = new Vector3(currentPos.x, currentPos.y + Mathf.Max(radius + bottomClearance + 0.1f, height - radius), currentPos.z);

        RaycastHit[] hits = Physics.CapsuleCastAll(p1, p2, radius, dir, distance, ~0, QueryTriggerInteraction.Ignore);
        float closestDist = float.MaxValue;
        bool blocked = false;

        foreach (RaycastHit hit in hits)
        {
            if (hit.collider == null) continue;
            if (hit.collider.transform == transform || hit.collider.transform.IsChildOf(transform)) continue;
            if (hit.collider is TerrainCollider) continue;
            if (hit.normal.y > 0.65f) continue;

            // Gently push dynamic non-character Rigidbodies without walking through them
            Rigidbody hitRb = hit.collider.attachedRigidbody;
            if (hitRb != null && !hitRb.isKinematic && !hit.collider.CompareTag("Player") && !hit.collider.CompareTag("Enemy"))
            {
                hitRb.AddForceAtPosition(dir * pushForce, hit.point, ForceMode.Force);
            }

            if (hit.distance < closestDist)
            {
                closestDist = hit.distance;
                nearestHit = hit;
                blocked = true;
            }
        }

        return blocked;
    }

    public void SnapToGround()
    {
        Vector3 pos = transform.position;
        pos.y = SampleGroundY(pos.x, pos.y, pos.z);
        transform.position = pos;
    }

    public static float SampleGroundY(float x, float currentY, float z)
    {
        float terrainY = currentY;
        Terrain terrain = Terrain.activeTerrain;
        if (terrain != null)
        {
            terrainY = terrain.SampleHeight(new Vector3(x, 0f, z)) + terrain.transform.position.y;
        }

        Vector3 rayOrigin = new Vector3(x, Mathf.Max(currentY, terrainY) + 3.0f, z);
        if (Physics.Raycast(rayOrigin, Vector3.down, out RaycastHit hit, 10.0f, ~0, QueryTriggerInteraction.Ignore))
        {
            if (hit.collider != null && (terrain == null || !hit.collider.transform.IsChildOf(terrain.transform)))
            {
                if (Mathf.Abs(hit.point.y - terrainY) < 0.5f)
                {
                    return hit.point.y;
                }
            }
        }

        return terrainY;
    }

    private void EnsureWaypoints()
    {
        if (waypoints != null && waypoints.Length > 0)
        {
            for (int i = 0; i < waypoints.Length; i++)
            {
                if (waypoints[i] != null) return;
            }
        }

        GameObject wpRoot = new GameObject(gameObject.name + "_AutoWaypoints");
        Vector3 origin = transform.position;
        Vector3[] offsets = new Vector3[]
        {
            Vector3.zero,
            new Vector3(4.0f, 0f, 2.5f),
            new Vector3(-3.0f, 0f, 4.5f)
        };

        waypoints = new Transform[offsets.Length];
        for (int i = 0; i < offsets.Length; i++)
        {
            GameObject wp = new GameObject("WP_" + (i + 1));
            wp.transform.SetParent(wpRoot.transform, false);
            Vector3 pos = origin + offsets[i];
            pos.y = SampleGroundY(pos.x, origin.y, pos.z);
            wp.transform.position = pos;
            waypoints[i] = wp.transform;
        }
    }
}
