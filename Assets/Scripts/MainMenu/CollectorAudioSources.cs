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

    }
}
