using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#region KNOWN BUGS
/*
 Dialog Prompt Group stacks listeners if using on - End Showing Group EVENT
HeadBand fix lines
 */
#endregion


public class Language_English : LanguageBase
{
    public static Language_English Instance;
    public string[] text;
    string[] loadedText;
    public int levelID;

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
            //DontDestroyOnLoad(this);
        }

        LoadCorrectTexts();

    }

    void LoadCorrectTexts()
    {
        FillTextBase();
        FillNotes();
        switch(levelID)
        {
            case 1:
                FillTextScene1();
                break;
            case 2:
                FillTextScene2Remake2();
                break;
            case 3:
                FillTextScene3();
                break;
            default:
                break;
        }
    }
    void FillTextBase()
    {
        // UI Text
        loadedText = new string[100];
        loadedText[0] = "NO Text";
        loadedText[1] = "Start Game";
        loadedText[2] = "How To Play";
        loadedText[3] = "Options";
        loadedText[4] = "Exit Game";
        loadedText[5] = "Exit Game ?";
        loadedText[6] = "Yes";
        loadedText[7] = "No";
        loadedText[8] = "Music";
        loadedText[9] = "Sounds";
        loadedText[10] = "Full Screen";
        loadedText[11] = "Resolution";
        loadedText[12] = "FPS Cap";
        loadedText[13] = "Vsync";
        loadedText[14] = "Return";
        loadedText[15] = "Save and Exit";
        loadedText[16] = "Return without Saving";
        loadedText[17] = "Controls";
        loadedText[18] = "Movement";
        loadedText[19] = "Jump";
        loadedText[20] = "Interact";
        loadedText[21] = "Run";
        loadedText[22] = "Continue";
        loadedText[23] = "To Menu";
        loadedText[24] = "Language";
        loadedText[25] = "Choose Chapter";


        // INTERACTION Text
        loadedText[50] = "Touch";
        loadedText[51] = "Climb";
        loadedText[52] = "Look";
        loadedText[53] = "????";
        loadedText[54] = "Place";
        loadedText[55] = "Listen";
        loadedText[56] = "Sit";
        loadedText[57] = "Stand Up";
        loadedText[58] = "Open";
        loadedText[59] = "Close";
        loadedText[60] = "Kill";
        loadedText[61] = "Read";
        loadedText[62] = "Take";
        loadedText[63] = "Drop";
        loadedText[64] = "Put Back";
        loadedText[65] = "Place";
        loadedText[66] = "Talk";
        loadedText[67] = "Leave";

        // LEVEL NAMES
        loadedText[70] = "1-1 The Pit";
        loadedText[71] = "1-2 The Stillness";
        loadedText[72] = "1-3 The Unknown";

        loadedText[98] = "    ";
        loadedText[99] = "You're just an unexpected guest inside someones mind. Enjoy the journey and watch the story unfold.";

        for (int i = 0; i < 100; i++)
        {
            text[i] = loadedText[i];
        }
    }
    void FillTextScene1()
    {
        loadedText = new string[200];
        // Additional Texts
        loadedText[0] = "Press W to move Forward.";
        loadedText[1] = "? ? ?";


        // Erratic Thoughts Intro Scene
        loadedText[2] = "run";
        loadedText[3] = "join";
        loadedText[4] = "no time";
        loadedText[5] = "escape";
        loadedText[6] = "they are coming";
        loadedText[7] = "paralyzed";
        loadedText[8] = "help";
        loadedText[9] = "weak";
        loadedText[10] = "don't go";
        loadedText[11] = "give up";
        loadedText[12] = "i'm afraid";
        loadedText[13] = "can't take it anymore";
        loadedText[14] = "get lost";
        loadedText[15] = "disappear";
        loadedText[16] = "so cold";
        loadedText[17] = "it's too much";
        loadedText[18] = "no hope";
        loadedText[19] = "faster";
        loadedText[20] = "stay";
        loadedText[21] = "lose";
        loadedText[22] = "kill";
        loadedText[23] = "die";
        loadedText[24] = "cut";
        loadedText[25] = "memories";
        loadedText[26] = "remember";
        loadedText[27] = "hide";
        loadedText[28] = "avoid";
        loadedText[29] = "cornered";
        loadedText[30] = "defect";
        loadedText[31] = "meaningless";
        loadedText[32] = "jump";

        loadedText[40] = "Hello";
        //loadedText[141] = "Nice to meet you";
        loadedText[41] = "let me be your guide.";
        //loadedText[142] = "Could you do me a little favour ?";
        loadedText[42] = "Stop HoLdiNg back";
        //loadedText[143] = "Staywith me a bit longer.";
        //loadedText[43] = "Crush their bones beneath your feet";
        loadedText[43] = "GIVE IN TO YOUR NATURE";
        loadedText[44] = "GET BACK HERE !!!";

        loadedText[50] = "Danger";
        loadedText[51] = "Suppress";
        loadedText[52] = "Control";

        loadedText[60] = "No";
        loadedText[61] = "Try";
        loadedText[62] = "once more";
        loadedText[63] = "im done";


        // Just of what am i so afraid ?
        loadedText[70] = "Just what am i afraid of ?!";
        loadedText[71] = "Life passing me by?";
        loadedText[72] = "This is all just a breeze";

        // Life Goes by, just deal with it
        loadedText[75] = "The river of time dictates the road we walk on";
        loadedText[76] = "All we can do is follow along.";
        loadedText[77] = "Follow ... And belive there is something more.";

        // Things happen, but its just a small setback
        loadedText[80] = "Some things are set in stone.";
        loadedText[81] = "But we are the ones thrown into the water.";
        loadedText[82] = "There are still things that we can decide for ourselves.";

        // Life is no small setback. It is a setback
        loadedText[85] = "I don't know where to put my trust anymore.";
        loadedText[86] = "Everything i believed in fell apart.";
        loadedText[87] = "Or maybe it fell into the right place ?";
        loadedText[88] = "Like the puzzle pieces created for such an occasion.";

        // Life is but a stepping stone
        loadedText[90] = "sOMeOnE daReS tO TrY me ?";
        loadedText[91] = "ME ?!";
        loadedText[92] = "To even have the aUDacItY !";
        loadedText[93] = "Interesting . . .";

        loadedText[95] = "Just what am i so afraid of?";
        loadedText[96] = "Life Goes by. Just deal with it";
        loadedText[97] = "Things happen. Move.";
        loadedText[98] = "got stuck. without options.";
        //loadedText[99] = "Life is just a stepping stone.";
        loadedText[99] = "Just stepping stones. Nothing more.";

        loadedText[100] = "There is a name engraved on each of the blades.";
        loadedText[101] = "Break  ( E )";

        // Mask Erratic Words
        loadedText[110] = "Join us";
        loadedText[111] = "Dont leave";
        loadedText[112] = "Dont run";
        loadedText[113] = "Smile";
        loadedText[114] = "Hide";
        loadedText[115] = "Change";
        loadedText[116] = "Enjoy";
        loadedText[117] = "Faster";
        loadedText[118] = "Think";
        loadedText[119] = "Decide";

        // Chair Erratic Words
        loadedText[130] = "To be implemented";


        for (int i = 0; i < 200; i++)
        {
            text[i+300] = loadedText[i];
        }
    }
    void FillTextScene2()
    {
        text[100] = "Won't even budge";

        // SCENE 02

        Debug.LogError("CROW LINES NEED FIXING");

        // Crow Random Lines
        text[110] = "FIND IT !!!";  // Spawn
        text[111] = "FORGET !!!";   // Near Old Spawn
        text[112] = "Why";          // Pillars
        text[113] = "Soon";         // Motionless Pillars
        text[114] = "Lost . . .";   // Bridge
        text[115] = "alone";        // Dead
        text[116] = "end this";     // Hole
        text[117] = "failed";       // Altar
        text[118] = "no more reasons";          // Altar
        text[119] = "all is lost";  // Altar
        text[120] = "last . . . request";       // Pair
        text[121] = "erase . . . existence";    // Pair
        text[122] = "Leave.";       // Road
        text[123] = "leave it";     // Road
        text[124] = "the cycle repeats";        // Road
        text[125] = "you're a fool";            // Road
        text[126] = "no effort";    // Road
        text[127] = "lies";         // Road / Lore
        text[128] = "It feels like I'm the last one";   // Dialog
        text[129] = "The collapse is inevitable";       // Dialog
        text[130] = "Find the road";                    // Dialog
        text[131] = "Fear";
        text[132] = "tired";
        text[133] = "please, leave";
        text[134] = "wasted effort";    // Door


        // Bench Thoughts
        text[150] = "what is my purpose";
        text[151] = "what is wrong with me";
        text[152] = "was that supposed to happen ?";
        text[153] = "its better to just . . .";


        // On Interactions
        text[160] = "Place spark";
        text[161] = "Take spark";
        text[162] = "Held together by what exactly ?";
        text[163] = "As if . . . the time stopped";
        text[164] = "something is missing here";
        text[165] = "No one knows what's on the other side";
        text[166] = "Take Dagger";

        // Lore Drop
        text[170] = "A silent world.";
        text[171] = "A world where things just stopped.";
        text[172] = "Not because of some cataclysm.";
        text[173] = "Not because of abandonment.";
        text[174] = "But because of the damage.";
        text[175] = "Damage dealt by others";
        text[176] = "things not considered properly";
        text[177] = "decisions made by people who won't give second thought a chance";
        text[178] = "actions made without a feeling of consequence.";

        text[179] = "Welcome.";
        text[180] = "The world before your eyes is the one, some might say is beyond repair.";
        text[181] = "The world doomed to fail.";
        text[182] = "And yet. Here you stand. ";
        text[183] = "Trying to make things right. Trying to fix this shithole. ";
        text[184] = "Good Luck. Because i couldn't.";

        text[185] = "So yeah, a world where things just stay.";
        text[186] = "Just the way they were left.";
        text[187] = "For someone to pickup. Just for a convenience.";
        text[188] = "Like a random shiny peeble on a road.";
        text[189] = "A plant that hasn't been watered for god knows how many days just begging for some rain.";
        text[190] = "Just trying to survive, trying to be itself.";
        text[191] = "But there is no rain coming.";
        text[192] = "Nothing that may correct the course of actions.";
        text[193] = "All that is left is just waiting for the time to come. ";
        text[194] = "All the hope you may have had is lost.";
        text[195] = "Welcome to this world.";

        text[196] = "You want some advice ?";
        text[197] = "Go and find your own spark of hope.";
        text[198] = "Who knows, maybe a door to the better future will open itself before you.";
        text[198] = "Who knows, maybe that damn door will finally open.";

        text[199] = "You already made some progress on your own i see.";

        text[200] = "Ahhh, I can already tell that you found what was missing.";
        text[201] = "Now you can hear them clearly, right ?";
        text[202] = "Ohhh, how i missed the silence.";
        text[203] = "Now you're in charge.";
        text[204] = "Thanks for freeing me from this burden.";

        text[205] = "If you have no idea what to do, i can try to help you.";
        text[206] = "First . . . Have you tried listening to them at least ?";
        text[207] = "Who knows, maybe you will learn something useful ?";


        // Past Self continued Talk
        text[209] = "Been busy, huh ?";

        text[210] = "And ? Did you learn anything of value ?";
        text[211] = "Not much i guess";
        text[212] = "You know what they say.";
        text[213] = "There will be no change when the environment stays the same.";
        text[214] = "      ";
        text[215] = "You may find some use for this i think."; // Hands a knife to the player

        // After First Crow Killed
        text[220] = "Do what you have to.";
        // After 3 Crows Killed
        text[221] = "I hope its worth it.";
        text[225] = "A few are still alive.";
        // Crow location hints
        text[230] = "One might be near the ruined room. The one you came from.  THIS NEEDS FIXING";
        text[231] = "Those three pillars with one suspended in the air. How about searching there ?";
        text[232] = "There used to be a bridge somewhere around here. ";
        text[233] = "Have you visited the one guarding the dead pile ?";
        text[234] = "There is a crow near the hole. At least there always was.";
        text[235] = "What about the talkative one near the doors ?";
        text[236] = "There might be silent one near the doors.";
        text[237] = "Have you seen the one excluded from the temple standing on a rock ?";
        text[238] = "How about the lovely pair on a tree ?";
        text[239] = "How about the lovely pair on a tree ?";
        text[240] = "Have you searched the road properly ? I belive one should still be there.";
        text[241] = "Cross section of the riverbed is a home to one of them. ";
        text[242] = "One should be somewhere close. Always watching.";

        text[250] = "I think you got all of them.";
        text[251] = "Now it really is a still world.";
        text[252] = "What a blissfull emptiness. Peace.";
        text[253] = "Like a sign of the approaching end";
        text[254] = "Ever so slowly. Baring its fangs. Creeping around the corner.";
        text[255] = "Considering the state Im in.";
        text[256] = "Will you let me finally rest ?"; // Enable Kill Interaction


        // Insulting Crow 8 Pillars Crows
        text[280] = "You know what i always think when i look at you ?";
        text[281] = "That you're just a defect.";
        text[282] = "Defect on history pages. Meant to be erased.";
        text[283] = "Forgotten";
        text[284] = "Like a careless pencil mark in a sketchbook.";
        text[285] = "Keep that in your tiny mind.";

        // Insulting Crow 7 MotionLess Pillars Crows
        text[290] = "Took you long enough to get here.";
        text[291] = "Why are you always this slow ?";
        text[292] = "Is it because you're tired ?";
        text[293] = "Get a grip on yourself.";
        text[294] = "You bring nothing but shame.";
        text[295] = "You deserve all these things. Thats your well earned reward.";
        text[296] = "Come on. Enjoy yourself. What's stopping you ?";

        // Insulting Crow 10 Broken Bridge Crow
        text[300] = "You need to start accepting facts.";
        text[301] = "You chose all of this.";
        text[302] = "Every event is the result of your own inability";
        text[303] = "And you even chose to escape from the problems.";
        text[304] = "Bury them down and forget.";
        text[305] = "How classic of you.";

        // Insulting Crow 3 Dead Crows
        text[310] = "Do you see that pile of corpses over there ?";
        text[311] = "Why won't you just lie there and die";
        text[312] = "No one's gonna notice";
        text[313] = "You were never meant to exist anyway";
        text[314] = "Accept that.";

        // Insulting Crow 2 Hole Crow
        text[320] = "What are you even trying to accomplish here ?";
        text[321] = "Give Up.";
        text[322] = ".  .  .                           ";
        text[323] = "Can't you understand what i just said ?";
        text[324] = "GIVE UP";
        text[325] = "Do me a favour and end this facade.";
        text[326] = "No one wants you doing any of these things.";

        // Insulting Crow 12 Temple Crow 1
        text[330] = "The harder you fight the more you lose";
        text[331] = "In the end, you will end up all alone";
        text[332] = "Embrace it";
        text[333] = "Isn't that what you always dreamed of ?";

        // Insulting Crow 13 Temple Crow 2
        text[340] = "Hope cannot be eluded forever";
        text[341] = "At some point, you will just stop.";
        text[342] = "Stop and wonder what's the point";
        text[343] = "Finally realize there is no reason to even try.";
        text[344] = "You will remember my words then.";


        // Insulting Crow 1  APPLIED
        text[350] = "pathetic";
        text[351] = "you thought it will be that easy ?";
        text[352] = "just find that little spark in yourself";
        text[353] = "then everything will surely work out";
        text[354] = "a few more steps and everything will be great";
        text[355] = "keep going, believe in yourself";
        text[356] = "Don't make me laugh";
        text[357] = "you knew it will never work";
        text[358] = "might as well burn this whole place down and start from scratch";

        // Insulting Crow 4 Pair Crows 1
        text[360] = "Whom do we have here ?";
        text[361] = "The long awaited savior!";
        text[362] = "The one destinied to make things right!";
        text[363] = "savior my ass";
        text[364] = "Look at yourself";
        text[365] = "Someone like you, accomplishing anything ?";
        text[366] = "What a joke";

        // Insulting Crow 6 Pair Crows 2
        text[370] = "HahAhAhaHAha";
        text[371] = "Thats a good one!";
        text[372] = "Where did such a clown like you appear from ?";
        text[373] = "Garbagepile ?";
        text[374] = "Where else such good for nothing being would be ?";
        text[375] = "I can't wait to see you break.";
        text[376] = "Fight for your life !";
        text[377] = "Come on, For fun !";
        text[378] = "let's see you cry";

        // Insulting Crow 9 Road Crow
        text[380] = "Do you intend to put any effort into that ?";
        text[381] = "All i see is you just walking around";
        text[382] = "As if you dont know what to do at all";
        text[383] = "How dumb can you really be ?";

        // Insulting Crow 5 Dialog Crow
        text[390] = "Are you done ?";
        text[391] = "Stop being delusional";
        text[392] = "You never did anything right.";
        text[393] = "What makes you think, you can do it now ?";
        text[394] = "You will never make it. Trust me on that.";

        // Insulting Crow 11 Lore Crow
        text[400] = "It was obvious from the start";// Self fulfilling Prophecy
        text[401] = "You are a Self fulfilling prophecy";
        text[402] = "You cannot change what was already set in stone.";
        text[403] = "All your efforts are pointless.";
        text[404] = "Just like with a child . . .";


        // Dialog with Self
        text[450] = "You need anything ?";
        text[451] = "What is going on ?";// Dialog Option
        text[452] = "Nothing as you can see.";
        text[453] = "Look around you. Things stopped moving.";
        text[454] = "Could you give me some clues ?";

    }

    void FillTextScene3()
    {
        loadedText = new string[300];
        loadedText[0] = "The Path";
        loadedText[1] = "The Choice";
        loadedText[2] = "Give Up";
        loadedText[3] = "Be";
        loadedText[4] = "Light Up";

        loadedText[10] = "What is this place ?";
        loadedText[11] = "Who Am I ?";
        loadedText[12] = "What's going on ?";

        // What is this place answer TP on edge towards well and look at it
        loadedText[15] = "This place used to be a past.";
        loadedText[16] = "Used to be a future.";
        loadedText[17] = "The beggining of everything.";
        loadedText[18] = "Now its just ... all that is left.";
        // Who Am I answer. TP near Pillar and lean on it
        loadedText[20] = "If you're so curious, why won't you ask yourself ?";
        loadedText[21] = "Face the one you try so hard to erase.";
        // What's going on answer. TP on edge and start moving legs
        loadedText[25] = "You got lost.";
        loadedText[26] = "Forgotten.";
       
        // Memory Well
        loadedText[30] = "The Last Known Destination";
        loadedText[31] = "A Well ???";   // Question
        loadedText[32] = "Yes.";
        loadedText[33] = "Things seem to vanish out of existence in contact with it though.";
        loadedText[34] = "Where did that come from ?";
        loadedText[36] = "Take Ribbon";
        loadedText[37] = "Throw Ribbon";
        loadedText[38] = "Take Watch";
        loadedText[39] = "Throw Watch";
        loadedText[40] = "Take Snow Globe";
        loadedText[41] = "Throw Snow Globe";
        loadedText[42] = "Take Hammer";
        loadedText[43] = "Throw Hammer";


        // Upside Memory Well
        loadedText[50] = "Pretty convenient isn't it ?";
        loadedText[51] = "Just erase everything that's bothersome and continue moving forward.";
        loadedText[52] = "It's so easy to treat everything like a spit on a ground.";
        loadedText[53] = "A meaningless interactions done only for the sake of peace.";
        loadedText[54] = "Actions not even worth remembering. Begone from your mind.";
        loadedText[55] = "In the end its just a bad memory right ? You're the victim here. ";

        // Rock Pushing
        loadedText[60] = "What's that rock ?";   // Question
        loadedText[61] = "There is some guy here trying to push it along the path.";
        loadedText[62] = "Don't ask me why, I'm as clueless as you. ";
        loadedText[63] = "How about we do a little prank, to brighten the mood, eh ?";
        loadedText[64] = "Lets loosen a few rocks somewhere up there.";
        loadedText[65] = "Just think about it, he's gonna fall flat on his face there wondering who did it to him.";
        loadedText[66] = "This seems like a spot !";
        loadedText[67] = "Aaaaaand done, now lets go and search for him!";   // Rocks Loosened
        loadedText[68] = "Loosen Rocks";

        loadedText[70] = "All actions have consequences. I'm surprised you got this far without realizing it.";
        loadedText[71] = "Ignored and left alone with impossible task to fulfill. What else did you expect ?"; // Ignored
        //loadedText[157] = "Left alone to deal with, what feels like impossible task? Ok, noted."; // Ignored
        loadedText[72] = "Was it a mercy or stupidity leading you with that choice ?"; // Killed
        //loadedText[158] = "Is that your idea of being merciful ? "; // Killed
        loadedText[73] = "Left with no purpose, just to rot and be forgotten. That's one way to go i guess. "; // Ball taken away
        //loadedText[159] = "Left with no purpose, just to rot and be forgotten. Noted."; // Ball taken away
        loadedText[74] = "I mean . . . The goal is fullfilled. But whose success is that really ?"; // Ball placed on the top
        //loadedText[160] = "The goal is fullfilled. But whose success is that really ?"; // Ball placed on the top


        loadedText[80] = "Throw Daggers";
        loadedText[81] = "Take Daggers";

        // Directions
        loadedText[90] = "Are you lost ?";
        loadedText[91] = "Or maybe you lost something ?";
        loadedText[92] = "Or maybe its the other way around ?";


        for (int i = 0; i < 200; i++)
        {
            text[i + 300] = loadedText[i];
        }
    }

    void FillTextScene2Remake()
    {
        text[100] = "Won't even budge";

        // SCENE 02

        Debug.LogError("CROW LINES NEED FIXING");

        // Crow Random Lines
        text[110] = "FIND IT !!!";  // Spawn
        text[111] = "FORGET !!!";   // Near Old Spawn
        text[112] = "Why";          // Pillars
        text[113] = "Soon";         // Motionless Pillars
        text[114] = "Lost . . .";   // Bridge
        text[115] = "alone";        // Dead
        text[116] = "end this";     // Hole
        text[117] = "failed";       // Altar
        text[118] = "no more reasons";          // Altar
        text[119] = "all is lost";  // Altar
        text[120] = "last . . . request";       // Pair
        text[121] = "erase . . . existence";    // Pair
        text[122] = "Leave.";       // Road
        text[123] = "leave it";     // Road
        text[124] = "the cycle repeats";        // Road
        text[125] = "you're a fool";            // Road
        text[126] = "no effort";    // Road
        text[127] = "lies";         // Road / Lore
        text[128] = "It feels like I'm the last one";   // Dialog
        text[129] = "The collapse is inevitable";       // Dialog
        text[130] = "Find the road";                    // Dialog
        text[131] = "Fear";
        text[132] = "tired";
        text[133] = "please, leave";
        text[134] = "wasted effort";    // Door


        // Bench Thoughts
        text[150] = "what is my purpose";
        text[151] = "what is wrong with me";
        text[152] = "was that supposed to happen ?";
        text[153] = "its better to just . . .";


        // On Interactions
        text[160] = "Place spark";
        text[161] = "Take spark";
        text[162] = "Held together by what exactly ?";
        text[163] = "As if . . . the time stopped";
        text[164] = "something is missing here";
        text[165] = "No one knows what's on the other side";
        text[166] = "Take Dagger";

        // Dialog
        text[200] = "You need anything ?";

        text[201] = "What is going on ?";// Dialog Option
        text[202] = "Nothing, as you can see.";
        text[203] = "Look around you. Things stopped moving.";

        text[204] = "Could you give me some clues ?";// Dialog Option
        text[206] = "You want some advice ?";
        text[207] = "Go and find something capable of moving this world.";
        text[208] = "Who knows, maybe that damn door will finally open.";

        // Lore Drop
        text[214] = "Tell me about this world."; // Dialog Option

        text[215] = "A silent world.";
        text[216] = "A world where things just stopped.";
        text[217] = "Not because of some cataclysm.";
        text[218] = "Not because of abandonment.";
        text[219] = "But because of the damage.";
        text[220] = "Damage dealt by others";
        text[221] = "things not considered properly";
        text[222] = "decisions made by people who won't give second thought a chance";
        text[223] = "actions made without a feeling of consequence.";

        text[224] = "Welcome.";
        text[225] = "The world before your eyes is the one, some might say is beyond repair.";
        text[226] = "A world doomed to fail.";
        text[227] = "And yet. Here you stand. ";
        text[228] = "Trying to make things right. Trying to fix this shithole. ";
        text[229] = "Good Luck. Because i couldn't.";

        text[230] = "So yeah, a world where things just stay.";
        text[231] = "Just the way they were left.";
        text[232] = "For someone to pickup. Just for a convenience.";
        text[233] = "Like a random shiny peeble on a road.";
        text[234] = "A plant that hasn't been watered for god knows how many days just begging for some rain.";
        text[235] = "Just trying to survive, trying to be itself.";
        text[236] = "But there is no rain coming.";
        text[237] = "Nothing that may correct the course of actions.";
        text[238] = "All that is left is just waiting for the time to come. ";
        text[239] = "All the hope you may have had is lost.";
        text[240] = "Welcome to this world.";

        text[250] = "I found this. Is that what you need ?";//Dialog Option
        text[251] = "Place it on the altar and see for yourself.";


        // Phase 2 Dialog

        text[255] = "Ahhh, I can already tell that you found what was missing.";
        text[256] = "Now you can hear them clearly, right ?";
        text[257] = "Ohhh, how i missed the silence.";

        text[260] = "Now what ?";// Dialog Option

        text[261] = "If you have no idea what to do next, i can try to help you.";
        text[262] = "First . . . Have you tried listening to them at least ?";
        text[263] = "Who knows, maybe you will learn something useful ?";

        text[270] = "And ? Did you hear anything of value ?";
        text[271] = "Not much i guess";
        text[272] = "You know what they say.";
        text[273] = "There will be no change when the environment stays the same.";
        text[274] = "      ";
        text[275] = "You may find some use for this i think."; // Hands a knife to the player


        for (int i = 0; i < 200; i++)
        {
            text[i + 300] = loadedText[i];
        }

        /*
        // Past Self continued Talk
        text[209] = "Been busy, huh ?";

        

        // After First Crow Killed
        text[220] = "Do what you have to.";
        // After 3 Crows Killed
        text[221] = "I hope its worth it.";
        text[225] = "A few are still alive.";
        // Crow location hints
        text[230] = "One might be near the ruined room. The one you came from.  THIS NEEDS FIXING";
        text[231] = "Those three pillars with one suspended in the air. How about searching there ?";
        text[232] = "There used to be a bridge somewhere around here. ";
        text[233] = "Have you visited the one guarding the dead pile ?";
        text[234] = "There is a crow near the hole. At least there always was.";
        text[235] = "What about the talkative one near the doors ?";
        text[236] = "There might be silent one near the doors.";
        text[237] = "Have you seen the one excluded from the temple standing on a rock ?";
        text[238] = "How about the lovely pair on a tree ?";
        text[239] = "How about the lovely pair on a tree ?";
        text[240] = "Have you searched the road properly ? I belive one should still be there.";
        text[241] = "Cross section of the riverbed is a home to one of them. ";
        text[242] = "One should be somewhere close. Always watching.";

        text[250] = "I think you got all of them.";
        text[251] = "Now it really is a still world.";
        text[252] = "What a blissfull emptiness. Peace.";
        text[253] = "Like a sign of the approaching end";
        text[254] = "Ever so slowly. Baring its fangs. Creeping around the corner.";
        text[255] = "Considering the state Im in.";
        text[256] = "Will you let me finally rest ?"; // Enable Kill Interaction


        // Insulting Crow 8 Pillars Crows
        text[280] = "You know what i always think when i look at you ?";
        text[281] = "That you're just a defect.";
        text[282] = "Defect on history pages. Meant to be erased.";
        text[283] = "Forgotten";
        text[284] = "Like a careless pencil mark in a sketchbook.";
        text[285] = "Keep that in your tiny mind.";

        // Insulting Crow 7 MotionLess Pillars Crows
        text[290] = "Took you long enough to get here.";
        text[291] = "Why are you always this slow ?";
        text[292] = "Is it because you're tired ?";
        text[293] = "Get a grip on your self.";
        text[294] = "You bring nothing but shame.";
        text[295] = "You deserve all these things. Thats your well earned reward.";
        text[296] = "Come on. Enjoy yourself. What's stopping you ?";

        // Insulting Crow 10 Broken Bridge Crow
        text[300] = "You need to start accepting facts.";
        text[301] = "You chose all of this.";
        text[302] = "Every event is the result of your own inability";
        text[303] = "And you even chose to escape from the problems.";
        text[304] = "Bury them down and forget.";
        text[305] = "How classic of you.";

        // Insulting Crow 3 Dead Crows
        text[310] = "Do you see that pile of corpses over there ?";
        text[311] = "Why won't you just lie there and die";
        text[312] = "No one's gonna notice";
        text[313] = "You were never meant to exist anyway";
        text[314] = "Accept that.";

        // Insulting Crow 2 Hole Crow
        text[320] = "What are you even trying to accomplish here ?";
        text[321] = "Give Up.";
        text[322] = ".  .  .                           ";
        text[323] = "Can't you understand what i just said ?";
        text[324] = "GIVE UP";
        text[325] = "Do me a favour and end this facade.";
        text[326] = "No one wants you doing any of these things.";

        // Insulting Crow 12 Temple Crow 1
        text[330] = "The harder you fight the more you lose";
        text[331] = "In the end, you will end up all alone";
        text[332] = "Embrace it";
        text[333] = "Isn't that what you always dreamed of ?";

        // Insulting Crow 13 Temple Crow 2
        text[340] = "Hope cannot be eluded forever";
        text[341] = "At some point, you will just stop.";
        text[342] = "Stop and wonder what's the point";
        text[343] = "Finally realize there is no reason to even try.";
        text[344] = "You will remember my words then.";


        // Insulting Crow 1  APPLIED
        text[350] = "pathetic";
        text[351] = "you thought it will be that easy ?";
        text[352] = "just find that little spark in yourself";
        text[353] = "then everything will surely work out";
        text[354] = "a few more steps and everything will be great";
        text[355] = "keep going, believe in yourself";
        text[356] = "Don't make me laugh";
        text[357] = "you knew it will never work";
        text[358] = "might as well burn this whole place down and start from scratch";

        // Insulting Crow 4 Pair Crows 1
        text[360] = "Whom do we have here ?";
        text[361] = "The long awaited savior!";
        text[362] = "The one destinied to make things right!";
        text[363] = "savior my ass";
        text[364] = "Look at yourself";
        text[365] = "Someone like you, accomplishing anything ?";
        text[366] = "What a joke";

        // Insulting Crow 6 Pair Crows 2
        text[370] = "HahAhAhaHAha";
        text[371] = "Thats a good one!";
        text[372] = "Where did such a clown like you appear from ?";
        text[373] = "Garbagepile ?";
        text[374] = "Where else such good for nothing being would be ?";
        text[375] = "I can't wait to see you break.";
        text[376] = "Fight for your life !";
        text[377] = "Come on, For fun !";
        text[378] = "let's see you cry";

        // Insulting Crow 9 Road Crow
        text[380] = "Do you intend to put any effort into that ?";
        text[381] = "All i see is you just walking around";
        text[382] = "As if you dont know what to do at all";
        text[383] = "How dumb can you really be ?";

        // Insulting Crow 5 Dialog Crow
        text[390] = "Are you done ?";
        text[391] = "Stop being delusional";
        text[392] = "You never did anything right.";
        text[393] = "What makes you think, you can do it now ?";
        text[394] = "You will never make it. Trust me on that.";

        // Insulting Crow 11 Lore Crow
        text[400] = "It was obvious from the start";// Self fulfilling Prophecy
        text[401] = "You are a Self fulfilling prophecy";
        text[402] = "You cannot change what was already set in stone.";
        text[403] = "All your efforts are pointless.";
        text[404] = "Just like with a child . . .";

        */


    }
    void FillTextScene2Remake2()
    {
        loadedText = new string[500];

        loadedText[0] = "Won't even budge";

        // SCENE 02

        Debug.LogError("CROW LINES NEED FIXING");

        // Crow Random Lines
        loadedText[10] = "FIND IT !!!";  // Spawn
        loadedText[11] = "FORGET !!!";   // Near Old Spawn
        loadedText[12] = "Why";          // Pillars
        loadedText[13] = "Soon";         // Motionless Pillars
        loadedText[14] = "Lost . . .";   // Bridge
        loadedText[15] = "alone";        // Dead
        loadedText[16] = "end this";     // Hole
        loadedText[17] = "failed";       // Altar
        loadedText[18] = "no more reasons";          // Altar
        loadedText[19] = "all is lost";  // Altar
        loadedText[20] = "last . . . request";       // Pair
        loadedText[21] = "erase . . . existence";    // Pair
        loadedText[22] = "Leave.";       // Road
        loadedText[23] = "leave it";     // Road
        loadedText[24] = "the cycle repeats";        // Road
        loadedText[25] = "you're a fool";            // Road
        loadedText[26] = "no effort";    // Road
        loadedText[27] = "lies";         // Road / Lore
        loadedText[28] = "It feels like I'm the last one";   // Dialog
        loadedText[29] = "The collapse is inevitable";       // Dialog
        loadedText[30] = "Find the road";                    // Dialog
        loadedText[31] = "Fear";
        loadedText[32] = "tired";
        loadedText[33] = "please, leave";
        loadedText[34] = "wasted effort";    // Door


        // Bench Thoughts
        loadedText[50] = "what is my purpose";
        loadedText[51] = "what is wrong with me";
        loadedText[52] = "was that supposed to happen ?";
        loadedText[53] = "its better to just . . .";


        // On Interactions
        loadedText[60] = "Place spark";
        loadedText[61] = "Take spark";
        loadedText[62] = "Held together by what exactly ?";
        loadedText[63] = "As if . . . the time stopped";
        loadedText[64] = "something is missing here";
        loadedText[65] = "No one knows what's on the other side";
        loadedText[66] = "Take Dagger";

        // Dialog
        loadedText[100] = "You need anything ?";

        loadedText[101] = "What is going on ?";// Dialog Option
        loadedText[102] = "Nothing, as you can see.";
        loadedText[103] = "Look around you. Things stopped.";

        loadedText[104] = "Could you give me some clues ?";// Dialog Option
        loadedText[106] = "You want some advice ?";
        loadedText[107] = "Go and find something capable of moving this world.";
        loadedText[108] = "Who knows, maybe that damn door will finally open.";

        // Lore Drop
        loadedText[114] = "Tell me about this world."; // Dialog Option

        loadedText[115] = "A silent world.";
        loadedText[116] = "A world where things just stopped.";
        loadedText[117] = "Not because of some cataclysm.";
        loadedText[118] = "Not because of abandonment.";
        loadedText[119] = "But because of the damage.";
        loadedText[120] = "Damage dealt by others";
        loadedText[121] = "things not considered properly";
        loadedText[122] = "decisions made by people who won't give second thought a chance";
        loadedText[123] = "actions made without a feeling of consequence.";

        loadedText[124] = "Welcome.";
        loadedText[125] = "The world before your eyes is the one, some might say is beyond repair.";
        loadedText[126] = "A world doomed to fail.";
        loadedText[127] = "And yet. Here you stand. ";
        loadedText[128] = "Trying to make things right. Trying to fix this shithole. ";
        loadedText[129] = "Good Luck. Because i couldn't.";

        loadedText[130] = "So yeah, a world where things just stay.";
        loadedText[131] = "Just the way they were left.";
        loadedText[132] = "For someone to pickup. Just for a convenience.";
        loadedText[133] = "Like a random shiny peeble on a road.";
        loadedText[134] = "A plant that hasn't been watered for god knows how many days just begging for some rain.";
        loadedText[135] = "Just trying to survive, trying to be itself.";
        loadedText[136] = "But there is no rain coming.";
        loadedText[137] = "Nothing that may correct the course of actions.";
        loadedText[138] = "All that is left is just waiting for the time to come. ";
        loadedText[139] = "All the hope you may have had is lost.";
        loadedText[140] = "Welcome to this world.";

        loadedText[150] = "I found something like this?";//Dialog Option
        loadedText[151] = "Place it on the altar and see for yourself.";


        // Phase 2 Dialog

        loadedText[155] = "Ahhh, I can already tell that you found what was missing.";
        loadedText[156] = "Now you can hear them clearly, right ?";
        loadedText[157] = "Ohhh, how i missed the silence.";

        loadedText[160] = "Now what ?";// Dialog Option

        loadedText[161] = "If you have no idea what to do next, i can try to help you.";
        loadedText[162] = "First . . . Have you tried listening to them at least ?";
        loadedText[163] = "Who knows, maybe you will learn something useful ?";

        loadedText[170] = "And ? Did you hear anything of value ?";
        loadedText[171] = "Not much i guess";
        loadedText[172] = "You know what they say.";
        loadedText[173] = "There will be no change when the environment stays the same.";
        loadedText[174] = "      ";
        loadedText[175] = "You may find some use for this i think."; // Hands a knife to the player

        // After First Crow Killed
        loadedText[180] = "Do what you have to.";
        // After 3 Crows Killed
        loadedText[181] = "I hope its worth it.";

        // Tip to location
        loadedText[200] = "One might be near the ruined room. The one you came from.  THIS NEEDS FIXING";
        loadedText[201] = "Those three pillars with one suspended in the air. How about searching there ?";
        loadedText[202] = "There used to be a bridge somewhere around here. ";
        loadedText[203] = "Have you visited the one guarding the dead pile ?";
        loadedText[204] = "There is a crow near the hole. At least there always was.";
        loadedText[205] = "What about the talkative one near the doors ?";
        loadedText[206] = "There might be silent one near the doors.";
        loadedText[207] = "Have you seen the one excluded from the temple standing on a rock ?";
        loadedText[208] = "How about the lovely pair on a tree ?";
        loadedText[209] = "How about the lovely pair on a tree ?";
        loadedText[210] = "Have you searched the road properly ? I belive one should still be there.";
        loadedText[211] = "Cross section of the riverbed is a home to one of them. ";
        loadedText[212] = "One should be somewhere close. Always watching.";

        
        loadedText[220] = "I think that's all of them . . . ";
        loadedText[221] = "What a blissfull emptiness. Peace.";
        loadedText[222] = "Like a sign of the approaching end";
        loadedText[223] = "Ever so slowly. Baring its fangs. Creeping around the corner."; // Enable Kill Interaction

        loadedText[225] = "Can't bring yourself to do it ?";
        loadedText[226] = "Pathetic";
        loadedText[227] = "Get on with it";
        //loadedText[222] = "Now it really is a still world.";
        //loadedText[225] = "Considering the state Im in.";
        //loadedText[226] = "Will you let me finally rest ?"; // Enable Kill Interaction



        // Insulting Crow 8 Pillars Crows
        loadedText[250] = "You know what i always think when i look at you ?";
        loadedText[251] = "That you're just a defect.";
        loadedText[252] = "Defect on history pages. Meant to be erased.";
        loadedText[253] = "Forgotten";
        loadedText[254] = "Like a careless pencil mark in a sketchbook.";
        loadedText[255] = "Keep that in your tiny mind.";

        // Insulting Crow 7 MotionLess Pillars Crows
        loadedText[260] = "Took you long enough to get here.";
        loadedText[261] = "Why are you always this slow ?";
        loadedText[262] = "Is it because you're tired ?";
        loadedText[263] = "Get a grip on your self.";
        loadedText[264] = "You bring nothing but shame.";
        loadedText[265] = "You deserve all these things. Thats your well earned reward.";
        loadedText[266] = "Come on. Enjoy yourself. What's stopping you ?";

        // Insulting Crow 10 Broken Bridge Crow
        loadedText[270] = "You need to start accepting facts.";
        loadedText[271] = "You chose all of this.";
        loadedText[272] = "Every event is the result of your own inability";
        loadedText[273] = "And you even chose to escape from the problems.";
        loadedText[274] = "Bury them down and forget.";
        loadedText[275] = "How classic of you.";

        // Insulting Crow 3 Dead Crows
        loadedText[280] = "Do you see that pile of corpses over there ?";
        loadedText[281] = "Why won't you just lie there and die";
        loadedText[282] = "No one's gonna notice";
        loadedText[283] = "You were never meant to exist anyway";
        loadedText[284] = "Accept that.";

        // Insulting Crow 2 Hole Crow
        loadedText[290] = "What are you even trying to accomplish here ?";
        loadedText[291] = "Give Up.";
        loadedText[292] = ".  .  .                           ";
        loadedText[293] = "Can't you understand what i just said ?";
        loadedText[294] = "GIVE UP";
        loadedText[295] = "Do me a favour and end this facade.";
        loadedText[296] = "No one wants you doing any of these things.";

        // Insulting Crow 12 Temple Crow 1
        loadedText[300] = "The harder you fight the more you lose";
        loadedText[301] = "In the end, you will end up all alone";
        loadedText[302] = "Embrace it";
        loadedText[303] = "Isn't that what you always dreamed of ?";

        // Insulting Crow 13 Temple Crow 2
        loadedText[310] = "Hope cannot be eluded forever";
        loadedText[311] = "At some point, you will just stop.";
        loadedText[312] = "Stop and wonder what's the point";
        loadedText[313] = "Finally realize there is no reason to even try.";
        loadedText[314] = "You will remember my words then.";


        // Insulting Crow 1  APPLIED
        loadedText[320] = "pathetic";
        loadedText[321] = "you thought it will be that easy ?";
        loadedText[322] = "just find that little spark";
        loadedText[323] = "then everything will surely work out";
        loadedText[324] = "a few more steps and everything will be great";
        loadedText[325] = "keep going, believe in yourself";
        loadedText[326] = "Don't make me laugh";
        loadedText[327] = "you knew it will never work";
        loadedText[328] = "might as well burn this whole place down and start from scratch";

        // Insulting Crow 4 Pair Crows 1
        loadedText[330] = "Whom do we have here ?";
        loadedText[331] = "The long awaited savior!";
        loadedText[332] = "The one destinied to make things right!";
        loadedText[333] = "savior my ass";
        loadedText[334] = "Look at yourself";
        loadedText[335] = "Someone like you, accomplishing anything ?";
        loadedText[336] = "What a joke";

        // Insulting Crow 6 Pair Crows 2
        loadedText[340] = "HahAhAhaHAha";
        loadedText[341] = "Thats a good one!";
        loadedText[342] = "Where did such a clown like you appear from ?";
        loadedText[343] = "Garbagepile ?";
        loadedText[344] = "Where else such good for nothing being would be ?";
        loadedText[345] = "I can't wait to see you break.";
        loadedText[346] = "Fight for your life !";
        loadedText[347] = "Come on, For fun !";
        loadedText[348] = "let's see you cry";

        // Insulting Crow 9 Road Crow
        loadedText[350] = "Do you intend to put any effort into that ?";
        loadedText[351] = "All i see is you just walking around";
        loadedText[352] = "As if you dont know what to do at all";
        loadedText[353] = "How dumb can you really be ?";

        // Insulting Crow 5 Dialog Crow
        loadedText[360] = "Are you done ?";
        loadedText[361] = "Stop being delusional";
        loadedText[362] = "You never did anything right.";
        loadedText[363] = "What makes you think, you can do it now ?";
        loadedText[364] = "You will never make it. Trust me on that.";

        // Insulting Crow 11 Lore Crow
        loadedText[370] = "It was obvious from the start";// Self fulfilling Prophecy
        loadedText[371] = "You are a Self fulfilling prophecy";
        loadedText[372] = "You cannot change what was already set in stone.";
        loadedText[373] = "All your efforts are pointless.";
        loadedText[374] = "Just like with a child . . .";


        for (int i = 0; i < 500; i++)
        {
            text[i + 300] = loadedText[i];
        }



    }
    void FillNotes()
    {
        loadedText = new string[200];
        // 200 linijek na Notatki wystarczyæ powinno
        // Note Lore Drop
        loadedText[0] = "A silent world.";
        loadedText[1] = "A world where things just stopped.";
        loadedText[2] = "Not because of some cataclysm.";
        loadedText[3] = "Not because of abandonment.";
        loadedText[4] = "But because of the damage.";
        loadedText[5] = "Damage dealt by others";   // Knives pick up interaction
        loadedText[6] = "things not considered properly";
        loadedText[7] = "decisions made by people who won't give second thought a chance";
        loadedText[8] = "actions made without a feeling of consequence.";   // Scene 3 rock pushing any interaction
        loadedText[9] = "The world before your eyes is the one, some might say is beyond repair.";
        loadedText[10] = "A world doomed to fail.";
        loadedText[11] = "And yet. Here you stand. ";
        loadedText[12] = "Trying to make things right. Trying to fix this shithole. ";
        loadedText[13] = "A world where things just stay.";
        loadedText[14] = "Just the way they were left.";
        loadedText[15] = "For someone to pickup. Just for a convenience.";
        loadedText[16] = "Like a random shiny peeble on a road.";
        loadedText[17] = "A plant that hasn't been watered for god knows how many days just begging for some rain.";
        loadedText[18] = "Just trying to survive, trying to be itself.";
        loadedText[19] = "But there is no rain coming.";
        loadedText[20] = "All that is left is just waiting for the time to come. ";
        loadedText[21] = "All the hope you may have had is lost.";

        for (int i = 0; i < 200; i++)
        {
            text[i+100] = loadedText[i];
        }
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
Zwê¿yæ pomieszczenie z maskami, ³atwiej bêdzie wype³niæ ca³oœæ przyt³¹czaj¹c¹ logiczn¹ iloœci¹ masek
 */

/* Scena 2 Miejsca losowych aktywacji 

Maski       Dead Crows
£añcuchy    Lore Drop
Kolce       The Road
Bloki       Broken Bridge

 */

/* Scena 3
Ka¿da wyspa bêdzie obracalna ukazuj¹ca ciemn¹ stronê ka¿dego fragmentu
03 Memory Well
04 Rock Pushing ( kamieñ zostawiony na œrodku drogi )
05 



Na koniec bêdzie minigierka aby po³¹czyæ ze sob¹ wszystkie wyspy.
Bêdzie miniaturowa wersja ka¿dej wyspy i bêdzie trzeba j¹ przeci¹gn¹æ w odpowiednie miejsce. Gdy bêdzie blisko odpowiedniego miejsca
puszczone, wyspa sama doleci w wyznaczone miejsce i zablokowana zostanie mo¿liwoœæ jej ruchu.
Co jakiœ czas bêdzie widaæ kruka siedz¹cego na drzewie lub lataj¹cego w oddali.

    Memory Well
IDEAS WE NEED IDEAS!!!
The point of no return. The void. The easy way. The last stop / seen. The last known destination
Zbieranie obiektów na wyspie i wrzucanie ich do studni ? Raczej nie
Coœ symbolizuj¹ce utracone wspomnienia. Rysunki z brakujacymi elementami ?
Jakieœ skrawki tekstu z brakuj¹cymi fragmentami.
Jakiœ obiekt który mo¿na wrzuciæ do studni, ale wczeœniej bêdzie kartka czy coœ do podniesienia z tym elementem.
Po podniesieniu bêdzie dodany do dziennika. Po wrzuceniu obiekt zniknie z tego wpisu. 

Rock Pushing
Napotyka siê kamieñ na drodze.



Plan ?
Siedzi postaæ na pocz¹tku, mo¿na podejœæ i zainicjowaæ rozmowê.
Zale¿nie od wybranej opcji postaæ teleportuje siê w jakieœ miejsce, jest jakiœ efekt particle, zaczyna mówiæ oraz jest jakaœ animacja

Porozrzucaæ lewituj¹ce kamienie / wyspy wokó³ g³ównych
 */
/* Scena 1 Dzwieki do pobrania
 Œmiech do maski
Creepy œmiech ?
Usczupliæ dialogi w scenie 02
Popracowaæ nad scen¹ 01
 */
/* Ekwipunek /Dziennik
Sposób dzia³ania :
Wciœniêcie I pokazuje znalezione przedmioty. 
Nie bêdzie ich du¿o na pewno. Krótka wskazówka o przedmiocie, oraz jakaœ miniatura
Przedmioty pomiêdzy kartkami ksi¹¿ki ?

Wciœniêcie J pokazuje dziennik.
W dzienniku umieszczone bêd¹ znalezione kartki oraz wa¿ne wpisy na temat historii ?


 */
/* Mo¿liwe zmiany w pierwszej scenie
Jakieœ zniszczone obiekty w Chains Zone
    Oczy od pocz¹tku widoczne w Chair Zone
Co zrobiæ z headbang ? 
Jakieœ nieudane rzeŸby na ma³ych filarach, coœ niedokoñczonego, 
    Pionowa œciana w któr¹ bije g³ow¹
Inne teksty lataj¹ce po ekranie w chain zone ?
Innte teksty latajaæe po ekranie w mask zone ?
 */

/* 
ROad crow no crow LEAVE IT
Motionless pillars fix event
hole disable interaction on crow
 */

/*
 Lore drop w formie znajdywalnych kawa³ków tekstu, czynnoœci wykonanych, akcji w œwiecie.
Rozci¹gaæ siê to bêdzie przez kilka scen.
Ostrza w intro bêdzie mo¿na wzi¹æ.
Roslina bêdzie dawa³a jeden tekst do lore
 */
