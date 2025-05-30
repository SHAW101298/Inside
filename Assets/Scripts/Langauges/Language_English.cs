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


        text = new string[450];
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
        text[60] = "Kill  ( E )";


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
        text[109] = "give up";
        text[110] = "i'm afraid";
        text[111] = "can't take it anymore";
        text[112] = "get lost";
        text[113] = "disappear";
        text[114] = "so cold";
        text[115] = "it's too much";
        text[116] = "no hope";
        text[117] = "faster";
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
        text[169] = "please, leave";
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
        text[215] = "A door to better future";
        text[216] = "Take - Dagger  ( E )";


        // Insulting Crow 1  APPLIED
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
        text[263] = "Not because of abandonment.";
        text[264] = "But because of the damage.";
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

        text[286] = "You want some advice ?";
        text[287] = "Go and find your own spark of hope.";
        text[288] = "Who knows, maybe a door to the better future will open itself before you.";

        text[290] = "Ahhh, I can already tell that you found what was missing.";
        text[291] = "Now you can hear them clearly, right ?";
        text[292] = "Ohhh, how i missed the silence.";
        text[293] = "Now you're in charge.";
        text[294] = "Thanks for freeing me from this burden.";

        text[295] = "If you have no idea what to do, i can try to help you.";
        text[296] = "First . . . Have you tried listening to these thoughts at least ?";
        text[297] = "Who knows, maybe you will learn something useful ?";

        // Insulting Crow 2  APPLIED
        text[300] = "What are you even trying to accomplish here ?";
        text[301] = "Give Up.";
        text[302] = ".  .  .                           ";
        text[303] = "Can't you understand what i just said ?";
        text[304] = "GIVE UP";
        text[305] = "Do me a favour and end this facade.";
        text[306] = "No one wants you doing any of these things.";

        // Insulting Crow 3  APPLIED 
        text[310] = "Do you see that pile of corpses over there ?";
        text[311] = "Why won't you just lie there and die";
        text[312] = "No one's gonna notice";
        text[313] = "You were never meant to exist anyway";
        text[314] = "Accept that.";

        // Insulting Crow 4  APPLIED
        text[320] = "Whom do we have here ?";
        text[321] = "The long awaited savior!";
        text[322] = "The one destinied to make things right!";
        text[323] = "savior my ass";
        text[324] = "Look at yourself";
        text[325] = "Someone like you, accomplishing anything ?";
        text[326] = "What a joke";

        // Insulting Crow 5  APPLIED
        text[330] = "Are you done ?";
        text[331] = "Stop being delusional";
        text[332] = "You never did anything right.";
        text[333] = "What makes you think, you can do it now ?";
        text[334] = "You will never make it. Trust me on that.";

        // Insulting Crow 6  APPLIED
        text[340] = "HahAhAhaHAha";
        text[341] = "Thats a good one!";
        text[342] = "Where did such a clown like you appear from ?";
        text[343] = "Garbagepile ?";
        text[344] = "Where else such good for nothing being would be ?";
        text[345] = "I can't wait to see you break.";
        text[346] = "Fight for your life !";
        text[347] = "Come on, For fun !";
        text[348] = "let's see you cry";

        // Insulting Crow 7 APPLIED
        text[350] = "Took you long enough to get here.";
        text[351] = "Why are you always this slow ?";
        text[352] = "Is it because you're tired ?";
        text[353] = "Get a grip on your self.";
        text[354] = "You bring nothing but shame.";
        text[355] = "You deserve all these things. Thats your well earned reward.";
        text[356] = "Come on. Enjoy yourself. What's stopping you ?";

        // Insulting Crow 8  APPLIED
        text[360] = "You know what i always think when i look at you ?";
        text[361] = "That you're just a defect.";
        text[362] = "Defect on history pages. Meant to be erased.";
        text[363] = "Forgotten";
        text[364] = "Like a careless pencil mark in a sketchbook.";
        text[365] = "Keep that in your tiny mind.";

        // Insulting Crow 9  APPLIED
        text[370] = "Do you intend to put any effort into that ?";
        text[371] = "All i see is you just walking around";
        text[372] = "As if you dont know what to do at all";
        text[373] = "How dumb can you really be ?";

        // Insulting Crow 10  APPLIED
        text[380] = "You need to start accepting facts.";
        text[381] = "You chose all of this.";
        text[382] = "Every event is the result of your own inability";
        text[383] = "And you even chose to escape from the problems.";
        text[384] = "Bury them down and forget.";
        text[385] = "How classic of you.";

        // Past Self continued Talk
        text[400] = "And ? Did you learn anything of value ?";
        text[401] = "Not much i guess";
        text[402] = "You know what they say.";
        text[403] = "There will be no change when the environment stays the same.";
        text[404] = "      ";
        text[405] = "You may find some use for this i think."; // Hands a knife to the player

        // After First Crow Killed
        text[410] = "Do what you have to.";
        // After 3 Crows Killed
        text[411] = "I hope its worth it.";
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


defekt na kartach skazany na wymazanie.

self fulfilling prophecy

 */

/*
Trochê dziwny odg³os chodzenia
Chwilê jakiejœ spokojnej muzyki puœciæ ?
Wskoczyæ do dziury
    Muzykê momentami wyciszyæ ? 
    Mo¿liwoœæ startu z dowolnego etapu
    Nie da sie skakaæ i biegaæ na raz
    Podczas siadania nie blokowaæ obrotu
    Dodatkowe deski do mostu
    Animacje kruków
 */
/*
Pod stert¹ martwych kruków, bêdzie le¿a³o ostrze.
Kruki odlatuj¹ce gdy zbli¿a siê gracz, i przylatuj¹ce gdy siê oddali.
    Kruki co jakiœ czas lataj¹ce po niebie
Mo¿liwoœæ przewijania dialogu ?
Mo¿liwoœæ wybierania wypowiadanych dialogów ?
Zabijanie kruków zmniejsza widocznoœæ Past Self i zmniejsza Skalê czêœci cia³a do 0
Zwyk³a rozmowa z krukami niszczy cia³o past self
 */
