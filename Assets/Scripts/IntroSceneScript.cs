using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// Masks always being rotated towards the player ?

public class IntroSceneScript : MonoBehaviour
{
    [SerializeField] float playSoundDistance;
    [SerializeField] AudioClip[] soundClips;
    [SerializeField] GameObject soundPlayerPrefab;
    public void InteractWithLadder()
    {
        //ScreenFadeEffect.Instance.FadeScreen();
        // Screen Fade
        // Change Scene
        //
    }
    public void ChangeSceneToNextLevel()
    {
        SceneManager.LoadScene(2);
    }

    public void PlayChainsSound()
    {
        PrepareSoundPlayer(0);
    }
    public void PlayMaskSound()
    {
        PrepareSoundPlayer(1);
    }
    public void PlayThudSound()
    {
        PrepareSoundPlayer(2);
    }

    void PrepareSoundPlayer(int soundIndex)
    {
        Vector3 pos = PlayerData.instance.transform.position;
        Vector3 forwardDir = PlayerData.instance.cam.GetForwardDir().normalized;
        forwardDir *= playSoundDistance;
        pos -= forwardDir;

        GameObject soundPlayer = Instantiate(soundPlayerPrefab);
        soundPlayer.transform.position = pos;

        AudioSource audioSource = soundPlayer.GetComponent<AudioSource>();
        audioSource.clip = soundClips[soundIndex];
        audioSource.Play();
    }
}
