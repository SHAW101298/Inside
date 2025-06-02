using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractTrigger : MonoBehaviour
{
    public UnityEvent interactEvent;
    public UnityEvent delayedInteractEvent;
    [Space(10)]
    [SerializeField] bool runTriggerOnStart;
    [SerializeField] bool destroyTriggerOnActivation;
    [SerializeField] bool disableTriggerOnActivation;
    [SerializeField] float delayInteractTriggerTime;
    [SerializeField] List<GameObject> objectsGroup1;
    [SerializeField] List<GameObject> objectsGroup2;

    float timer;
    bool startTimer;

    public void Interact()
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

    public void TriggerInteraction()
    {
        Interact();
    }
    public void TriggerDestruction()
    {
        Destroy(gameObject);
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
    public void DestroyGroup1()
    {
        foreach (GameObject obj in objectsGroup1)
        {
            Destroy(obj);
        }
        objectsGroup1.Clear();
    }
    public void DestroyGroup2()
    {
        foreach (GameObject obj in objectsGroup2)
        {
            Destroy(obj);
        }
        objectsGroup2.Clear();
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
        objectsGroup1[rand].GetComponentInChildren<InteractTrigger>().TriggerInteraction();
    }
}
