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


        text = new string[300];
        // UI TEXT
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
        text[24] = "Choose Chapter";


        // INTERACTION TEXT
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


        // LEVEL NAMES
        text[70] = "1-1 The Pit";
        text[71] = "1-2 The Stillness";
        text[72] = "1-2 The Silent World";


        // Additional Texts
        text[94] = "                               ";
        text[95] = "? ? ?";
        text[96] = "NO TEXT";
        text[97] = "Won't even budge";
        text[98] = "GAME FINISHED FOR NOW. There are a few things that changed on map, which you're free to explore. But nothing more than that is ready.";
        text[99] = "You're just an unexpected guest inside someones mind. Enjoy the journey and watch the story unfold.";


        // Erratic Thoughts Intro Scene
        text[100] = "run";
        text[101] = "join";
        text[102] = "no time";
        text[103] = "escape";
        text[104] = "they are coming";
        text[105] = "paralyzed";
        text[106] = "help";
        text[107] = "weak";
        text[108] = "don't go";
        text[109] = "GIVE UP";
        text[110] = "i'm afraid";
        text[111] = "can't take it anymore";
        text[112] = "get lost";
        text[113] = "disappear";
        text[114] = "so cold";
        text[115] = "it's too much";
        text[116] = "no hope";
        text[117] = "FASTER";
        text[118] = "stay";
        text[119] = "lose";

        // SCENE 02
        // Crow Random Lines
        text[150] = "FIND IT !!!";
        text[151] = "FORGET !!!";
        text[152] = "Lost . . .";
        text[153] = "Soon";
        text[154] = "Why";
        text[155] = "end this";
        text[156] = "alone";
        text[157] = "failed";
        text[158] = "all is lost";
        text[159] = "no more reasons";
        text[160] = "Fear";
        text[161] = "leave it";
        text[162] = "tired";
        text[163] = "the cycle repeats";
        text[164] = "you're a fool";
        text[165] = "Leave.";
        text[166] = "last . . . request";
        text[167] = "erase . . . existence";
        text[168] = "Find the road";
        text[169] = "please, no more hope";
        text[170] = "It feels like I'm the last one";
        text[171] = "The collapse is inevitable";


        // Bench Thoughts
        text[200] = "what is my purpose";
        text[201] = "what is wrong with me";
        text[202] = "was that supposed to happen ?";
        text[203] = "its better to just . . .";


        // On Interactions
        text[210] = "Place - Spark  ( E )";
        text[211] = "Take - Spark  ( E )";
        text[212] = "Held together by what exactly ?";
        text[213] = "As if . . . the time stopped";
        text[214] = "something is missing here";


        // Insulting Crow 1
        text[250] = "pathetic";
        text[251] = "you thought it will be that easy ?";
        text[252] = "just find that little spark in yourself";
        text[253] = "then everything will surely work out";
        text[254] = "a few more steps and everything will be great";
        text[255] = "keep going, believe in yourself";
        text[256] = "Don't make me laugh";
        text[257] = "you knew it will never work";
        text[258] = "might as well burn this whole place down and start from scratch";


        // Lore Drop
        text[260] = "A silent world.";
        text[261] = "A world where things just stopped.";
        text[262] = "Not because of some cataclysm.";
        text[263] = "Not beacause of abandonment.";
        text[264] = "But because of a damage.";
        text[265] = "Damage dealt by others";
        text[266] = "things not considered properly";
        text[267] = "decisions made by people who won't give second thought a chance";
        text[268] = "actions made without a feeling of consequence.";

        text[269] = "Welcome.";
        text[270] = "The world before your eyes is the one, some might say is beyond repair.";
        text[271] = "The world doomed to fail.";
        text[272] = "And yet. Here you stand. ";
        text[273] = "Trying to make things right. Trying to fix this shithole. ";
        text[274] = "Good Luck. Because i couldn't.";

        text[275] = "So yeah, a world where things just stay.";
        text[276] = "Just the way they were left.";
        text[277] = "For someone to pickup. Just for a convenience.";
        text[278] = "Like a random shiny peeble on a road.";
        text[279] = "A plant that hasn't been watered for god knows how many days just begging for some rain.";
        text[280] = "Just trying to survive, trying to be itself.";
        text[281] = "But there is no rain coming.";
        text[282] = "Nothing that may correct the course of actions.";
        text[283] = "All that is left is just waiting for the time to come. ";
        text[284] = "All the hope you may have had is lost.";
        text[285] = "Welcome to this world.";

        // You want some advice ? Ok.
        // Go and find a hidden spark of hope
        // Who knows, maybe a door to the better future will open itself before you
    }
}

/* Lore Lines

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
/* Unfiltered Crows Lines
    
pathetic       
you thought it will be that easy ?
just find that little spark in yourself
then everything will surely work out
a few more steps and everything will be great
keep going, believe in yourself
Don't make me laugh
you knew it will never work

 */

/*
Trochê dziwny odg³os chodzenia
Muzykê momentami wyciszyæ ? Chwilê jakiejœ spokojnej puœciæ ?
    Mo¿liwoœæ startu z dowolnego etapu
    Nie da sie skakaæ i biegaæ na raz
    Podczas siadania nie blokowaæ obrotu
    Dodatkowe deski do mostu
Wskoczyæ do dziury
Animacje kruków
 */
