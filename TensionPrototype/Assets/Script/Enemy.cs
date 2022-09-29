using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{   
    private NavMeshAgent ghost;

    public GameObject player;

    public bool isChasing = false;

    public float chaseDistance = 3.0f;


    // Start is called before the first frame update
    void Start()
    {
        ghost = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.transform.position);

        if (distance < chaseDistance && isChasing)
        {
            Vector3 directionToPlayer = transform.position - player.transform.position;

            Vector3 newPos = transform.position - directionToPlayer;

            ghost.SetDestination(newPos);
        }
    }
}
