using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelScript_02 : MonoBehaviour
{
    #region
    public static LevelScript_02 Instance;
    private void Awake()
    {
        Instance = this;
    }
#endregion
    [Header("Phase 1")]
    [SerializeField] List<GameObject> objectsAfterPlacingSpark;
    [SerializeField] List<GameObject> objectsBeforePlacingSpark;
    [Header("Phase 2")]
    [SerializeField] int insultCrowsTalkedTo;
    [SerializeField] GameObject phase2Interaction;
    [SerializeField] GameObject knifeAllowingInteraction;
    [Header("Phase 3")]
    [SerializeField] Animator characterAnim;
    [SerializeField] List<GameObject> bodyBones;
    [SerializeField] int lastBone;
    [SerializeField] GameObject crowSearchParty;
    [SerializeField] SimpleTrigger crowLocalizationTrigger;
    [SerializeField] GameObject oneKilledCrow;
    [SerializeField] GameObject threeKilledCrows;
    [SerializeField] List<GameObject> crowKillInteractions;
    [SerializeField] List<Crow_Data> importantCrows;
    [Header("Phase 4")]
    [SerializeField] FlyingBirdsController flyingBirdsController;
    [SerializeField] DimZone templeDimZone;
    [SerializeField] AudioSource musicAudioSource;
    [SerializeField] GameObject allCrowsKilledInteraction;
    [SerializeField] SimpleTrigger doorCloseInteraction;
    [SerializeField] RepeatedSoundController knockingSound;

    public void PlacedASpark()
    {
        foreach(GameObject obj in objectsBeforePlacingSpark)
        {
            obj.SetActive(false);
        }
        foreach(GameObject obj in objectsAfterPlacingSpark)
        {
            obj.SetActive(true);
        }
    }
    public void TalkedWithInsultingCrow()
    {
        insultCrowsTalkedTo++;

        if (insultCrowsTalkedTo == 3)
        {
            phase2Interaction.SetActive(false);
            knifeAllowingInteraction.SetActive(true);
        }


            /*
            if (insultCrowsTalkedTo >= 3)
            {
                if (askedForAdvice2 == false)
                {

                    if (baseInteractionsPhase2 == null)
                        return;
                    if (phase2SkippedInteraction == null)
                        return;

                    phase2SkippedInteraction.SetActive(true);
                    baseInteractionsPhase2.SetActive(false);


                    if (phase1SkippedInteraction != null)
                    {
                        phase1SkippedInteraction.SetActive(false);
                    }
                }
                else
                {
                    baseInteractionsPhase2.SetActive(true);
                }
            }
            */
        }
    public void KilledACrow()
    {
        bodyBones[lastBone].transform.localScale = Vector3.zero;
        lastBone++;
        if (lastBone == 1)
        {
            oneKilledCrow.SetActive(true);
            crowSearchParty.SetActive(true);
            //DialogManager.Instance.ShowText(98);

        }
        if (lastBone == 3)
        {
            oneKilledCrow.SetActive(false);
            threeKilledCrows.SetActive(true);
            

        }
        if (lastBone == 7)
        {
            characterAnim.SetTrigger("NoLegs");
        }
        crowLocalizationTrigger.CheckValidityOfLists();
        ObjectiveManager.Instance.Show(lastBone.ToString() + "/" + "13");

        if (lastBone == 13)
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
        Debug.Log("Enable Kill Interactions");
        foreach(GameObject obj in crowKillInteractions)
        {
            if(obj != null)
            {
                obj.SetActive(true);
            }
        }
        flyingBirdsController.SetAmountOfDesiredBirds(0);
        foreach(Crow_Data crow in importantCrows)
        {
            crow.EnableKillInteractions();
        }
    }
    public void ChangeSceneToNextLevel()
    {
        SceneManager.LoadScene(3);
    }


}