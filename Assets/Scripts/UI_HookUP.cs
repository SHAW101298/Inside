using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_HookUP : MonoBehaviour
{
    #region // INSTANCE CREATION
    public static UI_HookUP Instance;
    private void Awake()
    {
        Instance = this;
    }
#endregion

    public Text infoTextField;
    public GameObject infoWindow;

}
