using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DialogChoice : MonoBehaviour
{
    public List<DialogOption> options;
    public List<DialogOption> disabledOptions;
    public UnityEvent EVENT_EmptyDialogOptions;
    public UnityEvent EVENT_DialogChoiceMade;

    public void ChoosenOption(int x)
    {
        Debug.Log("Choosen option " + x);
        if (options[x].trigger != null)
        {
            options[x].OptionChoosen();
        }
        
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        EVENT_DialogChoiceMade.Invoke();

        if(options.Count == 0)
        {
            EVENT_EmptyDialogOptions.Invoke();
        }
    }
    public void ShowOptions()
    {
        DialogManager.Instance.ShowDialogOptions(this);
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
    }
    public void PauseShownText()
    {
        DialogManager.Instance.PauseWaitTimer();
    }
    public void UnPauseShownText()
    {
        DialogManager.Instance.UnPauseWaitTimer();
    }
    public void EnableDialogOption(DialogOption option)
    {
        // prevents duplicates
        if (options.Contains(option))
        {
            return;
        }
        disabledOptions.Remove(option);
        options.Add(option);
    }
    public void DisableDialogOption(DialogOption option)
    {
        // prevents duplicates
        if(disabledOptions.Contains(option))
        {
            return;
        }
        options.Remove(option);
        disabledOptions.Add(option);
    }
    public void HideChoiceOptions()
    {
        DialogManager.Instance.HideDialogWindow();
    }

}
