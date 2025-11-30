using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class ItemsManager : MonoBehaviour
{
    #region
    public static ItemsManager Instance;
    private void Awake()
    {
        Instance = this;
    }
#endregion

    public List<Item> items;

    private void Start()
    {
        RequestSync();
    }
    public void RequestSync()
    {
        ItemsData.Instance.SyncPersistentData();
    }

    public void AddItem(int id)
    {
        items[id].isOwned = true;
    }
    public void RemoveItem(int id)
    {
        items[id].isOwned = false;
    }

    public bool CheckIfItemIsOwned(int id)
    {
        return items[id].isOwned;
    }
}
