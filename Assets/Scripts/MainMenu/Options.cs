using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Options : MonoBehaviour
{
    public static Options Instance;
    private void Awake()
    {
        if(Instance != this && Instance != null)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
    }
    [SerializeField] float musicVolume;
    [SerializeField] float soundVolume;

    public void ChangeVolumes(float music, float sound)
    {
        musicVolume = music;
        soundVolume = sound;
        CollectorAudioSources.Instance.ChangeVolumeLevel();
    }
    public void ChangeMusicVolume(float music)
    {
        musicVolume = music;
        CollectorAudioSources.Instance.ChangeVolumeLevel();
    }
    public void ChangeSoundVolume(float sound)
    {
        soundVolume = sound;
        CollectorAudioSources.Instance.ChangeVolumeLevel();
    }
    public float GetMusicVolume()
    {
        return musicVolume;
    }
    public float GetSoundVolume()
    {
        return soundVolume;
    }
}
