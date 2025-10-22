using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crow_Data : MonoBehaviour
{
    public Crow_AnimationPlayer animationPlayer;
    public Crow_SoundPlayer soundPlayer;
    public AudioSourceController sourceController;
    public GameObject killTriggerParent;
    public GameObject killTrigger;
    public Interaction killInteraction;

    public void TriggerDestruction()
    {
        sourceController.RemoveMe();
        Destroy(gameObject);
    }
    public void KillCrow()
    {
        sourceController.RemoveMe();
        LevelScript_02.Instance.KilledACrow();
        Destroy(gameObject);
    }
    public void EnableKillTrigger()
    {
        killTrigger.SetActive(true);
    }
    public void EnableKillParent()
    {
        killTriggerParent.SetActive(true);
    }
    public void EnableKillInteractions()
    {
        killInteraction.Action_EnableInteraction();
    }
}
