using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ScreenFadeEffect : MonoBehaviour
{
    [SerializeField] Image fadeScreen;
    [SerializeField] Color fadeColor;
    [SerializeField] float fadeTime;
    float timer;
    [SerializeField] bool fade;
    [SerializeField] bool unfade;

    public UnityEvent screenFaded;
    public UnityEvent screenUnfaded;

    // Start is called before the first frame update
    void Start()
    {
        timer = fadeTime;
        unfade = true;
        fadeScreen.color = fadeColor;
    }

    // Update is called once per frame
    void Update()
    {
        if(fade == true)
        {
            timer += Time.deltaTime;
            fadeColor.a = timer/fadeTime;
            fadeScreen.color = fadeColor;

            if (fadeColor.a >= 1)
            {
                fade = false;
                screenFaded.Invoke();
            }
        }
        if(unfade == true)
        {
            timer -= Time.deltaTime;
            fadeColor.a = timer / fadeTime;
            fadeScreen.color = fadeColor;

            if(fadeColor.a <= 0)
            {
                unfade = false;
                screenUnfaded.Invoke();
            }
        }
    }
}
