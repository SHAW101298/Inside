using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TESTING : MonoBehaviour
{
    public bool runAOO;
    public bool runBOO;
    [Header("Game Progression")]
    public InteractTrigger missingPiece;
    public InteractTrigger waitingAltar;
    public InteractTrigger fakeDoor;
    public InteractTrigger knifeGiving;
    [Space(15)]
    public bool triggerPickingMissingPiece;
    public bool triggerPlacingMissingPiece;
    public bool triggerOpeningFakeDoor;
    public bool setAmountOfTalkedCrows;
    public bool triggerTakingKnife;
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


    void Update()
    {
        GameProgression();
        AOO();
        BOO();
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
    }
}
