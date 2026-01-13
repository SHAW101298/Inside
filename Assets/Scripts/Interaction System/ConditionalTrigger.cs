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

    public void TRIGGER_IncreaseConditionValue()
    {
        numberCondition++;

        if(numberCondition >= requiredValue)
        {
            TriggerInteraction();
        }
    }
    public void TRIGGER_SetValue(int x)
    {
        numberCondition = x;

        if (numberCondition >= requiredValue)
        {
            TriggerInteraction();
        }
    }

}
