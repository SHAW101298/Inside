using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crow_SoundPlayer : MonoBehaviour
{
    public AudioSource source;

    float timer;
    public float minTimeDelay;
    public float maxTimeDelay;
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
            source.Play();
            
            timer = 0;
            timeDelay = Random.Range(minTimeDelay, maxTimeDelay);
        }
    }
}
