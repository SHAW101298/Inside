using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DialogPromptGroup : MonoBehaviour
{
    [SerializeField] public List<DialogPrompt> prompts;
    //[SerializeField] public List<DialogPrompt_NO> promptsTest;
    public UnityEvent startShowingGroupEVENT;
    public UnityEvent endShowingGroupEVENT;

    [SerializeField] bool removeShownTextsFromList;

    public void PromptAllDialogFields()
    {
        prompts[0].EVENT_StartShowing.AddListener(GroupStarted);
        prompts[prompts.Count - 1].EVENT_EndShowing.AddListener(GroupFinished);
        for (int i = 0; i < prompts.Count; i++)
        {
            DialogManager.Instance.ShowText(prompts[i]);
        }
        if (removeShownTextsFromList == true)
        {
            prompts.Clear();
        }
        
    }
    public void PromptDialogField(int x)
    {
        DialogManager.Instance.ShowText(prompts[x]);
        if (removeShownTextsFromList == true)
        {
            prompts.RemoveAt(x);
        }
    }
    public void PromptRandomDialogField()
    {
        int rand = Random.Range(0, prompts.Count);
        DialogManager.Instance.ShowText(prompts[rand]);
        if(prompts.Count == 1)
        {
            prompts[0].EVENT_EndShowing.AddListener(GroupFinished);
        }
        if (removeShownTextsFromList == true)
        {
            prompts.RemoveAt(rand);
        }
    }
    public void GroupFinished()
    {
        Debug.Log("Group Finished");
        endShowingGroupEVENT.Invoke();
    }
    public void GroupStarted()
    {
        Debug.Log("Group started");
        startShowingGroupEVENT.Invoke();
    }
    public void TriggerDestruction()
    {
        Destroy(gameObject);
    }
}
