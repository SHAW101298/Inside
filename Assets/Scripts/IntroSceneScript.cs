using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroSceneScript : MonoBehaviour
{
    [Header("Dialog Prompts")]
    [SerializeField] DialogPrompt questionPrompt;
    [SerializeField] DialogPrompt emptyPrompt;



    // Start is called before the first frame update
    void Start()
    {
        //DialogManager.Instance.ShowText(emptyPrompt);
        //DialogManager.Instance.ShowText(questionPrompt);
    }


    public void InteractWithLadder()
    {
        ScreenFadeEffect.Instance.FadeScreen();
        // Screen Fade
        // Change Scene
        //
    }
    public void ChangeSceneToNextLevel()
    {
        SceneManager.LoadScene(2);
    }
}
