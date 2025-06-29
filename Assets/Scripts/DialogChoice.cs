using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DialogOption
{
    [SerializeField] int lang_Index;
    public bool removeWhenChoosen;
    public InteractTrigger trigger;
    public int GetLangIndex()
    {
        return lang_Index;
    }
}

public class DialogChoice : MonoBehaviour
{
    public List<DialogOption> options;

    public void ChoosenOption(int x)
    {
        Debug.Log("Choosen option " + x);
        if (options[x].removeWhenChoosen == true)
        {
            options.RemoveAt(x);
        }
        if (options[x].trigger != null)
        {
            options[x].trigger.TriggerInteraction();
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
