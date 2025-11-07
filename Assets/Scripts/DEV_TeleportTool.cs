using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DEV_TeleportTool : MonoBehaviour
{
    #region
    public static DEV_TeleportTool Instance;
    private void Awake()
    {
        Instance = this;
        CreateWindowData();
    }

    #endregion
    public GameObject teleportWindow;
    public List<GameObject> teleportPositions;
    public GameObject UIPrefab;
    public GameObject content;
    

    public void CreateWindowData()
    {
        GameObject temp;
        UI_Data ui_Data;
        for(int i = 0; i < teleportPositions.Count; i++)
        {
            temp = Instantiate(UIPrefab);
            temp.transform.SetParent(content.transform);
            ui_Data = temp.GetComponent<UI_Data>();
            ui_Data.intValue = i;
            ui_Data.SetTextField(teleportPositions[i].name);
        }
    }
    public void ActionDEVWindow(InputAction.CallbackContext context)
    {
        if (teleportWindow.activeSelf == true)
        {
            HideWindow();
        }
        else
        {
            ShowWindow();
        }
    }

    public void ShowWindow()
    {
        teleportWindow.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
    }
    public void HideWindow()
    {
        teleportWindow.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void TeleportTo(int x)
    {
        //PlayerData.instance.gameObject.transform.position = teleportPositions[x].transform.position;
        PlayerData.instance.TeleportToPosition(teleportPositions[x].transform.position);
        HideWindow();
    }

    
}
