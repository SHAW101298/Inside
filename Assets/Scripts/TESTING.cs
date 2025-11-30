using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TESTING : MonoBehaviour
{
    public bool runAOO;
    public bool runBOO;
    public bool runCOO;
    public bool runDOO;
    [Header("Game Progression")]
    public SimpleTrigger missingPiece;
    public SimpleTrigger waitingAltar;
    public SimpleTrigger fakeDoor;
    public SimpleTrigger knifeGiving;
    public GameObject firstMeetingInteraction;
    public GameObject secondMeetingInteraction;
    [Space(15)]
    public bool triggerPickingMissingPiece;
    public bool triggerPlacingMissingPiece;
    public bool triggerOpeningFakeDoor;
    public bool setAmountOfTalkedCrows;
    public bool triggerTakingKnife;
    public bool triggerKilledACrow;
    public bool disableLoreDrop;
    [Header("AOO")]
    public Transform mainSphere;
    public Transform secondSphere;
    public Transform destinationSphere;
    public Vector3 currentDestination;
    public Vector3 rotationSpeed;
    public float movementSpeed;
    public float currentDistance;
    [Header("BOO")]
    public List<GameObject> bones;
    public int lastBone;
    [Header("COO")]
    public float tValue;
    public float yResult;
    [Header("DOO")]
    public string[] mainarray;
    public string[] array1;
    public string[] array2;
    public int array1RequiredSpace;
    public int array2RequiredSpace;

    void Update()
    {
        GameProgression();
        AOO();
        BOO();
        COO();
        DOO();
    }
    void AOO()
    {
        if(runAOO == true)
        {
            mainSphere.localEulerAngles += rotationSpeed * Time.deltaTime;
            currentDistance = Vector3.Distance(secondSphere.position, currentDestination);
            destinationSphere.position = currentDestination;
            if(currentDistance <= 5)
            {
                currentDestination.x = Random.Range(-25, 25);
                currentDestination.z = Random.Range(-25, 25);
            }
            secondSphere.position = Vector3.MoveTowards(secondSphere.position, currentDestination, movementSpeed);
        }
    }
    void BOO()
    {
        if(runBOO == true)
        {
            runBOO = false;
            bones[lastBone].transform.localScale = Vector3.zero;
            lastBone++;
        }
    }
    void COO()
    {
        if (runCOO == false)
            return;
        yResult = tValue*(-tValue + 4);
    }
    void DOO()
    {
        if(runDOO == false)
        {
            return;
        }
        runDOO = false;

        Debug.Log("array1 length = " + array1.Length);
        Debug.Log("array2 length = " + array2.Length);

        int reqSize = array1RequiredSpace + array2RequiredSpace;
        mainarray = new string[reqSize];

        for(int i = 0; i < array1RequiredSpace; i++)
        {
            mainarray[i] = array1[i];
        }
        for (int i = 0; i < array2RequiredSpace; i++)
        {
            mainarray[i + array1RequiredSpace] = array2[i];
        }

        
    }

    void GameProgression()
    {
        if(triggerPickingMissingPiece == true)
        {
            triggerPickingMissingPiece = false;
            missingPiece.TriggerInteraction();
        }
        if(triggerPlacingMissingPiece == true)
        {
            triggerPlacingMissingPiece = false;
            waitingAltar.TriggerInteraction();
        }     
        if(triggerOpeningFakeDoor == true)
        {
            triggerOpeningFakeDoor = false;
            fakeDoor.TriggerInteraction();
        }
        if (setAmountOfTalkedCrows == true)
        {
            setAmountOfTalkedCrows = false;
            LevelScript_02.Instance.TalkedWithInsultingCrow();
            LevelScript_02.Instance.TalkedWithInsultingCrow();
            LevelScript_02.Instance.TalkedWithInsultingCrow();
        }
        if (triggerTakingKnife == true)
        {
            triggerTakingKnife = false;
            knifeGiving.TriggerInteraction();
        }
        if(disableLoreDrop == true)
        {
            disableLoreDrop = false;
            firstMeetingInteraction.gameObject.SetActive(false);
            secondMeetingInteraction.gameObject.SetActive(true);
        }
        if(triggerKilledACrow == true)
        {
            triggerKilledACrow = false;
            LevelScript_02.Instance.KilledACrow();
        }
    }
}
