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

    /* Spiral Down
    Some island, but with a cave entrance which will have a spiraling down road.
    At the end of the road there will be exit out of bottom. At the exit what can be placed  ?

    Or maybe spiral up. Meaning to go out of the loop.
     */

    /* Loneliness
    A single tree among the trees ?
    A Single tree among the bushes ?
    A single Bush among the trees ?

    How to portray loneliness. Not being understood ?
    Paths. Signs. Spread out everywhere. Pointing in directions that no longer exist ? Or something else, i dont know.
    Signs reading " The heart, the pain, the road, the way, the mind, the pain etc. ??
    */

    /* Being able to summon the second guessing mind at will with a button?
    If something is here, it will tell something. If not, just standing, or sitting ?
    */

    [SerializeField] int hiddenObjectsFound;
    [SerializeField] int hiddenObjectsThrown;
    public UnityEvent EVENT_HiddenObjectsThrown;
    [SerializeField] Interaction ThrowDaggersInteraction;
    [Header("Island 5")]
    [SerializeField] Transform[] desiredIslandsPositions;
    [SerializeField] Transform[] lerpSTARTObjects;
    [SerializeField] GameObject[] islandsMiniatures;
    [SerializeField] SimpleTrigger[] islandCorrectPlacementTriggers;
    [SerializeField] float autoMoveDistance;
    [Header("Island 6")]
    [SerializeField] GameObject stairsObject;
    [SerializeField] LayerMask terrainLayer;


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
    public void WellObjectThrown()
    {
        hiddenObjectsThrown++;
        if(hiddenObjectsThrown >= 4)
        {
            EVENT_HiddenObjectsThrown.Invoke();
        }
    }
    public void EnableDaggersThrowInteraction()
    {
        if (ItemsManager.Instance.CheckIfItemIsOwned(0) == true)
        {
            Debug.Log("Enabling interaction");
            ThrowDaggersInteraction.Action_EnableInteraction();
        }
    }

    public void ReleasedIsland(int x)
    {
        //Debug.Log("Released Island");
        float dist = Vector3.Distance(islandsMiniatures[x].transform.position, desiredIslandsPositions[x].position);
        if(dist <= autoMoveDistance)
        {
            //Debug.Log("Distance is Enough");
            lerpSTARTObjects[x].position = islandsMiniatures[x].transform.position;
            islandCorrectPlacementTriggers[x].TriggerInteraction();
        }
    }
    public void TeleportOnStairs()
    {
        Vector3 localpos;
        Vector3 globalpos;
        RaycastHit hit;
        
        if(Physics.Raycast(PlayerData.instance.gameObject.transform.position, Vector3.down, out hit, 5, terrainLayer))
        {
            Debug.Log("WE HIT SOMETHING = " + hit.collider.gameObject.name);
            localpos = hit.collider.gameObject.transform.InverseTransformPoint(hit.point);
            globalpos = stairsObject.transform.TransformPoint(localpos);
            PlayerData.instance.TeleportToPosition(globalpos);
        }
        else
        {
            Debug.Log("NO HIT");
        }
        
        

    }
}
