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


        text = new string[550];
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
        text[61] = "Read  ( E )";


        // LEVEL NAMES
        text[70] = "1-1 The Pit";
        text[71] = "1-2 The Stillness";
        text[72] = "1-3 The Unknown";


        // Additional Texts
        text[93] = "Press W to move Forward.";
        text[94] = "                               ";
        text[95] = "? ? ?";
        text[96] = "NO TEXT";
        text[97] = "Won't even budge";
        text[98] = "GAME FINISHED FOR NOW. You may search the map, and kill the crows while listening to them but thats all there is right now.";
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
        text[120] = "kill";
        text[121] = "die";
        text[122] = "cut";
        text[123] = "memories";
        text[124] = "remember";
        text[125] = "hide";
        text[126] = "avoid";
        text[127] = "cornered";
        text[128] = "defect";
        text[129] = "meaningless";
        text[130] = "jump";

        text[131] = "Hello";
        text[132] = "Nice to meet you";
        text[133] = "Could you do me a little favour ?";
        text[134] = "Stay with me a bit longer.";

        text[135] = "Danger";
        text[136] = "Suppress";
        text[137] = "Control";
        text[138] = "GET BACK HERE !!!";

        text[139] = "No";
        text[140] = "Try";
        text[141] = "once more";
        text[142] = "im done";


        // Just of what am i so afraid ?
        text[145] = "Just what am i afraid of ?!"; 
        text[146] = "Life passing me by?";
        text[147] = "This is all just a breeze";

        // Life Goes by, just deal with it
        text[148] = "The river of time dictates the road we walk on";
        text[149] = "All we can do is follow along.";
        text[150] = "Follow ... And belive there is something more.";

        // Things happen, but its just a small setback
        text[151] = "Some things are set in stone.";
        text[152] = "But we are the ones thrown into the water.";
        text[153] = "There are still things that we can decide for ourselves.";

        // Life is no small setback. It is a setback
        text[154] = "I don't know where to put my trust anymore.";
        text[155] = "Everything i believed in fell apart.";
        text[156] = "Or maybe it fell into the right place ?";
        text[157] = "Like the puzzle pieces created for such an occasion.";

        // Life is but a stepping stone
        text[158] = "sOMeOnE daReS tO TrY me ?";
        text[159] = "ME ?!";
        text[160] = "To even have the aUDacItY !";
        text[161] = "Interesting . . .";
        // Dig through ditches
        // Burn through the witches

        // SCENE 02
        #region  


        Debug.LogError("CROW LINES NEED FIXING");

        // Crow Random Lines
        text[170] = "FIND IT !!!";  // Spawn
        text[171] = "FORGET !!!";   // Near Old Spawn
        text[172] = "Lost . . .";   // Bridge
        text[173] = "Soon";         // Motionless Pillars
        text[174] = "Why";          // Pillars
        text[175] = "end this";     // Hole
        text[176] = "alone";        // Dead
        text[177] = "failed";       // Altar
        text[178] = "all is lost";  // Altar
        text[179] = "no more reasons";          // Altar
        text[180] = "Fear";
        text[181] = "leave it";     // Road
        text[182] = "tired";
        text[183] = "the cycle repeats";        // Road
        text[184] = "you're a fool";            // Road
        text[185] = "Leave.";       // Road
        text[186] = "last . . . request";       // Pair
        text[187] = "erase . . . existence";    // Pair
        text[188] = "Find the road";                    // Dialog
        text[189] = "please, leave";
        text[190] = "It feels like I'm the last one";   // Dialog
        text[191] = "The collapse is inevitable";       // Dialog
        text[192] = "wasted";
        text[193] = "no effort";    // Road
        text[194] = "lies";         // Road / Lore


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

        text[289] = "You already made some progress on your own i see.";

        text[290] = "Ahhh, I can already tell that you found what was missing.";
        text[291] = "Now you can hear them clearly, right ?";
        text[292] = "Ohhh, how i missed the silence.";
        text[293] = "Now you're in charge.";
        text[294] = "Thanks for freeing me from this burden.";

        text[295] = "If you have no idea what to do, i can try to help you.";
        text[296] = "First . . . Have you tried listening to them at least ?";
        text[297] = "Who knows, maybe you will learn something useful ?";

        // Insulting Crow 2 Hole Crow
        text[300] = "What are you even trying to accomplish here ?";
        text[301] = "Give Up.";
        text[302] = ".  .  .                           ";
        text[303] = "Can't you understand what i just said ?";
        text[304] = "GIVE UP";
        text[305] = "Do me a favour and end this facade.";
        text[306] = "No one wants you doing any of these things.";

        // Insulting Crow 3 Dead Crows
        text[310] = "Do you see that pile of corpses over there ?";
        text[311] = "Why won't you just lie there and die";
        text[312] = "No one's gonna notice";
        text[313] = "You were never meant to exist anyway";
        text[314] = "Accept that.";

        // Insulting Crow 13 Temple Crow 2
        text[315] = "Hope cannot be eluded forever";
        text[316] = "At some point, you will just stop.";
        text[317] = "Stop and wonder what's the point";
        text[318] = "Finally realize there is no reason to even try.";
        text[319] = "You will remember my words then.";

        // Insulting Crow 4 Pair Crows 1
        text[320] = "Whom do we have here ?";
        text[321] = "The long awaited savior!";
        text[322] = "The one destinied to make things right!";
        text[323] = "savior my ass";
        text[324] = "Look at yourself";
        text[325] = "Someone like you, accomplishing anything ?";
        text[326] = "What a joke";

        // Insulting Crow 5 Dialog Crow
        text[330] = "Are you done ?";
        text[331] = "Stop being delusional";
        text[332] = "You never did anything right.";
        text[333] = "What makes you think, you can do it now ?";
        text[334] = "You will never make it. Trust me on that.";

        // Insulting Crow 12 Temple Crow 1
        text[336] = "The harder you fight the more you lose";
        text[337] = "In the end, you will end up all alone";
        text[338] = "Embrace it";
        text[339] = "Isn't that what you always dreamed of ?";

        // Insulting Crow 6 Pair Crows 2
        text[340] = "HahAhAhaHAha";
        text[341] = "Thats a good one!";
        text[342] = "Where did such a clown like you appear from ?";
        text[343] = "Garbagepile ?";
        text[344] = "Where else such good for nothing being would be ?";
        text[345] = "I can't wait to see you break.";
        text[346] = "Fight for your life !";
        text[347] = "Come on, For fun !";
        text[348] = "let's see you cry";

        // Insulting Crow 7 MotionLess Pillars Crows
        text[350] = "Took you long enough to get here.";
        text[351] = "Why are you always this slow ?";
        text[352] = "Is it because you're tired ?";
        text[353] = "Get a grip on your self.";
        text[354] = "You bring nothing but shame.";
        text[355] = "You deserve all these things. Thats your well earned reward.";
        text[356] = "Come on. Enjoy yourself. What's stopping you ?";

        // Insulting Crow 8 Pillars Crows
        text[360] = "You know what i always think when i look at you ?";
        text[361] = "That you're just a defect.";
        text[362] = "Defect on history pages. Meant to be erased.";
        text[363] = "Forgotten";
        text[364] = "Like a careless pencil mark in a sketchbook.";
        text[365] = "Keep that in your tiny mind.";

        // Insulting Crow 9 Road Crow
        text[370] = "Do you intend to put any effort into that ?";
        text[371] = "All i see is you just walking around";
        text[372] = "As if you dont know what to do at all";
        text[373] = "How dumb can you really be ?";

        // Insulting Crow 10 Broken Bridge Crow
        text[380] = "You need to start accepting facts.";
        text[381] = "You chose all of this.";
        text[382] = "Every event is the result of your own inability";
        text[383] = "And you even chose to escape from the problems.";
        text[384] = "Bury them down and forget.";
        text[385] = "How classic of you.";

        // Insulting Crow 11 Lore Crow
        text[390] = "It was obvious from the start";// Self fulfilling Prophecy
        text[391] = "You are a Self fulfilling prophecy";
        text[392] = "You cannot change what was already set in stone.";
        text[393] = "All your efforts are pointless.";
        text[394] = "Just like with a child . . .";

        // Past Self continued Talk
        text[399] = "Been busy, huh ?";

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
        text[415] = "A few are still alive.";
        // Crow location hints
        text[416] = "One might be near the ruined room. The one you came from.";
        text[417] = "Have you searched the road properly ? I belive one should still be there.";
        text[418] = "Those three pillars with one suspended in the air. How about searching there ?";
        text[419] = "There is a crow near the hole. At least there always was.";
        text[420] = "One should be somewhere close. Always watching.";
        text[421] = "How about the lovely pair on a tree ?";
        text[422] = "How about the lovely pair on a tree ?";
        text[423] = "What about the talkative one near the doors ?";
        text[424] = "There might be silent one near the doors.";
        text[425] = "Have you seen the one excluded from the temple standing on a rock ?";
        text[426] = "There used to be a bridge somewhere around here. ";
        text[427] = "Have you visited the one guarding the dead pile ?";
        text[428] = "Cross section of the riverbed is a home to one of them. ";

        text[430] = "I think you got all of them.";
        text[431] = "Now it really is a still world.";
        text[432] = "What a blissfull emptiness. Peace.";
        text[433] = "Like a sign of the approaching end";
        text[434] = "Ever so slowly. Baring its fangs. Creeping around the corner.";
        text[435] = "Considering the state Im in.";
        text[436] = "Will you let me finally rest ?"; // Enable Kill Interaction

#endregion

        text[450] = "The Road";
        text[451] = "The Choice";
        text[452] = "Give Up";
        text[453] = "Be";

        text[455] = "What is this place ?";
        text[456] = "Who Am I ?";
        text[457] = "What's going on ?";

        // What is this place answer
        text[460] = "This place used to be a past. Used to be a future.";
        text[461] = "The beggining of everything.";
        text[462] = "Now its just ... all that is left.";
        // Who Am I answer
        text[470] = "Go forward and find your answer.";
        text[471] = "You're the one with the keys and a will.";
        // What's going on answer
        text[480] = "You got lost.";
    }
    protected override void FillTextBase()
    {
        // UI TEXT
        text[0] = "NO TEXT";
        text[1] = "Start Game";
        text[2] = "How To Play";
        text[3] = "Options";
        text[4] = "Exit Game";
        text[5] = "Exit Game ?";
        text[6] = "Yes";
        text[7] = "No";
        text[8] = "Music";
        text[9] = "Sounds";
        text[10] = "Full Screen";
        text[11] = "Resolution";
        text[12] = "FPS Cap";
        text[13] = "Vsync";
        text[14] = "Return";
        text[15] = "Save and Exit";
        text[16] = "Return without Saving";
        text[17] = "Controls";
        text[18] = "Movement";
        text[19] = "Jump";
        text[20] = "Interact";
        text[21] = "Run";
        text[22] = "Continue";
        text[23] = "To Menu";
        text[24] = "Language";
        text[25] = "Choose Chapter";


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
        text[61] = "Read  ( E )";


        // LEVEL NAMES
        text[70] = "1-1 The Pit";
        text[71] = "1-2 The Stillness";
        text[72] = "1-3 The Unknown";

        text[99] = "You're just an unexpected guest inside someones mind. Enjoy the journey and watch the story unfold.";
    }
    protected override void FillTextScene0()
    {
        // Additional Texts
        text[100] = "Press W to move Forward.";
        text[101] = "? ? ?";


        // Erratic Thoughts Intro Scene
        text[102] = "run";
        text[103] = "join";
        text[104] = "no time";
        text[105] = "escape";
        text[106] = "they are coming";
        text[107] = "paralyzed";
        text[108] = "help";
        text[109] = "weak";
        text[110] = "don't go";
        text[111] = "give up";
        text[112] = "i'm afraid";
        text[113] = "can't take it anymore";
        text[114] = "get lost";
        text[115] = "disappear";
        text[116] = "so cold";
        text[117] = "it's too much";
        text[118] = "no hope";
        text[119] = "faster";
        text[120] = "stay";
        text[121] = "lose";
        text[122] = "kill";
        text[123] = "die";
        text[124] = "cut";
        text[125] = "memories";
        text[126] = "remember";
        text[127] = "hide";
        text[128] = "avoid";
        text[129] = "cornered";
        text[130] = "defect";
        text[131] = "meaningless";
        text[132] = "jump";

        text[140] = "Hello";
        text[141] = "Nice to meet you";
        text[142] = "Could you do me a little favour ?";
        text[143] = "Stay with me a bit longer.";
        text[144] = "GET BACK HERE !!!";

        text[150] = "Danger";
        text[151] = "Suppress";
        text[152] = "Control";

        text[160] = "No";
        text[161] = "Try";
        text[162] = "once more";
        text[163] = "im done";


        // Just of what am i so afraid ?
        text[170] = "Just what am i afraid of ?!";
        text[171] = "Life passing me by?";
        text[172] = "This is all just a breeze";

        // Life Goes by, just deal with it
        text[175] = "The river of time dictates the road we walk on";
        text[176] = "All we can do is follow along.";
        text[177] = "Follow ... And belive there is something more.";

        // Things happen, but its just a small setback
        text[180] = "Some things are set in stone.";
        text[181] = "But we are the ones thrown into the water.";
        text[182] = "There are still things that we can decide for ourselves.";

        // Life is no small setback. It is a setback
        text[185] = "I don't know where to put my trust anymore.";
        text[186] = "Everything i believed in fell apart.";
        text[187] = "Or maybe it fell into the right place ?";
        text[188] = "Like the puzzle pieces created for such an occasion.";

        // Life is but a stepping stone
        text[190] = "sOMeOnE daReS tO TrY me ?";
        text[191] = "ME ?!";
        text[192] = "To even have the aUDacItY !";
        text[193] = "Interesting . . .";
        // Dig through ditches
        // Burn through the witches
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

/* DO ZROBIENIA ?
Trochê dziwny odg³os chodzenia
Chwilê jakiejœ spokojnej muzyki puœciæ ?
Wskoczyæ do dziury
Kruki odlatuj¹ce gdy zbli¿a siê gracz, i przylatuj¹ce gdy siê oddali.
Mo¿liwoœæ przewijania dialogu ?
Mo¿liwoœæ wybierania wypowiadanych dialogów ?

A door to better future will open itself before you - zmieniæ aby nie by³o to mówione dos³ownie
 */
/* ZROBIONE
    Muzykê momentami wyciszyæ ? 
    Mo¿liwoœæ startu z dowolnego etapu
    Nie da sie skakaæ i biegaæ na raz
    Podczas siadania nie blokowaæ obrotu
    Dodatkowe deski do mostu
    Animacje kruków
    Kruki co jakiœ czas lataj¹ce po niebie
    Zabijanie kruków zmniejsza widocznoœæ Past Self i zmniejsza Skalê czêœci cia³a do 0
    Zwyk³a rozmowa z krukami niszczy cia³o past self
    collider na k³odzie

    Co powinno staæ siê po zabiciu wszystkich kruków ?
    Gracz idzie do Past Self. Który mówi ¿e ju¿ nie ma wiêcej kruków. Trzeba sprawdziæ LastBone i uruchomiæ ostatni Interact wy³aczaj¹c zapytanie o lokalizacjê
    S³ychaæ ponownie pukanie ze strony drzwi mo¿e ? Wy³¹czyæ background Noise
    Mo¿liwoœæ zabicia Past Self
    Search Party siê nie aktywuje
    altar crows nie w³¹cza siê kill trigger
    dead crows ma za wczeœnie w³¹czany kill trigger
    broken bridge crow ma wci¹¿ w³aczony trigger z before
 */


/* OD ROBERTA
    Da siê spojrzeæ za mapê na pierwszym poziomie
    WskaŸnik góra dó³ w pierwszym poziomie
Zmiana czu³oœci myszy
    Wspiêcie siê na drabinê mo¿na uruchomiæ dwa razy
    Przy kamyczku na start nie mo¿na skoczyæ, zwiêkszyæ ground check
    Lore drop crow can't Interact
    Moc pogadaæ z ka¿dym krukiem
    Gdy siê siedzi, spacj¹ mo¿na te¿ wstaæ
    "sameu wybra³eœ to wszystko"
    No lore drop after listening to crows ?
        Altar crow collider not trigger         Sprawdzone, niby jest ok ?
    Chce widzieæ twój rozpacz
Oznaczyæ punkty wszystkie. Mo¿e jaœniejszy kolor
    Licznik zabitych kruków
    Przeniesienie spawnu bli¿ej Past Self
Czas gry 1 godzina, na 2 scenê
Czas gry 10 minut 1 scena
 */

/* OD ANDZI
 Na poziomie pierwszym jakaœ wariacja typu sieæ paj¹ka (OK), nietoperze ( nieee )
 */

/*  Na pierwszym poziomie No Danger Zone Rooms

Pomieszczenia
0 SPAWN
1 Ogien
2 Insane
3 Gniew
4 Stracone Zaufanie oraz Próba ochrony 
5 Ci¹g³e próbowanie
6 Maska Emocjonalna

Próby ochrony
Stracone Zaufanie


Postaæ bij¹ca rêk¹ / g³ow¹ o mur
Powtarza frazy why / no / try / once more /
Po jakimœ czasie, bêdzie zmiana i postaæ przestaje biæ, mówi frazê " im done / mam doœæ "
pomieszczenie zmienia siê wtedy w Danger Zone

£añcuchy przykute do œciany, jeden ³añuch pêkniêty
Na ³añuchach s³owa DANGER/Niebezpieczeñstwo  Suppress/powstrzymaæ  control/opanowaæ
Pêkniêty ³añuch ma tekst Hello/Witaj. S³ychaæ wtedy odg³os ³añuchów za graczem, oraz pojawia siê wiêcej ³añcuchów

Maska emocjonalna
Jakieœ s³owa w pêtli
A ka¿da interakcja z mask¹ sprawia ¿e maska pêka coraz mocniej i zmienane s¹ kwestie dialogowe.
Po finalnej przemianie, wci¹¿ bêdzie interakcja, która niweluje ca³y Danger zone, jako nastêpna maska.
Dodaæ dŸwiêk pêkania w momencie zmian maski
Jakieœ szybkie tupoty w trakcie tekstów

Blizny i rany
Powieszone ostrza na œcianie
Zawalone elementy
Zniszczona i przewrócona donica z uschniêtym kwiatem
Mur z cegie³, który trzeba zniszczyæ ceg³a po cegle aby przejœæ do g³êbszej czêsci pomieszczenia ze zniszczonymi obiektami
I just wanted to lessen the burden. Be of help. Be Something.
Przed tym, s³owa brzmi¹
Dead weight. And a constant problem.
    scars and wounds cut too deep
    broken pieces left behind
    fake promises
    lies
    THats not in this room honestly - Opportiunites
    This too - CHALLENGES

Le¿¹ce ostrza na stole kamiennym. w iloœci 5/6
 */
/*
    Intro Scene pierwsza komnata ma tylko 1 whisper source
Jakieœ losowe dŸwiêki horrorowe mo¿e dodaæ ?
    Head Bang z³a œcie¿ka dialogowa
    Head Bang Poprawiæ start Danger Zone
    Mask Area Danger Zone siê nie neguje
zniszczone latarnie ?
postaæ czasem chodz¹ca korytarzami ze œwiat³em
pieczara z korzeniami ?
puzzle spadaj¹ce z nieba w Mask Area
Kolce
Po "ukoñczeniu" ka¿dego pomieszczenia, co jakiœ czas bêdzie grany dŸwiêk z niego. DŸwiêk ³añcuchów, bicia o œcianê,
pêkniêcia / œmiech z maski
 */
