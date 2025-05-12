using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crow_SoundPlayer : MonoBehaviour
{
    public AudioSource source;
    public List<AudioClip> clips;

    public float minTimeDelay;
    public float maxTimeDelay;

    public float pitchVariation;
    float timer;
    float timeDelay;



    // Start is called before the first frame update
    void Start()
    {
        //timer = Random.Range(minTimeDelay, maxTimeDelay);
        timeDelay = Random.Range(minTimeDelay, maxTimeDelay);
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= timeDelay)
        {
            int randClip = Random.Range(0, clips.Count);
            float randPitch = Random.Range(-pitchVariation, pitchVariation);
            source.pitch = 1 + randPitch;
            source.PlayOneShot(clips[randClip]);
            
            timer = 0;
            timeDelay = Random.Range(minTimeDelay, maxTimeDelay);
        }
    }

    public void Interact_PlayRandomCaw()
    {
        int randClip = Random.Range(0, clips.Count);
        float randPitch = Random.Range(-pitchVariation, pitchVariation);
        source.pitch = 1 + randPitch;
        source.PlayOneShot(clips[randClip]);
    }
    public void Interact_PlaySpecificCaw(int x)
    {
        source.PlayOneShot(clips[x]);
    }
}
