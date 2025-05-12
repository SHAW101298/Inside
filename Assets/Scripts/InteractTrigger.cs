using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractTrigger : MonoBehaviour
{
    public UnityEvent interactEvent;
    [Space(10)]
    [SerializeField] GameObject objectToDestroy;
    [SerializeField] bool destroyObjectOnActivation;
    [SerializeField] bool destroyTriggerOnActivation;
    [SerializeField] float destroyDelay;

    float timer;
    bool startTimer;
    public void Interact()
    {
        interactEvent.Invoke();

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
                    Destroy(objectToDestroy);
                }

                if (destroyTriggerOnActivation == true)
                {
                    Destroy(this);
                }
            }
        }
    }
}
