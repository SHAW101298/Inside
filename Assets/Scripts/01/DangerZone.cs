using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerZone : MonoBehaviour
{
    [SerializeField] FlameVisibility flame;

    [SerializeField] Transform startPosition;
    [SerializeField] Transform endPosition;
    [SerializeField] bool isActive;
    [SerializeField] List<AudioSource> whisperSources;
    [SerializeField] float maxTimeDifference;
    [SerializeField] float minTimeDifference;
    [SerializeField] float timeDifference;
    [SerializeField] float timer;
    [SerializeField] bool startTimer;
    [SerializeField] int lastIndex;

    private void Update()
    {
        if(isActive == true)
        {
            foreach(AudioSource source in whisperSources)
            {
                source.volume = flame.dangerLevel;
            }
        }
        SetRandomStartTimers();
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            ActivateDangerZone();
        }
    }
    public void ActivateDangerZone()
    {
        flame.SetAsCurrentDanger(startPosition.position, endPosition.position);
        isActive = true;
        startTimer = true;
        timer = 0;
        timeDifference = Random.Range(minTimeDifference, maxTimeDifference);
        lastIndex = 0;
    }
    public void DisableDangerZone()
    {
        isActive = false;
        startTimer = false;
        timer = 0;
        lastIndex = 0;
    }

    void SetRandomStartTimers()
    {
        if (startTimer == true)
        {
            timer += Time.deltaTime;
            if(timer >= timeDifference)
            {
                timer -= timeDifference;
                timeDifference = Random.Range(minTimeDifference, maxTimeDifference);
                whisperSources[lastIndex].gameObject.SetActive(true);
                lastIndex++;
                if(lastIndex >= whisperSources.Count)
                {
                    startTimer = false;
                    timer = 0;
                }
            }
        }
    }
}
