using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogPrompt : MonoBehaviour
{
    [SerializeField] List<int> index;
    [SerializeField] bool removeShownTextsFromList;
    [SerializeField] int lastTextIndex;

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

    void LastTextSpoken()
    {

    }
}
