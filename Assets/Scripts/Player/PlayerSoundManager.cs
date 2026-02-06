using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSoundManager : MonoBehaviour
{
    public AudioSource source;
    public List<AudioClip> audioClips;
    public float pitchVariation;

    public void ANIM_PlayWalkSound()
    {
        source.Play();
        float rand = Random.Range(-pitchVariation, pitchVariation);
        source.pitch = 1 + rand;
        source.PlayOneShot(audioClips[0]);
    }
    public void ANIM_PlayRunSound()
    {
        float rand = Random.Range(-pitchVariation, pitchVariation);
        source.pitch = 1 + rand;
        source.PlayOneShot(audioClips[1]);
    }
}
