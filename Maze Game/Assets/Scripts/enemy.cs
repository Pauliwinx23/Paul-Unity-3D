using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    // Enemy settings
    public float detectionRange = 10f;
    public float chaseRange = 5f;
    public NavMeshAgent agent;
    public float moveSpeed = 5f;
    public float rotationSpeed = 5f;
    public Transform player;

    bool isDetecting = false;
    bool isChasing = false;
    bool isAttacking = false;

    void Update()
    {

        float distanceToPlayer = Vector3.Distance(transform.position, player.position);
        if (distanceToPlayer <= detectionRange)
        {
            isDetecting = true;
        }
        else
        {
            isDetecting = false;
        }

        if (isDetecting)
        {
            if (distanceToPlayer <= chaseRange)
            {
                isChasing = true;
            }
            else
            {
                isChasing = false;
            }
        }

        if (isChasing)
        {
            MoveTowardsPlayer();
        }
    }

    void MoveTowardsPlayer()
    {
        agent.SetDestination(player.position);

        // Use iTween to move towards player
        iTween.MoveTo(gameObject, player.position, moveSpeed);
        iTween.RotateTo(gameObject, player.position, rotationSpeed);
    }
}