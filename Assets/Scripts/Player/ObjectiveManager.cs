using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public enum ENUM_ObjectiveShowState
{
    appear,
    show,
    disappear,
    wait
}

public class ObjectiveManager : MonoBehaviour
{
    #region
    public static ObjectiveManager Instance;
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
    #endregion

    [SerializeField] TMP_Text textField;
    [SerializeField] float showTime;
    [SerializeField] float appearTime;
    [SerializeField] float disappearTime;
    ENUM_ObjectiveShowState state;
    float timer;

    public void Show(string text)
    {
        textField.text = text;
        state = ENUM_ObjectiveShowState.appear;
        timer = 0;
    }
    // Update is called once per frame
    void Update()
    {
        Appear();
        Show();
        Disappear();
    }
    void Appear()
    {
        if (state != ENUM_ObjectiveShowState.appear)
            return;

        timer += Time.deltaTime;
        textField.alpha = timer / appearTime;

        if(timer >= appearTime)
        {
            timer = 0;
            state = ENUM_ObjectiveShowState.show;
        }
    }
    void Show()
    {
        if (state != ENUM_ObjectiveShowState.show)
            return;

        timer += Time.deltaTime;
        if (timer >= showTime)
        {
            timer = 0;
            state = ENUM_ObjectiveShowState.disappear;
        }
    }
    void Disappear()
    {
        if (state != ENUM_ObjectiveShowState.disappear)
            return;

        timer += Time.deltaTime;
        textField.alpha = 1 - (timer / appearTime);
        if (timer >= disappearTime)
        {
            timer = 0;
            state = ENUM_ObjectiveShowState.wait;
            textField.text = "";
        }
    }
}
