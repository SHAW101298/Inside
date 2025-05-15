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

        text = new string[200];
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
        text[21] = "Continue";
        text[22] = "To Menu";
        text[23] = "Language";


        text[50] = "Touch  ( E )";
        text[51] = "Climb  ( E )";
        text[52] = "Look  ( E )";
        text[53] = "????  ( E )";
        text[54] = "Place  ( E )";
        text[55] = "Listen  ( E )";


        text[70] = "1-1 The Pit";
        text[71] = "1-2 The Stillness";
        text[72] = "1-2 The Silent World";


        text[99] = "You're just an unexpected guest inside someones mind. Discover the truth hidden under the blanket of reality.";


        text[100] = "                               ";
        text[101] = "? ? ?";
        text[102] = "* knock knock knock *";
        text[103] = "What's that noise ?";
        text[104] = "FIND IT !!!";
        text[105] = "FORGET !!!";
        text[106] = "Lost . . .";
        text[107] = "Soon";
        text[108] = "Why";
        text[109] = "As if . . . the time stopped";
        text[110] = "end this";
        text[111] = "alone";
        text[112] = "failed";
        text[113] = "all is lost";
        text[114] = "no more reasons";
        text[115] = "last . . . request";
        text[116] = "something is missing here";
        text[117] = "Take - Spark  ( E )";
        text[118] = "Place - Spark  ( E )";
        text[119] = "Fear";
        text[120] = "erase . . . existence";
        text[121] = "leave it";
        text[122] = "please, no more hope";
        text[123] = "the cycle repeats";
        text[124] = "you're a fool";
        text[125] = "Leave.";
        text[126] = "It feels like I'm the last one";
        text[127] = "Find the road";
        text[128] = "The collapse is inevitable";
        text[129] = "Held together by what exactly ?";
    }
}

/* Crow Lines
FORGET !!!

It feels like I'm the last one

 */
