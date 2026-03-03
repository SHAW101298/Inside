using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum ENUM_ButtonKey
{
    E,
    F,
    LMB
}
[RequireComponent(typeof(InformationHolder))]
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
    [SerializeField] GameObject uiTipObject;
    [Header("DEBUG")]
    [SerializeField] bool debug_Interact;
    [SerializeField] bool debug_EnableInteraction;
    [SerializeField] bool debug_DisableInteraction;

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
        if (uiTipObject != null)
        {
            Destroy(uiTipObject);
        }
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
        InteractionHolder tempHOlder = GetComponentInParent<InteractionHolder>();
        tempHOlder.DisableInteraction(this);
        DisableUITipObject();
    }
    public void Action_EnableInteraction()
    {
        //Debug.Log("Action Enable Interaction");
        GetComponentInParent<InteractionHolder>().EnableInteraction(this);
        EnableUITipObject();
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
    private void Update()
    {
        HandleEditorDebug();
    }
    void HandleEditorDebug()
    {
        if(debug_Interact == true)
        {
            debug_Interact = false;
            Debug.Log("DEBUG  || Interacted by editor debug");
            Action_ActivateTrigger();
        }
        if (debug_EnableInteraction == true)
        {
            debug_EnableInteraction = false;
            Debug.Log("DEBUG  || Enabled Interaction by editor debug");
            Action_EnableInteraction();
        }
        if (debug_DisableInteraction == true)
        {
            debug_DisableInteraction = false;
            Debug.Log("DEBUG  || Disabled Interaction by editor debug");
            Action_DisableInteraction();
        }
    }
    public void DestroyUITipObject()
    {
        if (uiTipObject != null)
        {
            Destroy(uiTipObject);
        }
    }
    public void DisableUITipObject()
    {
        if (uiTipObject != null)
        {
            uiTipObject.SetActive(false);
        }
    }
    public void EnableUITipObject()
    {
        if (uiTipObject != null)
        {
            uiTipObject.SetActive(true);
        }
    }
}
