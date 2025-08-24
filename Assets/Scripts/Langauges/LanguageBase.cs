using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LanguageBase : MonoBehaviour
{
    public abstract string GetText(int index);
    protected abstract void FillTextScene0();
    protected abstract void FillTextBase();
}
