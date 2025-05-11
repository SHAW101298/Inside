using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroSceneScript : MonoBehaviour
{
    [Header("References")]
    public GameObject player;
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
    



    // Start is called before the first frame update
    void Start()
    {
        
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
            }
        }
    }

    public void PlayerLeftArea()
    {
        player.transform.position = spawnPoint.transform.position;
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
        flameInteract.SetActive(false);
        levelBlockade.SetActive(false);
        flameLight.intensity = flameIntensity;
        flameLight.range = flameRange;
        flameMovement.StartMovement();
    }
    public void InteractWithLadder()
    {
        // Screen Fade
        // Change Scene
        //
    }
}
