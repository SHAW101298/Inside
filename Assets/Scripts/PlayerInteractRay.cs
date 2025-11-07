using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteractRay : MonoBehaviour
{
    public PlayerData data;
    [SerializeField] LayerMask infoLayer;
    [SerializeField] LayerMask interactLayer;
    [SerializeField] LayerMask rayCastTriggerLayer;
    [SerializeField] float infoRaycastDistance;
    bool blockedInteractions;

    private void Update()
    {
        RayCastForInteractionsInfo();
    }


    public void ActionInteract(InputAction.CallbackContext context)
    {
        bool flowControl = ActionFlowValidation(context);
        if (!flowControl)
        {
            return;
        }
        RaycastForInteraction(0);
    }
    public void ActionInteract2(InputAction.CallbackContext context)
    {
        bool flowControl = ActionFlowValidation(context);
        if (!flowControl)
        {
            return;
        }
        RaycastForInteraction(1);
    }
    public void ActionLeftMouseButton(InputAction.CallbackContext context)
    {
        bool flowControl = ActionFlowValidation(context);
        if (!flowControl)
        {
            return;
        }
        RaycastForInteraction(2);
    }

    private bool ActionFlowValidation(InputAction.CallbackContext context)
    {
        if (blockedInteractions == true)
            return false;

        if (context.phase != InputActionPhase.Performed)
        {
            return false;
        }

        return true;
    }
    void RaycastForInteraction(int button)
    {
        Vector3 lookDir = data.cam.GetForwardDir();
        RaycastHit hitInfo;

        //Debug.Log("TRYING TO INTERACT");

        if (Physics.Raycast(data.cam.transform.position, lookDir, out hitInfo, infoRaycastDistance, interactLayer) == true)
        {
            hitInfo.collider.gameObject.GetComponent<InteractionHolder>().Interact(button);
        }
    }

    void RayCastForInteractionsInfo()
    {
        Vector3 lookDir = data.cam.GetForwardDir();
        RaycastHit hitInfo;
        if (Physics.Raycast(data.cam.transform.position, lookDir, out hitInfo, infoRaycastDistance, interactLayer) == true)
        {
            InteractionHolder holder = hitInfo.collider.gameObject.GetComponent<InteractionHolder>();
            data.ui.ShowPossibleInteractions(holder);

            HandleLookInteractions(holder);
        }
    }
    
    public void BlockInteractions()
    {
        blockedInteractions = true;
    }
    public void AllowInteractions()
    {
        blockedInteractions = false;
    }

    public void HandleLookInteractions(InteractionHolder holder)
    {
        if (holder.GetPossibleInteractions()[0].GetTriggerBase().GetTriggerType() == ENUM_TriggerTypes.look)
        {
            holder.Interact(0);
            //Debug.Log("LOOK TRIGGER");
        }
    }
}
/* OBSOLETE
void RayCastForInfo()
{
        //Debug.LogError("OBSOLETE, CHANGE ME");
        /*
        Vector3 lookDir = data.cam.GetForwardDir();
        RaycastHit hitInfo;
        if(Physics.Raycast(data.cam.transform.position, lookDir, out hitInfo, infoRaycastDistance, infoLayer) == true)
        {
            string textInfo = hitInfo.collider.gameObject.GetComponent<InformationHolder>().GetInformation();
            data.ui.ShowText(textInfo);
        }   

    }
    void RayCastForTriggers()
{
    //Debug.LogError("OBSOLETE, CHANGE ME");

    Vector3 lookDir = data.cam.GetForwardDir();
    RaycastHit hitInfo;
    if (Physics.Raycast(data.cam.transform.position, lookDir, out hitInfo, infoRaycastDistance, rayCastTriggerLayer) == true)
    {
        hitInfo.collider.gameObject.GetComponent<SimpleTrigger>().TriggerInteraction();
    }

}


*/

