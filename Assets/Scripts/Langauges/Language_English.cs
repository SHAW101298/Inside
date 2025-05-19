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
        text[56] = "Sit  ( E )";
        text[57] = "Stand Up  ( E )";
        text[58] = "Open  ( E )";
        text[59] = "Close  ( E )";


        text[70] = "1-1 The Pit";
        text[71] = "1-2 The Stillness";
        text[72] = "1-2 The Silent World";

        text[96] = "NO TEXT";
        text[97] = "Won't even budge";
        text[98] = "GAME FINISHED FOR NOW. There are a few things that changed on map, which you're free to explore. But nothing more than that is ready.";
        text[99] = "You're just an unexpected guest inside someones mind. Enjoy the journey and watch the story unfold.";


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
        text[130] = "tired";
        text[131] = "what is my purpose";
        text[132] = "what is wrong with me";
        text[133] = "was that supposed to happen ?";
        text[134] = "its better to just . . .";

        text[135] = "pathetic";
        text[136] = "you thought it will be that easy ?";
        text[137] = "just find that little spark in yourself";
        text[138] = "then everything will surely work out";
        text[139] = "a few more steps and everything will be great";
        text[140] = "keep going, believe in yourself";
        text[141] = "Don't make me laugh";
        text[142] = "you knew it will never work";
        text[143] = "might as well burn this whole place down and start from scratch";


        text[144] = "A silent world.";
        text[145] = "A world where things just stopped.";
        text[146] = "Not because of some cataclysm.";
        text[147] = "Not beacause of abandonment.";
        text[148] = "But because of a damage.";
        text[149] = "Damage dealt by others";
        text[150] = "things not considered properly";
        text[151] = "decisions made by people who won't give second thought a chance";
        text[152] = "actions made without a feeling of consequence.";
        text[153] = "Welcome.";
        text[154] = "The world before your eyes is the one, some might say is beyond repair.";
        text[155] = "The world doomed to fail.";
        text[156] = "And yet. Here you stand. ";
        text[157] = "Trying to make things right. Trying to fix this shithole. ";
        text[158] = "Good Luck. Because i couldn't.";
        text[159] = "So yeah, a world where things just stay.";
        text[160] = "Just the way they were left.";
        text[161] = "For someone to pickup. Just for a convienience.";
        text[162] = "Like a random shiny peeble on a road.";
        text[163] = "A plant that hasn't been watered for god knows how many days just begging for some rain.";
        text[164] = "Just trying to survive, trying to be itself.";
        text[165] = "But there is no rain coming.";
        text[166] = "Nothing that may correct the course of actions.";
        text[167] = "All that is left is just waiting for the time to come. ";
        text[168] = "All the hope you may have had is lost.";
        text[169] = "Welcome to this world.";
    }
}

/* Crow Lines

A world where things just stopped. Not because of some cataclysm. Not beacause of abandonment.
But because of a damage.
Damage dealt by others
things not considered properly
decisions made by people who won't give second thought a chance
actions made without a feeling of consequence.
Welcome. 
The world before your eyes is the one, some might say is beyond repair. 
The world doomed to fail. 
And yet. Here you stand. 
Trying to make things right. Trying to fix this shithole. 
Good Luck. Because i couldn't.
So yeah, a world where things just stay. Just the way they were left.
For someone to pickup. Just for a convienience.
Like a random shiny peeble on a road.
A plant that hasn't been watered for god knows how many days just begging for some rain.
Just trying to survive, trying to be itself.
But there is no rain coming. Nothing that may correct the course of actions.
All that is left is just waiting for the time to come. 
All the hope you may have had is lost.
Welcome to this world.


 */
