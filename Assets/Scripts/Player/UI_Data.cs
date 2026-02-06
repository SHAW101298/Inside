using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;

public class UI_Data : MonoBehaviour
{
    public int intValue;
    public float floatValue;
    public string stringValue;
    public TMP_Text textField;
    public Image image;

    public void SetTextField(string txt)
    {
        textField.text = txt;
    }

    public void DATA_TeleportPosition()
    {
        Debug.Log("DATA TELEPORT POSITION");
        DEV_TeleportTool.Instance.TeleportTo(intValue);
    }
    public void DIALOG_ChooseOption()
    {
        Debug.Log("Button Pressed on Option " + intValue);
        DialogManager.Instance.ChooseDialogOption(intValue);
    }
    public void INVENTORY_ClickOnItem()
    {
        Debug.Log("Clicked on Item in Inventory");
        PlayerData.instance.inventory.ClickedOnItem(intValue);
    }
}
