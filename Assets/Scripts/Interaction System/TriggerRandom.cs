using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerRandom : MonoBehaviour
{
    public UnityEvent interactEvent;
    public UnityEvent finishEvent;
    [Space(10)]
    [SerializeField] float activationChance;
    [SerializeField] float maxPossibleActivations;
    float currentActivations;
    [SerializeField] bool destroyTriggerOnActivation;
    [SerializeField] bool disableTriggerOnActivation;

    [Space(10)]
    [SerializeField] List<GameObject> objectsGroup1;
    [SerializeField] List<GameObject> objectsGroup2;

    [SerializeField] bool debugTriggerInteraction;

    public void TriggerInteraction()
    {
        float rand = Random.Range(0, 100);
        if(rand <= activationChance)
        {
            Interact();
        }
    }

    private void Update()
    {
        if (debugTriggerInteraction == true)
        {
            Debug.Log("Interaction Triggered be Debug");
            debugTriggerInteraction = false;
            TriggerInteraction();
        }
    }
    void Interact()
    {
        interactEvent.Invoke();

        currentActivations++;

        if (disableTriggerOnActivation == true)
        {
            gameObject.SetActive(false);
        }

        if (currentActivations >= maxPossibleActivations)
        {
            if (destroyTriggerOnActivation == true)
            {
                Destroy(gameObject);
            }
        }

        
    }

    public void EnableGroup1()
    {
        if (objectsGroup1.Count > 0)
        {
            foreach (GameObject obj in objectsGroup1)
            {
                obj.SetActive(true);
            }
        }
    }
    public void EnableGroup2()
    {
        if (objectsGroup2.Count > 0)
        {
            foreach (GameObject obj in objectsGroup2)
            {
                obj.SetActive(true);
            }
        }
    }
    public void DisableGroup1()
    {
        if (objectsGroup1.Count > 0)
        {
            foreach (GameObject obj in objectsGroup1)
            {
                obj.SetActive(false);
            }
        }
    }
    public void DisableGroup2()
    {
        if (objectsGroup2.Count > 0)
        {
            foreach (GameObject obj in objectsGroup2)
            {
                obj.SetActive(false);
            }
        }
    }

}
