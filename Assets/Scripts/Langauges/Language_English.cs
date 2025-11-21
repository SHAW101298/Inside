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
        switch(levelID)
        {
            case 1:
                FillTextScene1();
                break;
            case 2:
                FillTextScene2();
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
        text[50] = "Touch";
        text[51] = "Climb";
        text[52] = "Look";
        text[53] = "????";
        text[54] = "Place";
        text[55] = "Listen";
        text[56] = "Sit";
        text[57] = "Stand Up";
        text[58] = "Open";
        text[59] = "Close";
        text[60] = "Kill";
        text[61] = "Read";
        text[62] = "Take";
        text[63] = "Drop";
        text[64] = "Put Back";


        // LEVEL NAMES
        text[70] = "1-1 The Pit";
        text[71] = "1-2 The Stillness";
        text[72] = "1-3 The Unknown";

        text[99] = "You're just an unexpected guest inside someones mind. Enjoy the journey and watch the story unfold.";
    }
    void FillTextScene1()
    {
        Debug.LogError("FIx HeadBang Lines");
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

        text[200] = "There is a name engraved on each of the blades.";
        text[201] = "Break  ( E )";
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
        text[160] = "Place - Spark  ( E )";
        text[161] = "Take - Spark  ( E )";
        text[162] = "Held together by what exactly ?";
        text[163] = "As if . . . the time stopped";
        text[164] = "something is missing here";
        text[165] = "No one knows what's on the other side";
        text[166] = "Take - Dagger  ( E )";


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

    }

    void FillTextScene3()
    {
        text[100] = "The Path";
        text[101] = "The Choice";
        text[102] = "Give Up";
        text[103] = "Be";

        text[110] = "What is this place ?";
        text[111] = "Who Am I ?";
        text[112] = "What's going on ?";

        // What is this place answer TP on edge towards well and look at it
        text[115] = "This place used to be a past.";
        text[116] = "Used to be a future.";
        text[117] = "The beggining of everything.";
        text[118] = "Now its just ... all that is left.";
        // Who Am I answer. TP near Pillar and lean on it
        text[120] = "If you're so curious, why won't you ask yourself ?";
        text[121] = "Face the one you try so hard to erase.";
        // What's going on answer. TP on edge and start moving legs
        text[125] = "You got lost.";
        text[126] = "Forgotten.";
       
        // Memory Well
        text[130] = "The Last Known Destination";
        text[131] = "A Well ???";   // Question
        text[132] = "Yes.";
        text[133] = "Things seem to vanish out of existence in contact with it though.";
        text[134] = "Where did that come from ?";
        text[136] = "Take Ribbon";
        text[137] = "Throw Ribbon";

        // Upside Memory Well
        text[140] = "Pretty convenient isn't it ?";
        text[141] = "Just erase everything that's bothersome and continue moving forward.";
        text[142] = "It's so easy to treat everything like a spit on a ground.";
        text[143] = "A meaningless interactions done only for the sake of peace.";
        text[144] = "Actions not even worth remembering. Begone from your mind.";
        text[145] = "In the end its just a bad memory right ? You're the victim here. ";

        // Rock Pushing
        text[150] = "What's that rock ?";   // Question
        text[151] = "There is some guy here trying to push it off the edge. Don't ask me why, I'm as clueless as you. ";
        text[152] = "How about we do a little prank, to brighten the mood, eh ? Lets loosen a few rocks somewhere up there.";
        text[153] = "Just think about it, he's gonna fall flat on his face there wondering who did it to him.";
        text[154] = "Aaaaaand done, now lets go and search for him!";   // Rocks Loosened

        text[156] = "All actions have consequences. I'm surprised you got this far without realizing it.";
        text[155] = "Ignored and left alone with impossible task to fulfill. What else did you expect ?"; // Ignored
        //text[155] = "Left alone to deal with, what feels like impossible task? Ok, noted."; // Ignored
        text[156] = "Was it a mercy or stupidity leading you with that choice ?"; // Killed
        //text[156] = "Is that your idea of being merciful ? "; // Killed
        text[157] = "Left with no purpose, just to rot and be forgotten. That's one way to go i guess. "; // Ball taken away
        //text[157] = "Left with no purpose, just to rot and be forgotten. Noted."; // Ball taken away
        text[158] = "I mean . . . The goal is fullfilled. But whose success is that really ?"; // Ball placed on the top
        //text[158] = "The goal is fullfilled. But whose success is that really ?"; // Ball placed on the top

        text[160] = "Grab";
        text[161] = "Release";
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
 */