using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DialogOption
{
    [SerializeField] int lang_Index;
    public bool removeWhenChoosen;
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
        if (options[x].removeWhenChoosen == true)
        {
            options.RemoveAt(x);
        }
    }

}
