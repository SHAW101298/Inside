using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelScript_02 : MonoBehaviour
{
    [Header("References")]
    [SerializeField] GameObject missingPiece;
    [SerializeField] GameObject emptySpot;
    [SerializeField] GameObject emptySpotReadyForPiece;
    [SerializeField] GameObject filledSpot;

    [SerializeField] GameObject roadCrowsBefore;
    [SerializeField] GameObject roadCrowsAfter;
    [SerializeField] AudioSource musicAudioSource;
    [Header("After placing Missing Piece")]
    [SerializeField] List<GameObject> objectsBeforePlacingPiece;
    [SerializeField] List<GameObject> objectsAfterPlacingPiece;

    [Header("Checkers")]
    [SerializeField] float fogAmountOnRoad;
    [SerializeField] float fogAmountNormal;
    [SerializeField] Animator doorAnimator;

    public bool foundMissingPiece;
    public bool placedMissingPiece;
    public bool roadTimerFade;
    public bool roadTimerShine;
    public float roadTimer;
    public float roadTimerAmount;

    public void FoundMissingPiece()
    {
        missingPiece.SetActive(false);
        foundMissingPiece = true;
        emptySpotReadyForPiece.SetActive(true);
        emptySpot.SetActive(false);
        RenderSettings.fogEndDistance = fogAmountNormal;

        roadCrowsBefore.SetActive(false);
        roadCrowsAfter.SetActive(true);
    }

    public void PlacedMissingPiece()
    {
        placedMissingPiece = true;
        emptySpotReadyForPiece.SetActive(false);
        filledSpot.SetActive(true);

        foreach(GameObject obj in objectsBeforePlacingPiece)
        {
            obj.SetActive(false);
        }
        foreach(GameObject obj in objectsAfterPlacingPiece)
        {
            obj.SetActive(true);
        }
        //DialogManager.Instance.ShowText(98);
    }
    public void OpenDoorFirstTime()
    {
        doorAnimator.SetTrigger("Open");
    }

    public void EnterTheRoad()
    {
        Debug.Log("Enter The road");
        roadTimerFade = true;
        roadTimerShine = false;
    }
    public void ExitTheRoad()
    {
        Debug.Log("Exit The road");
        roadTimerShine = true;
        roadTimerFade = false;
    }

    private void Update()
    {
        if(roadTimerFade == true)
        {
            roadTimer += Time.deltaTime;
            float percent = roadTimer / roadTimerAmount;
            float fogDist = Mathf.Lerp(fogAmountNormal, fogAmountOnRoad, percent);
            RenderSettings.fogEndDistance = fogDist;
            musicAudioSource.volume = Mathf.Lerp(0.5f, 0, percent);

            if(roadTimer >= roadTimerAmount)
            {
                roadTimerFade = false;
                roadTimer = roadTimerAmount;
                RenderSettings.fogEndDistance = fogAmountOnRoad;
                musicAudioSource.volume = 0;
            }
        }

        if(roadTimerShine == true)
        {
            roadTimer -= Time.deltaTime;
            float percent = roadTimer / roadTimerAmount;
            float fogDist = Mathf.Lerp(fogAmountNormal, fogAmountOnRoad, percent);
            RenderSettings.fogEndDistance = fogDist;
            musicAudioSource.volume = Mathf.Lerp(0.5f, 0, percent);

            if (roadTimer <= 0)
            {
                roadTimerShine = false;
                roadTimer = 0;
                RenderSettings.fogEndDistance = fogAmountNormal;
                musicAudioSource.volume = 0.5f;
            }
        }
    }
}
