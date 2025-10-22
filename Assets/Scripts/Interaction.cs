using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    // Holds Data about the Interaction
    [SerializeField] TriggerBase trigger;
    [SerializeField] InformationHolder info;
    [SerializeField] bool isActive;
    [SerializeField] int defaultInteractionKey;

    public TriggerBase GetTriggerBase()
    {
        return trigger;
    }
    public InformationHolder GetInfoHolder()
    {
        return info;
    }
    public bool GetActiveState()
    {
        return isActive;
    }
    public void ChangeActiveState(bool newState)
    {
        isActive = newState;
    }
    public void Action_DeleteInteraction()
    {
        InteractionHolder holder = GetComponentInParent<InteractionHolder>();
        holder.RemoveInteraction(this);
    }
    public void Action_ActivateTrigger()
    {
        trigger.TriggerInteraction();
    }
    public void Action_DisableInteraction()
    {
        isActive = false;
        GetComponentInParent<InteractionHolder>().DisableInteraction(this);
    }
}
