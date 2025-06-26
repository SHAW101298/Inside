using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UI_Data : MonoBehaviour
{
    public int intValue;
    public float floatValue;
    public string stringValue;
    public Text textField;

    public void SetTextField(string txt)
    {
        textField.text = txt;
    }

    public void DATA_TeleportPosition()
    {
        Debug.Log("DATA TELEPORT POSITION");
        DEV_TeleportTool.Instance.TeleportTo(intValue);
    }
}
