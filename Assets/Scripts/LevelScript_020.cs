using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelScript_020 : MonoBehaviour
{
    [Header("Phase 1")]
    [SerializeField] bool askedForDirections1;
    [SerializeField] GameObject baseInteractionsPhase1;
    [SerializeField] GameObject phase1SkippedInteraction;
    [Header("Phase 2")]
    [SerializeField] bool askedForAdvice2;
    [SerializeField] GameObject baseInteractionsPhase2;
    [SerializeField] GameObject phase2SkippedInteraction;
    [SerializeField] int insultCrowsTalkedTo;
    [SerializeField] GameObject knifeAllowingInteraction;
    [Header("Phase 3")]
    [SerializeField] Animator characterAnim;
    [SerializeField] List<GameObject> bodyBones;
    [SerializeField] int lastBone;
    [SerializeField] InteractTrigger crowLocalizationTrigger;
    [SerializeField] GameObject oneKilledCrow;
    [SerializeField] GameObject threeKilledCrows;
    [Header("Phase 4")]
    [SerializeField] DimZone templeDimZone;
    [SerializeField] AudioSource musicAudioSource;
    [SerializeField] GameObject allCrowsKilledInteraction;
    [SerializeField] InteractTrigger doorCloseInteraction;
    [SerializeField] RepeatedSoundController knockingSound;

    public void AskedForDirectionsToSpark()
    {
        askedForDirections1 = true;
    }
    public void PlacedASpark()
    {
        if(askedForDirections1 == false)
        {
            phase1SkippedInteraction.SetActive(true);
            baseInteractionsPhase1.SetActive(false);
        }
    }
    public void TalkedWithInsultingCrow()
    {
        insultCrowsTalkedTo++;
        phase1SkippedInteraction.SetActive(false);

        if (insultCrowsTalkedTo >= 3)
        {
            if(askedForAdvice2 == false)
            {
                phase2SkippedInteraction.SetActive(true);

                if (phase1SkippedInteraction != null)
                {
                    phase1SkippedInteraction.SetActive(false);
                }
            }

            if (knifeAllowingInteraction != null)
            {
                knifeAllowingInteraction.SetActive(true);
            }
            //SecondInteractionTrigger.SetActive(false);
        }
    }
    public void KilledACrow()
    {
        bodyBones[lastBone].transform.localScale = Vector3.zero;
        lastBone++;
        if (lastBone == 1)
        {
            oneKilledCrow.SetActive(true);
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

        if (lastBone == 13)
        {
            allCrowsKilledInteraction.SetActive(true);
            crowLocalizationTrigger.TriggerDestruction();
            musicAudioSource.gameObject.SetActive(false);
            doorCloseInteraction.TriggerInteraction();
            templeDimZone.SetDesiredFogDistance(15);
        }
    }
}

/* Possible Routes

Gracz omija na pocz¹tek past self
Tak¿e rozmowa musi uruchamiaæ mo¿liwoœæ nastêpnych rozmów !!!

Gdyby gracz znalaz³ missing piece zanim spyta o wskazówkê, nale¿y pomin¹æ t¹ interakcje oraz uruchomiæ inn¹
    You already made some progress on your own i see. Now you can hear them clearly, right ? ETC ETC
Gdyby gracz znalaz³ missing piece i pogada³ z krukami to jest nastêpna interakcja do uruchomienia
    Been busy, huh ? Going straight to the point. I can't complain though. And ? Did you learn anything of value ? ETC ETC



*/
