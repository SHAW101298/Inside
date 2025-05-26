using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crow_AnimationPlayer : MonoBehaviour
{
    [SerializeField] Animator anim;

    [SerializeField] float delayBetweenRandomness;
    float timerRandomness;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        IdleRandomness();
    }
    void IdleRandomness()
    {
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
    public void MarkAsFlying()
    {
        anim.SetBool("Flying", true);
    }
    public void MarkAsIdle()
    {
        anim.SetBool("Flying", false);
    }
}
