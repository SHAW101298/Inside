using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockMoving : MonoBehaviour
{
    [SerializeField] float maxMoveDistance;
    [SerializeField] LayerMask moveLayerMask;
    [SerializeField] float smoothTime;
    Vector3 dest;
    Vector3 offset;

    [Header("Debug")]
    [SerializeField] bool isHeld;
    [SerializeField] PlayerData player;
    [SerializeField] Vector3 velocity;

    public void Grab()
    {
        isHeld = true;
    }
    public void Release()
    {
        isHeld = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(isHeld == true)
        {
            Vector3 dir = player.cam.GetForwardDir();
            RaycastHit hitInfo;
            Physics.Raycast(player.cam.transform.position, dir, out hitInfo, maxMoveDistance, moveLayerMask);
            dest = hitInfo.point;
            gameObject.transform.position = Vector3.SmoothDamp(gameObject.transform.position, dest, ref velocity, smoothTime);
        }

        
    }
}
