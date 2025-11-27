using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesManager : MonoBehaviour
{
    #region
    private void Awake()
    {
        Instance = this;
    }
    public static NotesManager Instance;
#endregion
    public List<Note> notes;
    public List<Note> RAW_Notes;
    [SerializeField] int currentlyAccessedNote;

    private void Start()
    {
        RequestSync();
    }
    public void RevealNoteData(int line)
    {
        //notes[currentlyAccessedNote].ChangeLangData(line,RAW_Notes[currentlyAccessedNote].GetLangIndex(line));
        notes[currentlyAccessedNote].RevealNoteLine(line);
    }
    public void HideNoteData(int line)
    {
        notes[currentlyAccessedNote].ChangeLangData(line, 98);
    }
    public void AccessNoteData(int index)
    {
        currentlyAccessedNote = index;
    }
    public void RevealNoteData(int index, int line)
    {
        //notes[index].ChangeLangData(line, RAW_Notes[index].GetLangIndex(line));
        notes[index].RevealNoteLine(line);
    }
    public void RequestSync()
    {
        NotesData.Instance.SyncPersistentData();
    }
}
