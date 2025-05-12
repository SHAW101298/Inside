using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnterTrigger : MonoBehaviour
{
    public UnityEvent enterEvent;
    [SerializeField] GameObject parent;
    [SerializeField] bool destroyTriggerOnActivation;
    [SerializeField] bool destroyParentOnActivation;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            enterEvent.Invoke();

            if(destroyParentOnActivation == true)
            {
                Destroy(parent);
            }

            if(destroyTriggerOnActivation == true)
            {
                Destroy(this);
            }
        }
    }
}
