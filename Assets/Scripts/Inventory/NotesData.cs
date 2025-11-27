using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class NotePersistentData
{
    [SerializeField]public List<bool> isRevealed;
}
public class NotesData : MonoBehaviour
{
    public static NotesData Instance;
    public List<NotePersistentData> notes;
    private void Awake()
    {
        DontDestroyOnLoad(this);
        if (Instance != this && Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    public void SyncPersistentData()
    {
        for(int i = 0; i < notes.Count; i++)
        {
            for(int j = 0; j < notes[i].isRevealed.Count; j++)
            {
                if (notes[i].isRevealed[j] == true)
                {
                    NotesManager.Instance.RevealNoteData(i, j);
                }
            }
        }
    }
}
