using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public int id;
    public string itemName;
    public string description;
    public int iconID;
    public bool isOwned;

    public void ACTION_MarkAsOwned()
    {
        isOwned = true;
    }
    public void ACTION_MarkAsNotOwned()
    {
        isOwned = false;
    }
}
