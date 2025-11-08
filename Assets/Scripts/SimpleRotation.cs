using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SimpleRotation : MonoBehaviour
{
    [SerializeField] GameObject objectToRotate;
    [SerializeField] Vector3 rotationValue;
    [SerializeField] ENUM_MovementType rotationType;
    public UnityEvent startRotation;
    public UnityEvent endRotation;


    [Header("Smooth Damp")]
    [SerializeField] Vector3 target;
    [SerializeField] float smoothTime;
    Vector3 currentVelocity;

    [Header("Debug")]
    [SerializeField] float dist;
    [SerializeField] float switchDistance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Rotate();
    }
    void Rotate()
    {
        switch (rotationType)
        {
            case ENUM_MovementType.damp:
                DampenedRotation();
                break;
            default:
                break;
        }

    }
    void DampenedRotation()
    {
        rotationValue = Vector3.SmoothDamp(objectToRotate.transform.localEulerAngles, target, ref currentVelocity, smoothTime);
        objectToRotate.transform.localEulerAngles = rotationValue;

        Vector3 difference = target - objectToRotate.transform.localEulerAngles;
        dist = Vector3.Distance(difference, Vector3.zero);

        if(dist < switchDistance)
        {
            endRotation.Invoke();
        }
    }
}
