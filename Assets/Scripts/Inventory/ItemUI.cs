using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemUI : MonoBehaviour
{
    int itemID;
    string itemName;
    string itemDescription;
    [SerializeField] TMP_Text itemNameField;

    public void GenerateItem(int id, string name, string description)
    {
        itemID = id;
        itemName = name;
        itemDescription = description;
    }

}
