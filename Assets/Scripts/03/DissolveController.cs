using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.Events;

public class DissolveController : MonoBehaviour
{
    [SerializeField] Material mat;
    [SerializeField] string valueToBeChanged;
    [SerializeField] float changeTime;
    [Description("How much should the beggining of timer be offset, to flow correctly with dissolve amount")]
    [SerializeField] float valueOffset;

    [Header("Values")]
    [SerializeField] float startValue;
    [SerializeField] float endValue;
    float lerpVal;

    float endVal;
    float beginVal;
    float timer;
    float currentValue;
    bool decrease;
    bool increase;

    public UnityEvent EVENT_Materialized;
    public UnityEvent EVENT_Dissolved;

    // Start is called before the first frame update
    void Start()
    {
        endVal = 1 - valueOffset;
        beginVal = valueOffset;

        currentValue = endVal;
        timer = endVal * changeTime;
    }

    // Update is called once per frame
    void Update()
    {
        Increasing();
        Decreasing();
    }
    public void StartDissolving()
    {
        decrease = false;
        increase = true;
    }
    public void StartMaterializing()
    {
        increase = false;
        decrease = true;
    }


    // Dissolving
    void Increasing()
    {
        /*
        if(increase == true)
        {
            timer += Time.deltaTime;
            currentValue = timer / changeTime;
            
            if(currentValue >= endVal)
            {
                currentValue = endVal;
                timer = endVal * changeTime;
                increase = false;
                EVENT_Dissolved.Invoke();
            }
            mat.SetFloat(valueToBeChanged, currentValue);
        }
        */
        if(increase == true)
        {
            timer += Time.deltaTime;
            currentValue = timer / changeTime;
            
            if(currentValue >= changeTime)
            {
                lerpVal = Mathf.Lerp(startValue, endValue, currentValue);
                currentValue = 1;
                timer = changeTime;
                increase = false;
                EVENT_Dissolved.Invoke();
            }
            mat.SetFloat(valueToBeChanged, lerpVal);
        }
    }
    // Materializing
    void Decreasing()
    {
        /*
        if (decrease == true)
        {
            timer -= Time.deltaTime;
            currentValue = timer / changeTime;

            if (currentValue <= 0)
            {
                currentValue = 0;
                timer = 0;
                decrease = false;
                EVENT_Materialized.Invoke();
            }
            mat.SetFloat(valueToBeChanged, currentValue);
        }
        */
        if (decrease == true)
        {
            timer += Time.deltaTime;
            currentValue = timer / changeTime;

            if (currentValue <= 0)
            {
                lerpVal = Mathf.Lerp(startValue, endValue, currentValue);
                currentValue = 0;
                timer = 0;
                decrease = false;
                EVENT_Materialized.Invoke();
            }
            mat.SetFloat(valueToBeChanged, lerpVal);
        }
    }

    public void ACTION_ForceDissolved_NOEVENT()
    {
        currentValue = endVal;
        timer = endVal * 2;
        mat.SetFloat(valueToBeChanged, currentValue);
    }
    public void ACTION_ForceMaterialized_NOEVENT()
    {
        currentValue = 0;
        timer = 0;
        mat.SetFloat(valueToBeChanged, currentValue);
    }
    public void ACTION_ForceDissolved_WITHEVENT()
    {
        currentValue = endVal;
        timer = endVal * 2;
        mat.SetFloat(valueToBeChanged, currentValue);
        EVENT_Dissolved.Invoke();
    }
    public void ACTION_ForceMaterialized_WITHEVENT()
    {
        currentValue = 0;
        timer = 0;
        mat.SetFloat(valueToBeChanged, currentValue);
        EVENT_Materialized.Invoke();
    }
}
