using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ENUM_ScreenShakeDecreaseType
{
    stable,
    percentage,
    square
}

public class SuddenScreenShake : MonoBehaviour
{
    [SerializeField] Transform objectToShake;
    [SerializeField] float StartAmount;
    [SerializeField] float decraseAmount;
    [SerializeField] ENUM_ScreenShakeDecreaseType shakeType;
    [SerializeField] bool isActive;
    [Header("Debug")]
    [SerializeField] float curAmount;
    [SerializeField] float rotX;
    [SerializeField] float rotY;

    // Update is called once per frame
    void Update()
    {
        if(isActive == true)
        {
            switch (shakeType)
            {
                case ENUM_ScreenShakeDecreaseType.stable:
                    ShakeStable();
                    break;
                case ENUM_ScreenShakeDecreaseType.percentage:
                    ShakePercentage();
                    break;
                case ENUM_ScreenShakeDecreaseType.square:
                    ShakeSquare();
                    break;
                default:
                    break;
            }
        }
    }
    public void Activate()
    {
        curAmount = StartAmount;
        
    }
    void ShakeStable()
    {
        Vector3 newrot = new Vector3();
        newrot.x = curAmount;
        newrot.y = curAmount;



        // Get Absoulute Value
        if (curAmount < 0)
        {
            curAmount += decraseAmount;
        }
        else
        {
            curAmount -= decraseAmount;
        }

        curAmount = -curAmount;

        objectToShake.localEulerAngles = newrot;
    }
    void ShakePercentage()
    {
        Vector3 newrot = new Vector3();
        newrot.x = curAmount;
        newrot.y = curAmount;

        curAmount *= decraseAmount;

        curAmount = -curAmount;
        objectToShake.localEulerAngles = newrot;
    }
    void ShakeSquare()
    {
        Vector3 newrot = new Vector3();
        newrot.x = curAmount;
        newrot.y = curAmount;

        curAmount = Mathf.Sqrt(curAmount);

        curAmount = -curAmount;
        objectToShake.localEulerAngles = newrot;
    }
}
