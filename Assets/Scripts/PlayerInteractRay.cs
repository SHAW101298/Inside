using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteractRay : MonoBehaviour
{
    public PlayerData data;
    [SerializeField] LayerMask infoLayer;
    [SerializeField] LayerMask interactLayer;
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
            hitInfo.collider.gameObject.GetComponent<InteractTrigger>().TriggerInteraction();
        }

        
    }

    private void Update()
    {
        RayCastForInfo();
    }
    void RayCastForInfo()
    {
        Vector3 lookDir = data.cam.GetForwardDir();
        RaycastHit hitInfo;
        if(Physics.Raycast(data.cam.transform.position, lookDir, out hitInfo, infoRaycastDistance, infoLayer) == true)
        {
            string textInfo = hitInfo.collider.gameObject.GetComponent<InformationHolder>().GetInformation();
            data.ui.ShowText(textInfo);
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
