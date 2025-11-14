using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationOffsetInitializator : MonoBehaviour
{
    [SerializeField] Animator anim;
    [SerializeField] float offsetMinValue;
    [SerializeField] float offsetMaxValue;
    [SerializeField] float speedMinValue;
    [SerializeField] float speedMaxValue;

    private void Start()
    {
        RandomizeOffsetValue();
        RandomizeSpeedValue();
    }
    void RandomizeOffsetValue()
    {
        float randVal = Random.Range(offsetMinValue, offsetMaxValue);
        anim.SetFloat("AnimOffset", randVal);
    }
    void RandomizeSpeedValue()
    {
        float randVal = Random.Range(speedMinValue, speedMaxValue);
        anim.speed = randVal;
    }
}
