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

    private void Update()
    {
        if(isActive == true)
        {
            foreach(AudioSource source in whisperSources)
            {
                source.volume = flame.dangerLevel;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            flame.SetAsCurrentDanger(startPosition.position,endPosition.position);
        }
    }
}
