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
        if(increase == true)
        {
            timer += Time.deltaTime;
            currentValue = timer / changeTime;
            
            if(currentValue >= endVal)
            {
                currentValue = endVal;
                timer = endVal * 2;
                increase = false;
                EVENT_Dissolved.Invoke();
            }
            mat.SetFloat(valueToBeChanged, currentValue);
        }
    }
    // Materializing
    void Decreasing()
    {
        /*
        if(decrease == true)
        {
            timer += Time.deltaTime;
            currentValue = 1 - timer / changeTime;

            if (currentValue <= 0)
            {
                currentValue = 0;
                timer = 0;
                decrease = false;
            }
            mat.SetFloat(valueToBeChanged, currentValue);
        }
        */
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
    }
}
