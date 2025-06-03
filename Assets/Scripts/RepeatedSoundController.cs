using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatedSoundController : MonoBehaviour
{
    [SerializeField] AudioSource source;

    [SerializeField] bool playSounds;
    [SerializeField] float delayBetweenSounds;
    float timer;

    // Update is called once per frame
    void Update()
    {
        if(playSounds == true)
        {
            timer += Time.deltaTime;
            if(timer >= delayBetweenSounds)
            {
                timer -= delayBetweenSounds;
                source.Play();
            }
        }
    }

    public void ForceSound()
    {
        source.Play();
        timer = 0;
    }
    public void TurnOn()
    {
        playSounds = true;
    }
    public void TurnOff()
    {
        playSounds = false;
    }
    public void TriggerDestruction()
    {
        Destroy(gameObject);
    }
}
