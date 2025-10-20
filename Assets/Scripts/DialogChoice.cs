using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DialogOption
{
    [SerializeField] int lang_Index;
    [SerializeField] DialogPrompt prompt;
    public bool removeWhenChoosen;
    public SimpleTrigger trigger;
    public int GetLangIndex()
    {
        return lang_Index;
    }
    public DialogPrompt GetDialogPrompt()
    {
        return prompt;
    }

}

public class DialogChoice : MonoBehaviour
{
    public List<DialogOption> options;

    public void ChoosenOption(int x)
    {
        Debug.Log("Choosen option " + x);
        if (options[x].trigger != null)
        {
            options[x].trigger.TriggerInteraction();
        }
        if (options[x].removeWhenChoosen == true)
        {
            options.RemoveAt(x);
        }
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
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

}
