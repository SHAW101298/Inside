using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SimpleTrigger : TriggerBase
{
    [Header("SPECIFIC")]
    [SerializeField] float delayInteractTriggerTime;
    public UnityEvent delayedInteractEvent;
    [Space(10)]
    [SerializeField] bool runTriggerOnStart;


    float timer;
    bool startTimer;



    void Interact()
    {
        interactEvent.Invoke();

        if(destroyTriggerOnActivation == true)
        {
            Destroy(gameObject);
        }
        if(disableTriggerOnActivation == true)
        {
            gameObject.SetActive(false);
        }


        startTimer = true;
    }
    private void Start()
    {
        if(runTriggerOnStart == true)
        {
            Interact();
        }
    }
    private void Update()
    {
        if(debugTriggerInteraction == true)
        {
            Debug.Log("Interaction Triggered be Debug");
            debugTriggerInteraction = false;
            TriggerInteraction();
        }

        if(startTimer == true)
        {
            timer += Time.deltaTime;
            if(timer >= delayInteractTriggerTime)
            {
                startTimer = false;
                timer = 0;
                delayedInteractEvent.Invoke();
            }
        }
    }

    public override void TriggerInteraction()
    {
        Interact();
    }


    public void TeleportGroup1ToGroup2()
    {
        foreach(GameObject obj in objectsGroup1)
        {
            obj.transform.position = objectsGroup2[0].transform.position;
        }
    }
    public void EnableRandomObjectInGroup1()
    {
        int rand = Random.Range(0, objectsGroup1.Count);
        objectsGroup1[rand].SetActive(true);
    }
    public void EnableRandomObjectInGroup2()
    {
        int rand = Random.Range(0, objectsGroup2.Count);
        objectsGroup2[rand].SetActive(true);
    }
    public void CheckValidityOfLists()
    {
        for(int i = objectsGroup1.Count - 1; i >= 0; i--)
        {
            if (objectsGroup1[i] == null)
            {
                objectsGroup1.RemoveAt(i);
            }
        }
        for (int i = objectsGroup2.Count - 1; i >= 0; i--)
        {
            if (objectsGroup2[i] == null)
            {
                objectsGroup2.RemoveAt(i);
            }
        }
    }
    public void InteractWithRandomTriggerInGroup1()
    {
        int rand = Random.Range(0, objectsGroup1.Count);
        objectsGroup1[rand].GetComponentInChildren<SimpleTrigger>().TriggerInteraction();
    }
    public override ENUM_TriggerTypes GetTriggerType()
    {
        return ENUM_TriggerTypes.simple;
    }
}
