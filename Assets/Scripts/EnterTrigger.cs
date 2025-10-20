using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnterTrigger : TriggerBase
{
    [Header("EVENTS")]
    public UnityEvent enterEvent;
    public UnityEvent exitEvent;
    public UnityEvent delayedEnterEvent;
    public UnityEvent delayedExitEvent;


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
            if (disableTriggerOnActivation == true)
            {
                gameObject.SetActive(false);
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
    
    public void TriggerEnter()
    {
        Debug.Log("Trigger Enter");
        enterEvent.Invoke();

        if (destroyTriggerOnActivation == true)
        {
            Destroy(gameObject);
        }

        startEnterTimer = true;
    }
    public void TriggerExit()
    {
        exitEvent.Invoke();

        startExitTimer = true;
    }
    public override void TriggerInteraction()
    {
        TriggerEnter();
    }
}
