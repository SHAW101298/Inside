using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveController : MonoBehaviour
{
    [SerializeField] Material mat;
    [SerializeField] string valueToBeChanged;
    [SerializeField] float changeTime;
    float timer;
    float currentValue;
    [SerializeField] bool decrease;
    [SerializeField] bool increase;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Increasing();
        Decreasing();
    }
    public void StartIncreasing()
    {
        decrease = false;
        increase = true;
        timer = 0;
    }
    public void StartDecreasing()
    {
        increase = false;
        decrease = true;
        timer = 0;
    }


    void Increasing()
    {
        if(increase == true)
        {
            timer += Time.deltaTime;
            currentValue = timer / changeTime;
            
            if(currentValue >= 1)
            {
                currentValue = 1;
                timer = 0;
                increase = false;
            }
            mat.SetFloat(valueToBeChanged, currentValue);
        }
    }
    void Decreasing()
    {
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
    }
}
