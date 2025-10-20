using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    // Holds Data about the Interaction
    [SerializeField] TriggerBase trigger;
    [SerializeField] InformationHolder info;

    public TriggerBase GetTriggerBase()
    {
        return trigger;
    }
    public InformationHolder GetInfoHolder()
    {
        return info;
    }
}
