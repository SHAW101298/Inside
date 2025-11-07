using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerRandom : TriggerBase
{
    public UnityEvent finishEvent;
    [Space(10)]
    [SerializeField] float activationChance;
    [SerializeField] float maxPossibleActivations;
    float currentActivations;


    public override void TriggerInteraction()
    {
        float rand = Random.Range(0, 100);
        if(rand <= activationChance)
        {
            Interact();
        }
    }

    private void Update()
    {
        if (debugTriggerInteraction == true)
        {
            Debug.Log("Interaction Triggered be Debug");
            debugTriggerInteraction = false;
            TriggerInteraction();
        }
    }
    void Interact()
    {
        interactEvent.Invoke();

        currentActivations++;

        if (disableTriggerOnActivation == true)
        {
            gameObject.SetActive(false);
        }

        if (currentActivations >= maxPossibleActivations)
        {
            if (destroyTriggerOnActivation == true)
            {
                Destroy(gameObject);
            }
        }

        
    }
    public override ENUM_TriggerTypes GetTriggerType()
    {
        return ENUM_TriggerTypes.random;
    }
}
