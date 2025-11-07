using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LookTrigger : TriggerBase
{
    
    [Header("SPECIFIC")]
    [SerializeField] float delayInteractTriggerTime;
    public UnityEvent delayedInteractEvent;
    float timer;
    bool startTimer;
    public override void TriggerInteraction()
    {
        Interact();
    }
    public override ENUM_TriggerTypes GetTriggerType()
    {
        return ENUM_TriggerTypes.look;
    }

    void Interact()
    {
        interactEvent.Invoke();

        if (destroyTriggerOnActivation == true)
        {
            Destroy(gameObject);
        }
        if (disableTriggerOnActivation == true)
        {
            gameObject.SetActive(false);
        }


        startTimer = true;
    }
}
