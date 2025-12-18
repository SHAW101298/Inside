using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public enum ENUM_TriggerTypes
{
    simple,
    enter,
    timed,
    random,
    look,
    conditional
}
public abstract class TriggerBase : MonoBehaviour
{
    // Holds all basic actions a trigger may do

    [Header("Data")]
    [SerializeField] protected UnityEvent interactEvent;
    [SerializeField] protected bool destroyTriggerOnActivation;
    [SerializeField] protected bool disableTriggerOnActivation;

    [SerializeField] protected List<GameObject> objectsGroup1;
    [SerializeField] protected List<GameObject> objectsGroup2;

    [SerializeField] protected bool debugTriggerInteraction;

    #region Possible Actions
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
    public void TriggerDestruction()
    {
        Destroy(gameObject);
    }
    public abstract void TriggerInteraction();
    public abstract ENUM_TriggerTypes GetTriggerType();
    #endregion
}
