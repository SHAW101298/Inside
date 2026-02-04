using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.Events;

public class MaterialPropertyController : MonoBehaviour
{
    [Header("Material Data")]
    [SerializeField] Material mat;
    [SerializeField] string valueToBeChanged;
    
    [Header("Values")]
    [SerializeField] float changeTime;
    float timer;
    [SerializeField] float startValue;
    [SerializeField] float endValue;
    float lerpVal;
    float currentValue;
    bool decrease;
    bool increase;

    public UnityEvent EVENT_Materialized;
    public UnityEvent EVENT_Dissolved;

    public void StartIncreasing()
    {
        decrease = false;
        increase = true;
    }
    public void StartDecreasing()
    {
        increase = false;
        decrease = true;
    }


    private void Update()
    {
        Increasing();
        Decreasing();
    }
    void Increasing()
    {
        if (increase == true)
        {
            timer += Time.deltaTime;
            currentValue = timer / changeTime;
            lerpVal = Mathf.Lerp(startValue, endValue, currentValue);

            if (timer >= changeTime)
            {
                currentValue = 1;
                timer = changeTime;
                increase = false;
                lerpVal = Mathf.Lerp(startValue, endValue, currentValue);
                EVENT_Dissolved.Invoke();
            }
            mat.SetFloat(valueToBeChanged, lerpVal);
        }
    }
    // Materializing
    void Decreasing()
    {
        if (decrease == true)
        {
            timer -= Time.deltaTime;
            currentValue = timer / changeTime;
            lerpVal = Mathf.Lerp(startValue, endValue, currentValue);

            if (timer <= 0)
            {
                currentValue = 0;
                timer = 0;
                decrease = false;
                lerpVal = Mathf.Lerp(startValue, endValue, currentValue); 
                EVENT_Materialized.Invoke();
            }
            mat.SetFloat(valueToBeChanged, lerpVal);
        }
    }

    public void ACTION_ForceDecreased_NOEVENT()
    {
        timer = 0;
        currentValue = startValue;
        mat.SetFloat(valueToBeChanged, startValue);
        increase = false;
        decrease = false;
    }
    public void ACTION_ForceIncreased_NOEVENT()
    {
        timer = changeTime;
        currentValue = endValue;
        mat.SetFloat(valueToBeChanged, endValue);
        increase = false;
        decrease = false;
    }
    public void ACTION_ForceDecreased_WITHEVENT()
    {
        timer = 0;
        currentValue = startValue;
        mat.SetFloat(valueToBeChanged, startValue);
        EVENT_Dissolved.Invoke();
        increase = false;
        decrease = false;
    }
    public void ACTION_ForceIncreased_WITHEVENT()
    {
        timer = changeTime;
        currentValue = endValue;
        mat.SetFloat(valueToBeChanged, endValue);
        EVENT_Materialized.Invoke();
        increase = false;
        decrease = false;
    }
}
