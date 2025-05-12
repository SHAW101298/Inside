using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InformationHolder : MonoBehaviour
{
    [SerializeField] int index;

    public string GetInformation()
    {
        return LanguageManager.Instance.GetText(index);
    }
}
