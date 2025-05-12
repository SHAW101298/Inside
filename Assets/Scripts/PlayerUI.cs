using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    [SerializeField] GameObject infoWindow;
    [SerializeField] Text infoText;
    bool windowIsActive;
    [SerializeField] float showTimer;
    float timer;

    private void Start()
    {
        SetReferences();
    }
    public void ShowText(string text)
    {
        //Debug.Log("SHOW INFO");
        infoWindow.SetActive(true);
        infoText.text = text;
        timer = 0;
        windowIsActive = true;
    }
    public void HideText()
    {
        infoWindow.SetActive(false);
        windowIsActive = false;
    }

    private void Update()
    {
        WindowTimer();
    }

    void WindowTimer()
    {
        if (windowIsActive == false)
            return;
        

        timer += Time.deltaTime;
        if (timer >= showTimer)
        {
            HideText();
        }
    }

    public void SetReferences()
    {
        infoWindow = UI_HookUP.Instance.infoWindow;
        infoText = UI_HookUP.Instance.infoTextField;
        Cursor.visible = false;
    }
}
