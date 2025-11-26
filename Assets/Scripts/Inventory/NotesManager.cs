using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesManager : MonoBehaviour
{
    public List<Note> notes;
    public List<Note> RAW_Notes;
    [SerializeField] int currentlyAccessedNote;


    public void RevealNoteData(int line)
    {
        notes[currentlyAccessedNote].ChangeLangData(line,RAW_Notes[currentlyAccessedNote].GetLangIndex(line));
    }
    public void HideNoteData(int line)
    {
        notes[currentlyAccessedNote].ChangeLangData(line, 98);
    }
    public void AccessNoteData(int index)
    {
        currentlyAccessedNote = index;
    }

}
