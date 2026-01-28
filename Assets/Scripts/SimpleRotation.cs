using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using static UnityEngine.Rendering.DebugUI.Table;

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
    [Header("Slerp")]
    [SerializeField] Vector3 slerpStartRot;
    [SerializeField] Vector3 slerpEndRot;
    [SerializeField] float slerpTime;
    [SerializeField] float slerpTimer;
    [Header("Stable")]
    [SerializeField] Vector3 stableAmount;

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
            case ENUM_MovementType.slerp:
                Slerp();
                break;
            case ENUM_MovementType.stable:
                Stable();
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
            //objectToRotate.transform.localEulerAngles = target;
            endRotation.Invoke();
        }
    }
    void Slerp()
    {
        slerpTimer += Time.deltaTime;

        float t = slerpTimer / slerpTime;
        Vector3 rot = Vector3.Slerp(slerpStartRot, slerpEndRot, t);
        objectToRotate.transform.localEulerAngles = rot;

        dist = Vector3.Distance(objectToRotate.transform.localEulerAngles, slerpEndRot);

        if (dist < switchDistance)
        {
            //objectToRotate.transform.localEulerAngles = target;
            endRotation.Invoke();
        }
    }
    void Stable()
    {
        objectToRotate.transform.Rotate(stableAmount/100);
    }
}
