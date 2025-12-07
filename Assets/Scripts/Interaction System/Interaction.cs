using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum ENUM_ButtonKey
{
    E,
    F,
    LMB
}

public class Interaction : MonoBehaviour
{
    // Holds Data about the Interaction
    [SerializeField] ENUM_ButtonKey defaultInteractionButton;
    [Space(10)]
    [SerializeField] bool destroyObjectOnInteraction;
    [SerializeField] bool disableOnInteraction;
    [Space(10)]
    [SerializeField] TriggerBase trigger;
    [SerializeField] InformationHolder info;

    public TriggerBase GetTriggerBase()
    {
        return trigger;
    }
    public InformationHolder GetInfoHolder()
    {
        return info;
    }
    public void Action_DeleteInteraction()
    {
        InteractionHolder holder = GetComponentInParent<InteractionHolder>();
        holder.RemoveInteraction(this);
    }
    public void Action_ActivateTrigger()
    {
        trigger.TriggerInteraction();
        if (disableOnInteraction == true)
        {
            Action_DisableInteraction();
        }
        if (destroyObjectOnInteraction == true)
        {
            Action_DeleteInteraction();
            Destroy(gameObject);
        }
    }
    public void Action_DisableInteraction()
    {
        Debug.Log("Name is = " + gameObject.name);
        Debug.Log("Parent name is = " + gameObject.GetComponentInParent<Transform>().gameObject);
        InteractionHolder tempHOlder = GetComponentInParent<InteractionHolder>();
        Debug.Log("Check");
        Debug.Log(tempHOlder);
        Debug.Log(tempHOlder);
        Debug.Log("Check");
        Debug.Log("Check");
        
        Debug.Log("holder is = " + tempHOlder);
        GetComponentInParent<InteractionHolder>().DisableInteraction(this);
    }
    public void Action_EnableInteraction()
    {
        //Debug.Log("Action Enable Interaction");
        GetComponentInParent<InteractionHolder>().EnableInteraction(this);
    }
    public int GetDefaultInteractionKey()
    {
        int button = (int)defaultInteractionButton;
        return button;
        //return defaultInteractionKey;
    }
    public string DEBUG_DropInfo()
    {
        string text = ("DEF_Key = " + defaultInteractionButton + " || TriggerType = " + trigger.GetType());
        return text;
    }
}
