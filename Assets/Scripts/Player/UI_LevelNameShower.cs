using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_LevelNameShower : MonoBehaviour
{
    [SerializeField] TMP_Text nameField;
    [SerializeField] string levelName;
    [SerializeField] float initialWaitTime;
    [SerializeField] float showTime;
    [SerializeField] float waitTime;
    [SerializeField] float fadeTime;
    [SerializeField] float timer;
    [SerializeField] bool initialWait;
    [SerializeField] bool show;
    [SerializeField] bool wait;
    [SerializeField] bool fade;
    // Start is called before the first frame update
    void Start()
    {
        initialWait = true;
    }

    // Update is called once per frame
    void Update()
    {
        InitialWait();
        Showing();
        Waiting();
        Fading();
    }

    void Showing()
    {
        if (show == true)
        {
            timer += Time.deltaTime;

            nameField.alpha = timer / showTime;

            if (timer >= showTime)
            {
                timer = 0;
                show = false;
                wait = true;
            }
        }
    }
    void InitialWait()
    {
        if (initialWait == true)
        {
            timer += Time.deltaTime;

            if (timer >= initialWaitTime)
            {
                timer = 0;
                initialWait = false;
                show = true;
            }
        }
    }
    void Waiting()
    {
        if (wait == true)
        {
            timer += Time.deltaTime;

            if (timer >= waitTime)
            {
                wait = false;
                fade = true;
                timer = fadeTime;
            }
        }
    }
    void Fading()
    {
        if (fade == true)
        {
            timer -= Time.deltaTime;

            nameField.alpha = timer / fadeTime;

            if (timer <= 0)
            {
                timer = 0;
                fade = false;
            }
        }
    }
}
