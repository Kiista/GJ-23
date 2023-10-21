using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyChase : MonoBehaviour
{
    public float moveSpeed = 3f;
    public Transform targetPoint;
    private NavMeshAgent agent;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        Vector3 targetDirection = (targetPoint.position - transform.position).normalized;

        rb.velocity = new Vector3(targetDirection.x * moveSpeed, rb.velocity.y, 0);

        agent.SetDestination(targetPoint.position);
    }
}
