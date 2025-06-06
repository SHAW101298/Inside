using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelScript_02 : MonoBehaviour
{
    public static LevelScript_02 Instance;
    [Header("References")]
    [SerializeField] GameObject missingPiece;
    [SerializeField] GameObject emptySpot;
    [SerializeField] GameObject emptySpotReadyForPiece;
    [SerializeField] GameObject filledSpot;
    [SerializeField] AudioSource musicAudioSource;
    [SerializeField] FlyingBirdsController flyingBirdsController;
    [Header("After placing Missing Piece")]
    [SerializeField] List<GameObject> objectsBeforePlacingPiece;
    [SerializeField] List<GameObject> objectsAfterPlacingPiece;
    [SerializeField] Animator doorAnimator;
    [SerializeField] GameObject SecondInteractionTrigger;
    [Header("Character Slow Change")]
    [SerializeField] GameObject knifeAllowingInteraction;
    [SerializeField] Animator characterAnim;
    [SerializeField] int insultCrowsTalkedTo;
    [SerializeField] SkinnedMeshRenderer characterMeshRenderer;
    [SerializeField] Material transparentMaterial;
    [SerializeField] float currentAlpha;
    [SerializeField] List<GameObject> bodyBones;
    [SerializeField] List<GameObject> crowKillInteractions;
    [SerializeField] int lastBone;
    [Header("Past Self killed Crow Interactions")]
    [SerializeField] GameObject oneKilledCrow;
    [SerializeField] GameObject threeKilledCrows;
    [SerializeField] InteractTrigger crowLocalizationTrigger;
    [SerializeField] GameObject allCrowsKilledInteraction;
    [SerializeField] InteractTrigger doorCloseInteraction;
    [SerializeField] RepeatedSoundController knockingSound;
    [SerializeField] DimZone templeDimZone;

    [Header("Checkers")]
    public bool foundMissingPiece;
    public bool placedMissingPiece;

    private void Awake()
    {
        Instance = this;
    }
    public void FoundMissingPiece()
    {
        missingPiece.SetActive(false);
        foundMissingPiece = true;
        emptySpotReadyForPiece.SetActive(true);
        emptySpot.SetActive(false);
        //characterMeshRenderer.material = transparentMaterial;
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

    public void ModifyCharacterTransparency(float amount)
    {
        currentAlpha -= amount;
        Color color = transparentMaterial.color;
        color.a = currentAlpha;
        transparentMaterial.color = color;
    }
    public void TalkedWithInsultingCrow()
    {
        insultCrowsTalkedTo++;

        if(insultCrowsTalkedTo >= 3)
        {
            if(knifeAllowingInteraction != null)
            {
                knifeAllowingInteraction.SetActive(true);
            }
            SecondInteractionTrigger.SetActive(false);
        }
    }
    public void KilledACrow()
    {
        bodyBones[lastBone].transform.localScale = Vector3.zero;
        lastBone++;
        if(lastBone == 1)
        {
            oneKilledCrow.SetActive(true);
            //DialogManager.Instance.ShowText(98);
            
        }
        if(lastBone == 3)
        {
            oneKilledCrow.SetActive(false);
            threeKilledCrows.SetActive(true);

        }
        if(lastBone == 7)
        {
            characterAnim.SetTrigger("NoLegs");
        }
        crowLocalizationTrigger.CheckValidityOfLists();

        if(lastBone == 13)
        {
            allCrowsKilledInteraction.SetActive(true);
            crowLocalizationTrigger.TriggerDestruction();
            musicAudioSource.gameObject.SetActive(false);
            doorCloseInteraction.TriggerInteraction();
            templeDimZone.SetDesiredFogDistance(15);
        }
    }
    public void EnableCrowKillInteractions()
    {
        foreach(GameObject obj in crowKillInteractions)
        {
            if(obj != null)
            {
                obj.SetActive(true);
            }
        }
        flyingBirdsController.SetAmountOfDesiredBirds(0);
    }
    public void ChangeSceneToNextLevel()
    {
        SceneManager.LoadScene(3);
    }
}