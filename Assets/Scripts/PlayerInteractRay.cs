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

    public void ActionInteract(InputAction.CallbackContext context)
    {
        if (blockedInteractions == true)
            return;

        if (context.phase != InputActionPhase.Performed)
        {
            return;
        }
        Vector3 lookDir = data.cam.GetForwardDir();
        RaycastHit hitInfo;

        //Debug.Log("TRYING TO INTERACT");

        if (Physics.Raycast(data.cam.transform.position, lookDir, out hitInfo, infoRaycastDistance, interactLayer) == true)
        {
            hitInfo.collider.gameObject.GetComponent<InteractionHolder>().Interact(0);
        }
    }
    public void ActionInteract2(InputAction.CallbackContext context)
    {
        if (blockedInteractions == true)
            return;

        if (context.phase != InputActionPhase.Performed)
        {
            return;
        }
        Vector3 lookDir = data.cam.GetForwardDir();
        RaycastHit hitInfo;

        //Debug.Log("TRYING TO INTERACT");

        if (Physics.Raycast(data.cam.transform.position, lookDir, out hitInfo, infoRaycastDistance, interactLayer) == true)
        {
            hitInfo.collider.gameObject.GetComponent<InteractionHolder>().Interact(1);
        }
    }
    public void ActionLeftMouseButton(InputAction.CallbackContext context)
    {
        if (blockedInteractions == true)
            return;

        if (context.phase != InputActionPhase.Performed)
        {
            return;
        }
        Vector3 lookDir = data.cam.GetForwardDir();
        RaycastHit hitInfo;

        //Debug.Log("TRYING TO INTERACT");

        if (Physics.Raycast(data.cam.transform.position, lookDir, out hitInfo, infoRaycastDistance, interactLayer) == true)
        {
            hitInfo.collider.gameObject.GetComponent<InteractionHolder>().Interact(2);
        }
    }


    private void Update()
    {
        RayCastForInfo();
        RayCastForTriggers();
        RayCastForInteractionsInfo();
    }
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
        */
    }
    void RayCastForTriggers()
    {
        //Debug.LogError("OBSOLETE, CHANGE ME");
        /*
        Vector3 lookDir = data.cam.GetForwardDir();
        RaycastHit hitInfo;
        if (Physics.Raycast(data.cam.transform.position, lookDir, out hitInfo, infoRaycastDistance, rayCastTriggerLayer) == true)
        {
            hitInfo.collider.gameObject.GetComponent<SimpleTrigger>().TriggerInteraction();
        }
        */
    }
    void RayCastForInteractionsInfo()
    {
        Vector3 lookDir = data.cam.GetForwardDir();
        RaycastHit hitInfo;
        if (Physics.Raycast(data.cam.transform.position, lookDir, out hitInfo, infoRaycastDistance, interactLayer) == true)
        {
            InteractionHolder textInfo = hitInfo.collider.gameObject.GetComponent<InteractionHolder>();
            data.ui.ShowPossibleInteractions(textInfo);
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
}
