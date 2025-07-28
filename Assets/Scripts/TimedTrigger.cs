using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TimedTrigger : MonoBehaviour
{
    public UnityEvent interactEvent;
    public UnityEvent finishEvent;
    [Space(10)]
    [SerializeField] bool runTriggerOnStart;
    [SerializeField] bool destroyTriggerOnActivation;
    [SerializeField] bool disableTriggerOnActivation;
    [Space(10)]
    [SerializeField] float timeBetweenActivations;
    [SerializeField] float timer;
    [SerializeField] int maxActivationTimes;
    [SerializeField] int activationTimes;
    [Space(10)]
    [SerializeField] List<GameObject> objectsGroup1;
    [SerializeField] List<GameObject> objectsGroup2;

    [SerializeField] bool debugTriggerInteraction;
    // Start is called before the first frame update
    void Start()
    {
        if (runTriggerOnStart == true)
        {
            TriggerInteraction();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (debugTriggerInteraction == true)
        {
            Debug.Log("Interaction Triggered be Debug");
            debugTriggerInteraction = false;
            TriggerInteraction();
        }

        timer += Time.deltaTime;
        if(timer >= timeBetweenActivations)
        {
            TriggerInteraction();
            timer -= timeBetweenActivations;
        }
    }

    public void TriggerInteraction()
    {
        Interact();
        if (maxActivationTimes == 0)
            return;

        activationTimes++;
        if(activationTimes >= maxActivationTimes)
        {
            finishEvent.Invoke();
        }
    }
    public void TriggerDestruction()
    {
        Destroy(gameObject);
    }
    public void StartTimer()
    {
        gameObject.SetActive(true);
    }
    void Interact()
    {
        interactEvent.Invoke();

        if (destroyTriggerOnActivation == true)
        {
            Destroy(gameObject);
        }
        if (disableTriggerOnActivation == true)
        {
            gameObject.SetActive(false);
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
    public void TeleportGroup1ToGroup2()
    {
        foreach (GameObject obj in objectsGroup1)
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
        for (int i = objectsGroup1.Count - 1; i >= 0; i--)
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
    public void MoveObjectsInGroup1ToGroup2Position()
    {
        Vector3 pos = Vector3.Lerp(objectsGroup1[0].transform.position, objectsGroup2[0].transform.position, 0.01f);
        foreach (GameObject obj in objectsGroup1)
        {
            obj.transform.position = pos;
        }

    }
    public void EnableFirstInGroup1()
    {
        if (objectsGroup1.Count == 0)
            return;
        objectsGroup1[0].SetActive(true);
    }
    public void EnableFirstInGroup2()
    {
        if (objectsGroup2.Count == 0)
            return;
        objectsGroup2[0].SetActive(true);
    }
    public void RemoveFirstInGroup1()
    {
        if (objectsGroup1.Count == 0)
            return;
        objectsGroup1.RemoveAt(0);
    }
    public void RemoveFirstInGroup2()
    {
        if (objectsGroup2.Count == 0)
            return;
        objectsGroup2.RemoveAt(0);
    }

}
