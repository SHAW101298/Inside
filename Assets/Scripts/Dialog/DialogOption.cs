using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogOption : MonoBehaviour
{
    [SerializeField] int lang_Index;
    public bool removeWhenChoosen;
    public SimpleTrigger trigger;

    DialogChoice dialogChoice;

    private void Start()
    {
        dialogChoice = GetComponentInParent<DialogChoice>();
    }

    public int GetLangIndex()
    {
        return lang_Index;
    }
    public void EnableOption()
    {
        dialogChoice.EnableDialogOption(this);
    }
    public void DisableOption()
    {
        dialogChoice.DisableDialogOption(this);
    }
    public void OptionChoosen()
    {
        if (removeWhenChoosen == true)
        {
            DisableOption();
        }
        trigger.TriggerInteraction();
    }

}
