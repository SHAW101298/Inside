using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnterTrigger : MonoBehaviour
{
    [Header("EVENTS")]
    public UnityEvent enterEvent;
    public UnityEvent exitEvent;
    public UnityEvent delayedEnterEvent;
    public UnityEvent delayedExitEvent;
    [Header("Data")]
    [SerializeField] bool destroyTriggerOnActivation;
    [SerializeField] float delayedEventTriggerTime;
    [SerializeField] GameObject objectToEnable;
    [SerializeField] List<GameObject> objectsGroup1;
    [SerializeField] List<GameObject> objectsGroup2;

    float enterTimer;
    float exitTimer;
    bool startEnterTimer;
    bool startExitTimer;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            enterEvent.Invoke();

            if (destroyTriggerOnActivation == true)
            {
                Destroy(gameObject);
            }

            startEnterTimer = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            exitEvent.Invoke();

            startExitTimer = true;
        }
    }

    private void Update()
    {
        if (startEnterTimer == true)
        {
            enterTimer += Time.deltaTime;
            if (enterTimer >= delayedEventTriggerTime)
            {
                startEnterTimer = false;
                enterTimer = 0;
                delayedEnterEvent.Invoke();
            }
        }
        if (startExitTimer == true)
        {
            exitTimer += Time.deltaTime;
            if (exitTimer >= delayedEventTriggerTime)
            {
                startExitTimer = false;
                exitTimer = 0;
                delayedExitEvent.Invoke();
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
}
