using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CollectorAudioSources : MonoBehaviour
{
    #region
    public static CollectorAudioSources Instance;
    private void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
#endregion

    [SerializeField] List<AudioSource> soundAudioSources;
    [SerializeField] List<AudioSource> musicAudioSources;
    [SerializeField] List<AudioSourceController> soundControllers;
    [SerializeField] List<AudioSourceController> musicControllers;
   
    public void ChangeVolumeLevel()
    {
        float newSoundVolume = Options.Instance.GetSoundVolume();
        float newMusicVolume = Options.Instance.GetMusicVolume();

        for(int i = 0; i < soundAudioSources.Count; i++)
        {
            if (soundAudioSources[i] == null)
            {
                continue;
            }

            soundAudioSources[i].volume = newSoundVolume;
        }

        for (int i = 0; i < musicAudioSources.Count; i++)
        {
            if (musicAudioSources[i] == null)
            {
                continue;
            }

            musicAudioSources[i].volume = newMusicVolume;
        }

        for (int i = 0; i < soundControllers.Count; i++)
        {
            if (soundControllers[i] == null)
            {
                continue;
            }
            soundControllers[i].ChangeVolume();
        }
        for (int i = 0; i < musicControllers.Count; i++)
        {
            if (musicControllers[i] == null)
            {
                continue;
            }
            musicControllers[i].ChangeVolume();
        }
    }
    public void AddSoundController(AudioSourceController source)
    {
        soundControllers.Add(source);
    }
    public void AddMusicController(AudioSourceController source)
    {
        musicControllers.Add(source);
    }
    public void RemoveSoundController(AudioSourceController source)
    {
        soundControllers.Remove(source);
    }
    public void RemoveMusicController(AudioSourceController source)
    {
        musicControllers.Remove(source);
    }
}
