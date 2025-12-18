using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionalTrigger : TriggerBase
{
    [Space(20)]
    public int numberCondition;
    public int requiredValue;
    public override ENUM_TriggerTypes GetTriggerType()
    {
        return ENUM_TriggerTypes.conditional;
    }

    public override void TriggerInteraction()
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
    }

    public void IncreaseConditionValue()
    {
        numberCondition++;

        if(numberCondition >= requiredValue)
        {
            TriggerInteraction();
        }
    }

}
