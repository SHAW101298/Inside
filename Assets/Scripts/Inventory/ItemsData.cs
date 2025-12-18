using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsData : MonoBehaviour
{
    #region
    public static ItemsData Instance;
    private void Awake()
    {
        DontDestroyOnLoad(this);
        if (Instance != this && Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }
#endregion
    public List<Item> itemsAvailability;

    public void SyncPersistentData()
    {
        for(int i = 0; i < itemsAvailability.Count; i++)
        {
            ItemsManager.Instance.items[i].isOwned = itemsAvailability[i].isOwned;
        }
        /*
        for (int i = 0; i < notes.Count; i++)
        {
            for (int j = 0; j < notes[i].isRevealed.Count; j++)
            {
                if (notes[i].isRevealed[j] == true)
                {
                    NotesManager.Instance.RevealNoteData(i, j);
                }
            }
        }
        */
    }
    public void MarkItemAsOwned(int id)
    {
        itemsAvailability[id].ACTION_MarkAsOwned();
    }
    public void MarkItemAsNotOwned(int id)
    {
        itemsAvailability[id].ACTION_MarkAsNotOwned();
    }
}
