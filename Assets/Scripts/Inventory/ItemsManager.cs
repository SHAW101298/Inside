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

    }
    
}
