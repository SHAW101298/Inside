using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingScript : MonoBehaviour
{
    [SerializeField] GameObject followingObject;
    [SerializeField] GameObject objectToFollow;
    [SerializeField] bool copyPosition;
    [SerializeField] bool copyRotation;
    [SerializeField] bool copyScale;
    [Header("Settings")]
    [SerializeField] bool transformIsLocal;
    [SerializeField] bool useLerp;
    [SerializeField] float lerpSmoothTime;
    bool isActive;

    [Header("Debug")]
    [SerializeField] bool debugActivate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(debugActivate == true)
        {
            debugActivate = false;
            isActive = true;
        }
        if(transformIsLocal == true)
        {
            LocalTransform();
        }
        else
        {
            GlobalTransform();
        }
    }
    void LocalTransform()
    {
        if(useLerp == false)
        {
            if (copyPosition == true)
            {
                followingObject.transform.localPosition = objectToFollow.transform.localPosition;
            }
            if (copyRotation == true)
            {
                followingObject.transform.localEulerAngles = objectToFollow.transform.localEulerAngles;
            }
            if (copyScale == true)
            {
                followingObject.transform.localScale = objectToFollow.transform.localScale;
            }
        }
        else
        {
            if (copyPosition == true)
            {
                //followingObject.transform.localPosition = objectToFollow.transform.localPosition;
                Vector3 newPos = Vector3.Lerp(followingObject.transform.localPosition, objectToFollow.transform.localPosition, lerpSmoothTime);
                followingObject.transform.localPosition = newPos;
            }
            if (copyRotation == true)
            {
                followingObject.transform.localEulerAngles = objectToFollow.transform.localEulerAngles;
            }
            if (copyScale == true)
            {
                followingObject.transform.localScale = objectToFollow.transform.localScale;
            }
        }
        
    }
    void GlobalTransform()
    {
        if (copyPosition == true)
        {
            followingObject.transform.position = objectToFollow.transform.position;
        }
        if (copyRotation == true)
        {
            followingObject.transform.eulerAngles = objectToFollow.transform.eulerAngles;
        }
        if (copyScale == true)
        {
            followingObject.transform.localScale = objectToFollow.transform.localScale;
        }
    }
}
