using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class DialogPrompt
{
    public int index;

    public UnityEvent EVENT_StartShowing;
    public UnityEvent EVENT_EndShowing;
}
