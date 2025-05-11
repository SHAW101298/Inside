using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InformationHolder : MonoBehaviour
{
    [SerializeField] string text;

    public string GetInformation()
    {
        return text;
    }
}
