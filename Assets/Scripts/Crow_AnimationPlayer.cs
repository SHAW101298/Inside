using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Crow_AnimationPlayer : MonoBehaviour
{
    [SerializeField] Crow_Data data;
    [SerializeField] Animator anim;
    [SerializeField] bool startStuckInTheAir;
    [SerializeField] bool playRandomIdleAnimation;
    [SerializeField] float delayBetweenRandomness;
    float timerRandomness;

    public UnityEvent FinishedTakeOff;
    public UnityEvent FinishedLanding;

    private void Start()
    {
        if (startStuckInTheAir == true)
        {
            TriggerTakeOff();
        }

    }

    // Update is called once per frame
    void Update()
    {
        IdleRandomness();
    }
    void IdleRandomness()
    {
        if(playRandomIdleAnimation == false)
        {
            return;
        }

        timerRandomness += Time.deltaTime;
        if(timerRandomness >= delayBetweenRandomness)
        {
            timerRandomness = 0;
            int randInt = Random.Range(0, 2);
            float rand = randInt;
            anim.SetFloat("IdleBlend", rand);
            anim.SetTrigger("IdleRandom");
        }
    }
    public void TriggerTakeOff()
    {
        anim.SetTrigger("TakeOff");
    }
    public void TriggerLanding()
    {
        anim.SetTrigger("Land");
    }
    public void MarkAsFlying()
    {
        anim.SetBool("Flying", true);
    }
    public void MarkAsIdle()
    {
        anim.SetBool("Flying", false);
    }
    public void TriggerIdleRandom()
    {
        timerRandomness = 0;
        int randInt = Random.Range(0, 2);
        float rand = randInt;
        anim.SetFloat("IdleBlend", rand);
        anim.SetTrigger("IdleRandom");
    }
    public void TriggerIdleRandom(float blend)
    {
        timerRandomness = 0;
        anim.SetFloat("IdleBlend", blend);
        anim.SetTrigger("IdleRandom");
    }

    public void ANIM_FinishedTakeOff()
    {
        FinishedTakeOff.Invoke();
    }
    public void ANIM_FinishedLanding()
    {
        FinishedLanding.Invoke();
    }
}
