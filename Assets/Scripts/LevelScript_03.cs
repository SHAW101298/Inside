using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class LevelScript_03 : MonoBehaviour
{

    /*
    Player is falling down, a light keeping company
    Player is searching for himself
    Amidst all the silence and emptiness
    With only an occasional piano and violin notes in the background
    Introduce player dialog options
    Bench at spawn area, where past self will be sitting once player moves away
    Road falling apart at some point after player moves forward
    At start road made from floating blocks which the player repairs. Blocks can be activated and moved around, acting slightly spongy ? 
    Possible acts of kindness or hurt on the way. Player chooses what to do
    Small figure pushing against a boulder. Player can ignore this, crush the figure with a boulder, take away the boulder and then it can be placed in a expected position
    or taken away leaving the figure with no purpose


    Who am i ?
    What's this place ?
    What's going on ?


    Memory Well
    Rock Pushing
    
    Flower field with a door
    Stars slowly being added to the night sky as the player progresses further
    Normal Terrain but with a clear cut borders
    terrain filled with trees and vegetation. Everything is grey though

    nice road should be near the end
    A bridge to cross. The curvy japan like 

    */
    /*Memory Well
    Apparently, whatever you drop there disappears. Never to be seen again.
     Objects to find
    Ribbon - promise
    Watch - time
    Hammer - tools / ways 
    SnowGlobe - joy

    */

    [SerializeField] int hiddenObjectsFound;
    public UnityEvent EVENT_HiddenObjectFound;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void KillRockPushing()
    {

    }
    public void ChangeSceneToNextLevel()
    {
        SceneManager.LoadScene(4);
    }
    public void RestartScene()
    {
        SceneManager.LoadScene(3);
    }
    public void WellObjectFound()
    {
        hiddenObjectsFound++;

        if(hiddenObjectsFound >= 4)
        {

        }
    }
}
