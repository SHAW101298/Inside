using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DialogPrompt : MonoBehaviour
{
    public List<int> index;
    [SerializeField] List<int> usedIndexes;
    [SerializeField] bool removeShownTextsFromList;
    //[SerializeField] bool destroyOnLast;

    public UnityEvent EVENT_StartShowing;
    public UnityEvent EVENT_EndShowing;
    public UnityEvent EVENT_EmptyIndexList;
    public UnityEvent EVENT_AllTextsUsedUp;


    public void PromptAllDialogFields()
    {
        for (int i = 0; i < index.Count; i++)
        {
            DialogData data = new DialogData(this, index[i]);

            //Debug.Log("data prompt = " + data.prompt);
            //Debug.Log("data index = " + data.index);
            DialogManager.Instance.ShowText(data);
        }
        if(removeShownTextsFromList == true)
        {

            for (int i = 0; i < index.Count; i++)
            {
                usedIndexes.Add(index[i]);
            }

            index.Clear();
            EVENT_EmptyIndexList.Invoke();
        }
    }
    public void PromptRandomDialogField()
    {
        int rand = Random.Range(0, index.Count);

        DialogData data = new DialogData(this, index[rand]);
        
        DialogManager.Instance.ShowText(data);

        if(removeShownTextsFromList == true)
        {
            usedIndexes.Add(index[rand]);
            index.RemoveAt(rand);
        }

        if (index.Count == 0)
        {
            EVENT_EmptyIndexList.Invoke();
        }
    }
    public void PromptOneDialogField()
    {
        DialogData data = new DialogData(this, index[0]);
        DialogManager.Instance.ShowText(data);

        if (removeShownTextsFromList == true)
        {
            usedIndexes.Add(index[0]);
            index.RemoveAt(0);
        }
        else
        {
            int x = index[0];
            index.RemoveAt(0);
            index.Add(x);
        }

        if (index.Count == 0)
        {
            EVENT_EmptyIndexList.Invoke();
        }
    }
    public void TriggerDestruction()
    {
        //Debug.Log("Trigger Destruction of Prompt");
        Destroy(gameObject);
    }
    public void DestroyOnLast()
    {
        Debug.Log("Destroy On Last");
        // Run when EVENT_EndShowing is invoked
        if(index.Count == 0)
        {
            TriggerDestruction();
        }
    }

    public void RemoveFirstFromUsed()
    {
        usedIndexes.RemoveAt(0);

        if (usedIndexes.Count > 0)
            return;
        if (index.Count > 0)
            return;
        EVENT_AllTextsUsedUp.Invoke();

    }
    public void DestroyIfEmptyIndexes()
    {
        if (index.Count != 0)
            return;
        if (usedIndexes.Count != 0)
            return;
            
        Destroy(gameObject);
    }
    public void DEBUGSTARTSHOWING()
    {
        Debug.Log("EVENT START SHOWING");
    }
}
