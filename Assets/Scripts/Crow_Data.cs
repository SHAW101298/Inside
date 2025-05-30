using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crow_Data : MonoBehaviour
{
    public Crow_AnimationPlayer animationPlayer;
    public Crow_SoundPlayer soundPlayer;
    public GameObject killTriggerParent;
    public GameObject killTrigger;

    public void TriggerDestruction()
    {
        LevelScript_02.Instance.KilledACrow();
        Destroy(gameObject);
    }
    public void KillCrow()
    {
        LevelScript_02.
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
}
