using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crow_Data : MonoBehaviour
{
    public Crow_AnimationPlayer animationPlayer;
    public Crow_SoundPlayer soundPlayer;

    public void TriggerDestruction()
    {
        Destroy(gameObject);
    }
}
