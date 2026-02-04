using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallDetector : MonoBehaviour
{
    [SerializeField] LayerMask terrainLayer;
    [SerializeField] float checkInterval;
    [SerializeField] float waitTimeUntilTeleport;
    [SerializeField] float checkDistance;
    [SerializeField] Vector3 lastGroundedPosition;
    [SerializeField] bool isOnGround;
    [SerializeField] bool isInAir;
    [SerializeField] float checkTimer;
    [SerializeField] float teleportTimer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        checkTimer += Time.deltaTime;
        if(checkTimer >= checkInterval)
        {
            checkTimer -= checkInterval;
            CheckCurrentState();
        }
        InAir();
    }
    void InAir()
    {
        if (isInAir == false)
            return;


        teleportTimer += Time.deltaTime;
        if(teleportTimer >= waitTimeUntilTeleport)
        {
            PlayerData.instance.TeleportToPosition(lastGroundedPosition);
            teleportTimer = 0;
            isInAir = false;
        }
    }
    void CheckCurrentState()
    {
        RaycastHit hit;
        isOnGround = Physics.Raycast(gameObject.transform.position, Vector3.down, out hit, checkDistance, terrainLayer);
        if(isOnGround == true)
        {
            lastGroundedPosition = hit.point;
        }
        else
        {
            isInAir = true;
        }
    }
}
