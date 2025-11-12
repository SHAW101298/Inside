using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

/* Type of possible Movements
teleport
stable speed
Lerp
Damp
 
*/
public enum ENUM_MovementType
{
    teleport,
    stable,
    lerp,
    slerp,
    damp
}

public class SimpleMovement : MonoBehaviour
{
    [SerializeField] Transform startPos;
    [SerializeField] Transform endPos;
    [SerializeField] GameObject objectToMove;
    [SerializeField] ENUM_MovementType movementType;
    [SerializeField] bool isActive;
    [SerializeField] bool destroyAfterReachingDestination;
    [SerializeField] bool disableAfterReachingDestination;

    [Header("Stable Movement Values")]
    [SerializeField] float stableSpeed;
    [SerializeField] Vector3 stableDir;
    [SerializeField] float stableSnapDistance;

    [Header("Lerp Movement Values")]
    [SerializeField] float lerpTime;

    [Header("Damp Movement Values")]
    [SerializeField] float dampSmoothTime;
    [SerializeField] Vector3 dampVelocity;
    [SerializeField] float dampSnapDistance;
    [SerializeField] bool snapToEndPosition;

    float timer;
    [Space(20)]
    public UnityEvent EVENT_movementStart;
    public UnityEvent EVENT_movementEnd;
    public UnityEvent EVENT_movementInAction;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isActive == false)
            return;
        Movement();
    }
    public void TRIGGER_StartMovement()
    {
        objectToMove.transform.position = startPos.position;
        EVENT_movementStart.Invoke();
        isActive = true;
        if (movementType == ENUM_MovementType.stable)
        {
            stableDir = (endPos.position - startPos.position).normalized;
            stableDir *= stableSpeed * Time.deltaTime;
        }
    }
    void Movement()
    {
        EVENT_movementInAction.Invoke();
        switch(movementType)
        {
            case ENUM_MovementType.teleport:
                TeleportMovement();
                break;
            case ENUM_MovementType.stable:
                StableMovement();
                break;
            case ENUM_MovementType.lerp:
                LerpMovement();
                break;
            case ENUM_MovementType.damp:
                DampMovement();
                break;
            default:
                TeleportMovement();
                break;
        }
    }
    void TeleportMovement()
    {
        objectToMove.transform.position = endPos.position;
        isActive = false;
        EVENT_movementEnd.Invoke();

        if (destroyAfterReachingDestination == true)
        {
            TriggerDestruction();
        }
    }
    void StableMovement()
    {
        objectToMove.transform.Translate(stableDir);
        float distance = Vector3.Distance(objectToMove.transform.position, endPos.position);
        if(distance <= stableSnapDistance)
        {
            objectToMove.transform.position = endPos.position;
            isActive = false;
            EVENT_movementEnd.Invoke();

            if (destroyAfterReachingDestination == true)
            {
                TriggerDestruction();
            }
        }
    }
    void LerpMovement()
    {
        timer += Time.deltaTime;
        float percent = timer / lerpTime;
        Vector3 pos = Vector3.Lerp(startPos.position, endPos.position, percent);
        objectToMove.transform.position = pos;
        if(timer >= lerpTime)
        {
            isActive = false;
            objectToMove.transform.position = endPos.position;
            timer = 0;
            EVENT_movementEnd.Invoke();

            if (destroyAfterReachingDestination == true)
            {
                TriggerDestruction();
            }
        }
    }
    void DampMovement()
    {
        Vector3 pos = Vector3.SmoothDamp(objectToMove.transform.position, endPos.position, ref dampVelocity, dampSmoothTime);
        objectToMove.transform.position = pos;

        float dist = Vector3.Distance(objectToMove.transform.position, endPos.position);
        if(dist <= dampSnapDistance)
        {
            if(snapToEndPosition == true)
            {
                objectToMove.transform.position = endPos.position;
            }
            isActive = false;
            EVENT_movementEnd.Invoke();
            dampVelocity = Vector3.zero;

            if (destroyAfterReachingDestination == true)
            {
                TriggerDestruction();
            }
        }
    }
    public void TriggerDestruction()
    {
        Destroy(gameObject);
    }
}
