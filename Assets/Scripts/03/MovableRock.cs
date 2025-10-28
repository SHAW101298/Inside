using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableRock : MonoBehaviour
{
    [SerializeField] Vector3 desiredPosition;
    [SerializeField] Vector3 grabPoint;
    Vector3 tempPos;
    [SerializeField] bool isHeld;
    [SerializeField] bool finishedMovement;

    [Header("Data")]
    [SerializeField] float smoothTime;
    [SerializeField] Vector3 velocity;
    RockMoving rm;
    [SerializeField] GameObject debugSPhere;
    [SerializeField] Vector3 current;

    // Start is called before the first frame update
    void Start()
    {
        rm = RockMoving.Instance;
    }

    // Update is called once per frame
    void Update()
    {
        HeldAction();
        Movement();
    }
    void Movement()
    {
        if(finishedMovement == true)
        {
            return;
        }
        current = transform.position - grabPoint;
        tempPos = Vector3.SmoothDamp(current, desiredPosition, ref velocity, smoothTime);
        gameObject.transform.position = tempPos;

        float dist = Vector3.Distance(tempPos, desiredPosition);
        //Debug.Log("dist = " + dist);
        if(dist < 0.1f )
        {
            finishedMovement = true;        
        }
    }
    void HeldAction()
    {
        if (isHeld == false)
        {
            return;
        }
        Vector3 dir = rm.player.cam.GetForwardDir();
        RaycastHit hitInfo;
        Physics.Raycast(rm.player.cam.transform.position, dir*3, out hitInfo, rm.moveLayerMask);

        desiredPosition = hitInfo.point + grabPoint;
        debugSPhere.transform.position = desiredPosition;
        finishedMovement = false;
    }
    public void Grab()
    {
        Debug.Log("GRAB");
        Vector3 dir = rm.player.cam.GetForwardDir();
        RaycastHit hitInfo;
        Physics.Raycast(rm.player.cam.transform.position, dir, out hitInfo, rm.interactionLayer);
        //Debug.Log("Hit point = " + hitInfo.point);
        //Debug.Log("pos = " + gameObject.transform.position);
        grabPoint = hitInfo.point - gameObject.transform.position;
        grabPoint = gameObject.transform.position - hitInfo.point;
        //Debug.Log("Difference = " + grabPoint);
        //GameObject temp = Instantiate(GameObject.CreatePrimitive(PrimitiveType.Sphere));
        //temp.transform.localScale *= 0.1f;
        //temp.transform.position = hitInfo.point;
        isHeld = true;
        rm.GrabRock(this);
    }
    public void Release()
    {
        Debug.Log("RELEASE");
        isHeld = false;
    }

}
