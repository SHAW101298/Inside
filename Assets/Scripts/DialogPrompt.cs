using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DialogPrompt : MonoBehaviour
{
    [SerializeField] List<int> index;
    [SerializeField] bool removeShownTextsFromList;
    [SerializeField] int lastTextIndex;

    public UnityEvent EVENT_LastTextSpoken;

    public void PromptDialogField()
    {

        for (int i = 0; i < index.Count; i++)
        {
            DialogManager.Instance.ShowText(index[i]);
        }
    }
    public void PromptRandomDialogField()
    {
        if(index.Count == 0)
        {
            DialogManager.Instance.ShowText(lastTextIndex);
            LastTextSpoken();
            return;
        }

        int rand = Random.Range(0, index.Count);
        DialogManager.Instance.ShowText(index[rand]);

        if(removeShownTextsFromList == true)
        {
            index.RemoveAt(rand);
        }
    }
    public void PromptOneDialogField()
    {
        if (index.Count == 0)
        {
            DialogManager.Instance.ShowText(lastTextIndex);
            LastTextSpoken();
            return;
        }
        DialogManager.Instance.ShowText(index[0]);

        if (removeShownTextsFromList == true)
        {
            index.RemoveAt(0);
        }

    }

    void LastTextSpoken()
    {
        EVENT_LastTextSpoken.Invoke();
    }
}
