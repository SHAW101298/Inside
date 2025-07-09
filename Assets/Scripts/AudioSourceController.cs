using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ENUM_AudioType
{
    music,
    sound
}
public class AudioSourceController : MonoBehaviour
{
    [SerializeField] ENUM_AudioType audioType;
    [SerializeField] AudioSource source;
    [SerializeField] float baseVolumeLevel = 1f;
    [SerializeField] float desiredVolumeLevel;
    [SerializeField] float calculatedVolumeLevel;

    void Start()
    {
        switch (audioType)
        {
            case ENUM_AudioType.music:
                CollectorAudioSources.Instance.AddMusicController(this);
                break;
            case ENUM_AudioType.sound:
                CollectorAudioSources.Instance.AddSoundController(this);
                break;
            default:
                CollectorAudioSources.Instance.AddSoundController(this);
                break;
        }
        ChangeVolume();
    }

    public void ChangeVolume()
    {
        float globalVolumeLevel;
        switch(audioType)
        {
            case ENUM_AudioType.music:
                globalVolumeLevel = Options.Instance.GetMusicVolume();
                break;
            case ENUM_AudioType.sound:
                globalVolumeLevel = Options.Instance.GetSoundVolume();
                break;
            default:
                globalVolumeLevel = Options.Instance.GetMusicVolume();
                break;
        }
        calculatedVolumeLevel = globalVolumeLevel * baseVolumeLevel * desiredVolumeLevel;
        source.volume = calculatedVolumeLevel;
    }
    public void ChangeDesiredVolume(float newDesiredLevel)
    {
        desiredVolumeLevel = newDesiredLevel;
        ChangeVolume();
    }
    public void RemoveMe()
    {
        switch (audioType)
        {
            case ENUM_AudioType.music:
                CollectorAudioSources.Instance.RemoveMusicController(this);
                break;
            case ENUM_AudioType.sound:
                CollectorAudioSources.Instance.RemoveSoundController(this);
                break;
            default:
                CollectorAudioSources.Instance.RemoveSoundController(this);
                break;
        }
    }
}
