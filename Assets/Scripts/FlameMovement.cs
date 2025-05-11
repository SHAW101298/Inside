using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FlameMovement : MonoBehaviour
{
    [SerializeField] PlayerData player;
    [SerializeField] NavMeshAgent agent;
    [SerializeField] List<Transform> movementPoints;
    [SerializeField] bool moveToNext;
    [SerializeField] int currentPoint = -1;
    bool isActive;
    [SerializeField] float distToPlayer;
    [SerializeField] float maxAllowedDistToPlayer;

    [Header("Debug")]
    [SerializeField] bool followSphere;
    [SerializeField] Transform sphere;
    [SerializeField] Vector3 destination;

    private void Update()
    {
        destination = agent.destination;
        if(followSphere == true)
        {
            agent.SetDestination(sphere.position);
        }

        if (moveToNext == true)
        {
            moveToNext = false;
            currentPoint++;
            if (currentPoint >= movementPoints.Count)
            {
                currentPoint = 0;
            }

            agent.SetDestination(movementPoints[currentPoint].position);
        }


        TrackDistanceToPlayer();
        
    }

    public void StartMovement()
    {
        Debug.Log("Start Movement of flame");
        currentPoint = 0;
        agent.SetDestination(movementPoints[0].position);
        isActive = true;

        //Debug.Log("Is active ? = " + isActive);
    }

    void TrackDistanceToPlayer()
    {
        if (isActive == false)
        {
            return;
        }
        /*
        float distToDest = Vector3.Distance(transform.position, movementPoints[currentPoint].position);
        if(distToDest <= 1)
        {
            float distToPlayer = Vector3.Distance(transform.position, player.transform.position);
            if(distToPlayer <= 1)
            {
                MoveToNextPoint();
            }
        }

        */

        //Debug.Log("Is active = " + isActive);

        distToPlayer = Vector3.Distance(transform.position, player.transform.position);
        if (distToPlayer >= maxAllowedDistToPlayer)
        {
            //Debug.Log("STOP");
            agent.isStopped = true;
        }
        else
        {
            //Debug.Log("ELSE");
            agent.isStopped = false;
            //agent.SetDestination(movementPoints[0].position);
        }
        
    }
    void MoveToNextPoint()
    {
        currentPoint++;
        if (currentPoint >= movementPoints.Count)
        {
            currentPoint--;
        }

        agent.SetDestination(movementPoints[currentPoint].position);
    }
}
