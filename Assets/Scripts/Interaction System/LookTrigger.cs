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
        throw new System.NotImplementedException();
    }

}
