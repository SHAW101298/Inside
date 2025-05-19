using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractTrigger : MonoBehaviour
{
    public UnityEvent interactEvent;
    [Space(10)]
    [SerializeField] List<GameObject> objectsToDestroy;
    [SerializeField] bool destroyObjectOnActivation;
    [SerializeField] bool destroyTriggerOnActivation;
    [SerializeField] float destroyDelay;
    [SerializeField] GameObject objectToEnable;
    [SerializeField] GameObject objectToDisable;

    float timer;
    bool startTimer;
    public void Interact()
    {
        interactEvent.Invoke();

        if (objectToEnable != null)
        {
            objectToEnable.SetActive(true);
        }
        if(objectToDisable != null)
        {
            objectToDisable.SetActive(false);
        }

        startTimer = true;
    }

    private void Update()
    {
        if(startTimer == true)
        {
            timer += Time.deltaTime;
            if(timer >= destroyDelay)
            {
                startTimer = false;
                timer = 0;


                if (destroyObjectOnActivation == true)
                {
                    foreach (GameObject obj in objectsToDestroy)
                    {
                        Destroy(obj);
                    }
                }

                if (destroyTriggerOnActivation == true)
                {
                    Destroy(gameObject);
                }
            }
        }
    }

    public void TriggerDestruction()
    {
        foreach (GameObject obj in objectsToDestroy)
        {
            Destroy(obj);
        }
    }
}
