using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnterTrigger : MonoBehaviour
{
    public UnityEvent enterEvent;
    [Space(10)]
    [SerializeField] List<GameObject> objectsToDestroy;
    [SerializeField] bool destroyObjectOnActivation;
    [SerializeField] bool destroyTriggerOnActivation;
    [SerializeField] float destroyDelay;
    [SerializeField] GameObject objectToEnable;

    float timer;
    bool startTimer;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            enterEvent.Invoke();
            if(objectToEnable != null)
            {
                objectToEnable.SetActive(true);
            }

            startTimer = true;
        }
    }

    private void Update()
    {
        if (startTimer == true)
        {
            timer += Time.deltaTime;
            if (timer >= destroyDelay)
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
                    Destroy(this);
                }
            }
        }
    }
}
