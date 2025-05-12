using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogPrompt : MonoBehaviour
{
    [SerializeField] List<int> index;

    public void PromptDialogField()
    {
        for (int i = 0; i < index.Count; i++)
        {
            DialogManager.Instance.ShowText(index[i]);
        }
    }
}
