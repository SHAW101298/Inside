using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Language_English : LanguageBase
{
    public static Language_English Instance;
    public string[] text;

    public override string GetText(int index)
    {
        return text[index];
    }

    public void Awake()
    {
        if (Instance != this && Instance != null)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }

        text = new string[100];
        text[0] = "Start Game";
        text[1] = "How To Play";
        text[2] = "Options";
        text[3] = "Exit Game";
        text[4] = "Exit Game ?";
        text[5] = "Yes";
        text[6] = "No";
        text[7] = "Music";
        text[8] = "Sounds";
        text[9] = "Full Screen";
        text[10] = "Resolution";
        text[11] = "FPS Cap";
        text[12] = "Vsync";
        text[13] = "Return";
        text[14] = "Save and Exit";
        text[15] = "Return without Saving";
        text[16] = "Controls";
        text[17] = "Movement";
        text[18] = "Jump";
        text[19] = "Interact";
        text[20] = "Run";
        text[21] = "Touch  ( E )";
        text[22] = "Climb  ( E )";
        text[23] = "Continue";
        text[24] = "To Menu";
        text[25] = "FIND IT !!!";
        text[26] = "????  ( E )";
        text[27] = "Language";
        text[28] = "* knock knock knock *";
        text[29] = "What's that noise ?";
        text[30] = "FORGET !!!";
        text[31] = "Lost . . .";
        text[32] = "Soon";
        text[33] = "Why";
        text[97] = "1-1 The Pit";
        text[98] = "1-2 The Stillness";
        text[99] = "1-2 The Silent World";
    }
}

/* Crow Lines
FORGET !!!

 */