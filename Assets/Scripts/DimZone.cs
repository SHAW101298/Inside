using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DimZone : MonoBehaviour
{
    //[SerializeField] AudioSource backgroundAudioSource;
    [SerializeField] AudioSourceController backgroundAudioController;

    [SerializeField] float desiredFogAmount;
    [SerializeField] float normalFogAmount;

    [SerializeField] float timeAmount;
    float timer;
    bool dim;
    bool shine;
    bool destroyOnExit;

    public UnityEvent EVENT_DimmingFinished;
    public UnityEvent EVENT_ShiningFinished;

    void Start()
    {
        normalFogAmount = RenderSettings.fogEndDistance;
    }


    void Update()
    {
        Dimming();
        Shining();
    }
    void Dimming()
    {
        if (dim == false)
            return;

        timer += Time.deltaTime;
        float percent = timer / timeAmount;
        float fogDist = Mathf.Lerp(normalFogAmount, desiredFogAmount, percent);
        RenderSettings.fogEndDistance = fogDist;
        backgroundAudioController.ChangeDesiredVolume(Mathf.Lerp(1f, 0, percent));
        //backgroundAudioSource.volume = Mathf.Lerp(0.5f, 0, percent);

        if (timer >= timeAmount)
        {
            dim = false;
            timer = timeAmount;
            RenderSettings.fogEndDistance = desiredFogAmount;
            //backgroundAudioSource.volume = 0;
            backgroundAudioController.ChangeDesiredVolume(0);
            EVENT_DimmingFinished.Invoke();
        }
    }
    void Shining()
    {
        if (shine == false)
            return;

        timer -= Time.deltaTime;
        float percent = timer / timeAmount;
        float fogDist = Mathf.Lerp(normalFogAmount, desiredFogAmount, percent);
        RenderSettings.fogEndDistance = fogDist;
        //backgroundAudioSource.volume = Mathf.Lerp(0.5f, 0, percent);
        backgroundAudioController.ChangeDesiredVolume(Mathf.Lerp(1, 0, percent));

        if (timer <= 0)
        {
            shine = false;
            timer = 0;
            RenderSettings.fogEndDistance = normalFogAmount;
            //backgroundAudioSource.volume = 0.5f;
            backgroundAudioController.ChangeDesiredVolume(1);
            EVENT_ShiningFinished.Invoke();
        }
    }

    public void MakeItShine()
    {
        shine = true;
        dim = false;
    }
    public void MakeItDim()
    {
        shine = false;
        dim = true;
    }

    public void ScheduleDestructionOnShined()
    {
        destroyOnExit = true;
    }

    public void CheckIfDestroy()
    {
        if(destroyOnExit == true)
        {
            Destroy(gameObject);
        }
    }
    public void SetDesiredFogDistance(float dist)
    {
        desiredFogAmount = dist;
    }

}
