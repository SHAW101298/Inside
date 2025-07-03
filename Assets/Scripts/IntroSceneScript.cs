using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroSceneScript : MonoBehaviour
{
    [Header("References")]
    public PlayerData player;
    public GameObject spawnPoint;
    public GameObject flame;
    public GameObject flameInfo;
    public GameObject flameInteract;
    public GameObject levelBlockade;
    public Light flameLight;
    public FlameMovement flameMovement;

    [Header("knocking")]
    public bool doKnocking;
    public float timeBetweenKnocks;
    public float knockTimer;
    public AudioSource knockingAudioSource;

    [Header("Flame Brighness Values")]
    public float flameIntensity;
    public float flameRange;

    [Header("Dialog Prompts")]
    [SerializeField] DialogPrompt questionPrompt;
    [SerializeField] DialogPrompt emptyPrompt;



    // Start is called before the first frame update
    void Start()
    {
        DialogManager.Instance.ShowText(emptyPrompt);
        DialogManager.Instance.ShowText(questionPrompt);
    }

    // Update is called once per frame
    void Update()
    {
        if(doKnocking == true)
        {
            knockTimer += Time.deltaTime;
            if(knockTimer >= timeBetweenKnocks)
            {
                knockTimer -= timeBetweenKnocks;
                knockingAudioSource.Play();
                //DialogManager.Instance.ShowText(28);
            }
        }
    }

    public void PlayerLeftArea()
    {
        Debug.Log("PLayer left Area");
        player.gameObject.SetActive(false);
        player.transform.position = spawnPoint.transform.position;
        player.gameObject.SetActive(true);
    }
    public void PlayerGotCloserToKnockSource()
    {
        doKnocking = false;
        flame.SetActive(true);
    }

    public void InteractWithFlame()
    {
        Debug.Log("Interact with Flame");
        flameInfo.SetActive(false);
        //flameInteract.SetActive(false);
        levelBlockade.SetActive(false);
        flameLight.intensity = flameIntensity;
        flameLight.range = flameRange;
        //flameMovement.StartMovement();
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
