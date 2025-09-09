using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Language_Polish : LanguageBase
{
    public static Language_Polish Instance;
    public string[] text;
    public int levelID;
    public override string GetText(int index)
    {
        return text[index];
    }

    public void Awake()
    {
        if(Instance != this && Instance != null)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }

        LoadCorrectTexts();
        
    }

    void LoadCorrectTexts()
    {
        FillTextBase();
        switch (levelID)
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
        text[0] = "BRAK TEKSTU";
        text[1] = "Rozpocznij GrÍ";
        text[2] = "Jak graÊ";
        text[3] = "Opcje";
        text[4] = "Wyjdü z gry";
        text[5] = "WyjúÊ z gry ?";
        text[6] = "Tak";
        text[7] = "Nie";
        text[8] = "Muzyka";
        text[9] = "DüwiÍki";
        text[10] = "Pe≥en Ekran";
        text[11] = "RozdzielczoúÊ";
        text[12] = "Limit FPS";
        text[13] = "Vsync";
        text[14] = "PowrÛt";
        text[15] = "Zapisz i Wyjdü";
        text[16] = "Wyjdü bez Zapisywania";
        text[17] = "Sterowanie";
        text[18] = "Poruszanie SiÍ";
        text[19] = "Skok";
        text[20] = "Interakcja";
        text[21] = "Bieg";
        text[22] = "WrÛÊ do gry";
        text[23] = "Do Menu";
        text[24] = "JÍzyk";
        text[25] = "Wybierz Rozdzia≥";
    

        // INTERACTION TEXT
        text[50] = "Dotknij  ( E )";
        text[51] = "Wspnij siÍ  ( E )";
        text[52] = "SpÛjrz  ( E )";
        text[53] = "????  ( E )";
        text[54] = "Od≥Ûø  ( E )";
        text[55] = "S≥uchaj  ( E )";
        text[56] = "Usiadü  ( E )";
        text[57] = "WstaÒ  ( E )";
        text[58] = "OtwÛrz  ( E )";
        text[59] = "Zamknij  ( E )";
        text[60] = "Zabij  ( E )";
        text[61] = "Czytaj  ( E )";


        // LEVEL NAMES
        text[70] = "1-1 Dno";
        text[71] = "1-2 Bezruch";
        text[72] = "1-3 Nieznane";

        text[99] = "Jesteú jedynie nieprzewidzianym goúciem w czyimú umyúle. Ciesz siÍ podrÛøπ i obserwuj rozwÛj historii";
    }
    void FillTextScene1()
    {
        // Additional Texts
        text[100] = "Wciúnij W aby iúÊ do Przodu";
        text[101] = "? ? ?";


        // Erratic Thoughts Intro Scene
        text[102] = "biegnij";
        text[103] = "do≥πcz";
        text[104] = "nie ma juø czasu";
        text[105] = "uciekaj";
        text[106] = "juø nadchodzπ";
        text[107] = "sparaliøowany";
        text[108] = "pomocy";
        text[109] = "s≥aby";
        text[110] = "nie odchodü";
        text[111] = "poddaj siÍ";
        text[112] = "bojÍ siÍ";
        text[113] = "nie mogÍ juø tego znieúÊ";
        text[114] = "przepadnij";
        text[115] = "zniknij";
        text[116] = "zbyt zimno";
        text[117] = "to za duøo";
        text[118] = "bez nadziei";
        text[119] = "szybciej";
        text[120] = "zostaÒ";
        text[121] = "przegrasz";
        text[122] = "zabij";
        text[123] = "umrzyj";
        text[124] = "tnij";
        text[125] = "wspomnienia";
        text[126] = "zapamiÍtaj";
        text[127] = "ukryj siÍ";
        text[128] = "unikaj";
        text[129] = "w pu≥apce";
        text[130] = "defekt";
        text[131] = "bez znaczenia";
        text[132] = "skacz";

        text[140] = "CzeúÊ";
        text[141] = "Mi≥o ciÍ poznaÊ";
        text[142] = "MÛg≥bym prosiÊ ciÍ o ma≥π przys≥ugÍ ?";
        text[143] = "ZostaÒ ze mnπ trochÍ d≥uøej";
        text[144] = "WRACAJ TU !!!";

        text[150] = "NiebezpieczeÒstwo";
        text[151] = "PowstrzymaÊ";
        text[152] = "OpanowaÊ";

        text[160] = "Nie";
        text[161] = "SprÛbuj";
        text[162] = "jeszcze raz";
        text[163] = "mam doúÊ";


        // Just of what am i so afraid ?
        text[170] = "Czego ja siÍ tak w≥aúciwie bojÍ ?!";
        text[171] = "Øe øycie przeleci mi bokiem ?!";
        text[172] = "To przecieø tylko drobny wietrzyk";

        // Life Goes by, just deal with it
        text[175] = "Rzeka czasu wyznacza drogÍ ktÛrπ kroczymy";
        text[176] = " Jedyne co moøemy zrobiÊ, to podπøaÊ tym kursem.";
        text[177] = "PodπøaÊ ... I wierzyÊ øe gdzieú tam jest coú wiÍcej.";

        // Things happen, but its just a small setback
        text[180] = "NiektÛre rzeczy, sπ nam zwyczajnie przeznaczone.";
        text[181] = "Wciπø jednak to my jesteúmy tymi wrzucanymi w wodÍ.";
        text[182] = "Pomimo tego, to wciπø my podejmujemy decyzjÍ w wielu przypadkach.";

        // Life is no small setback. It is a setback
        text[185] = "Juø nie wiem gdzie mam pok≥adaÊ wiarÍ.";
        text[186] = "Wszystko w co wierzy≥em, lego w gruzach.";
        text[187] = "A moøe wpad≥o w swoje wyznaczone miejsce ?";
        text[188] = "Jak kawa≥ki uk≥adanki stworzone na takπ konkretnπ sytuacjÍ.";

        // Life is but a stepping stone
        text[190] = "kTOú oDwAøy£ úI  mnie sPrawDZi∆ ?";
        text[191] = "MNIE ?!";
        text[192] = "Øe wogÛle mia≥ cZeLNoú∆ !";
        text[193] = "Ciekawe . . .";
        // Dig through ditches
        // Burn through the witches

        text[200] = "Na kaødym ostrzu wyryto czyjeú imiona.";
        text[201] = "Zniszcz  ( E )";
    }
    void FillTextScene2()
    {
        text[100] = "Nawet nie drgnie";

        // SCENE 02

        Debug.LogError("CROW LINES NEED FIXING");

        // Crow Random Lines
        text[110] = "ZNAJDè TO !!!";
        text[111] = "ZAPOMNIJ !!!";
        text[112] = "Dlaczego";
        text[113] = "Juø Nied≥ugo";
        text[114] = "Stracone . . .";
        text[115] = "samemu";
        text[116] = "zakoÒcz to";
        text[117] = "zawiÛd≥";
        text[118] = "juø nie ma powodu";
        text[119] = "wszystko stracone";
        text[120] = "ostatnia . . . proúba";
        text[121] = "zniszcz . . . egzystencje";
        text[122] = "Odejdü.";
        text[123] = "zostaw to";
        text[124] = "a wiÍc powtarzamy cykl";
        text[125] = "jesteú g≥upcem";
        text[126] = "bez wysi≥ku";
        text[127] = "k≥amstwa";
        text[128] = "CzujÍ, jakbym by≥ ostatni";
        text[129] = "Upadek jest nieunikniony";
        text[130] = "Znajdü drogÍ";
        text[131] = "Strach";
        text[132] = "zmÍczony";
        text[133] = "prosze, odejdü";
        text[134] = "daremny wysi≥ek";


        // Bench Thoughts
        text[200] = "jaki jest cel mojego istnienia";
        text[201] = "co jest ze mnπ nie tak";
        text[202] = "czy w≥aúnie tak to mia≥o wyglπdaÊ ?";
        text[203] = "proúciej by≥oby zwyczajnie . . .";


        // On Interactions
        text[160] = "Od≥Ûø - Iskra  ( E )";
        text[161] = "Weü - Iskra  ( E )";
        text[162] = "Trzymane razem ale przez co ?";
        text[163] = "Jakby . . . czas stanπ≥ w miejscu";
        text[164] = "wyglπda jakby czegoú tu brakowa≥o";
        text[165] = "Drzwi do lepszej przysz≥oúci";
        text[166] = "Weü - Sztylet  ( E )";


        // Lore Drop
        text[170] = "Cichy åwiat.";
        text[171] = "åwiat ktÛry poprostu siÍ zatrzyma≥.";
        text[172] = "Nie z powodu jakiegoú kataklizmu.";
        text[173] = "Nie z powodu opuszczenia.";
        text[174] = "Ale z powodu szkÛd.";
        text[175] = "SzkÛd wyrzπdzonych przez innych";
        text[176] = "nieprzemyúlane decyzje";
        text[177] = "decyzje podjÍte przez osoby, ktÛrym nie chcia≥o siÍ zastanowiÊ drugi raz";
        text[178] = "dzia≥ania podejmowane bez poczucia konsekwencji.";

        text[179] = "Witaj.";
        text[180] = "åwiat, ktÛry widzisz, jest tym, o ktÛrym wielu mog≥oby powiedzieÊ, øe jest nie do naprawienia.";
        text[181] = "åwiat skazany na poraøkÍ.";
        text[182] = "A jednak. Stoisz tu.";
        text[183] = "PrÛbujesz jakoú to wszystko odkrÍciÊ. PrÛbujesz naprawiÊ tπ dziurÍ.";
        text[184] = "Powodzenia. Ja nie da≥em radÍ.";

        text[185] = "A wiÍc tak, úwiat w ktÛrym wszystko zastyg≥o.";
        text[186] = "Dok≥adnie w takim stanie, w jakim je zostawiono."; ;
        text[187] = "Dla kogoú do podniesienia, tylko z zaciekawienia.";
        text[188] = "Jak przypadkowy b≥yszczπcy kamyk na drodze";
        text[189] = "Jak roúlina, ktÛra nie by≥a podlewana przez bÛg wie jak d≥ugi czas, b≥agajπca o trochÍ deszczu.";
        text[190] = "Tylko prÛbujπca przetrwaÊ, staÊ siÍ w pe≥ni tym czym jest.";
        text[191] = "Ale deszcz nigdy nie nadejdzie.";
        text[192] = "Nic, co mog≥oby poprawiÊ kurs zdarzeÒ.";
        text[193] = "Jedyne co zosta≥o, to czekaÊ na to co nieuniknione.";
        text[194] = "Ca≥a nadzieja, ktÛrπ mog≥eú mieÊ, przepad≥a";
        text[195] = "Witaj w úwiecie.";

        text[196] = "Chcesz jakiú wskazÛwek ?";
        text[197] = "Idü znajdü swojπ w≥asnπ iskierkÍ nadzieii";
        text[198] = "Kto wie, moøe drzwi do lepszego jutra stanπ dla ciebie otworem.";
        text[198] = "Kto wie, moøe te przeklÍte drzwi wkoÒcu siÍ otworzπ.";

        text[199] = "TRANSLATE THIS.";

        text[200] = "Ahhh, Juø czujÍ, øe znalaz≥eú to czego brakowa≥o.";
        text[201] = "Teraz jesteú w stanie je us≥yszeÊ, prawda ?";
        text[202] = "Ohhh, jak brakowa≥o mi tej ciszy.";
        text[203] = "Takøe od teraz, to ty tu rzπdzisz.";
        text[204] = "DziÍki za zdjÍcie problemu ze mnie.";

        text[205] = "Jeúli nie wiesz co teraz zrobiÊ, mogÍ sprÛbowaÊ ci jakoú pomÛc.";
        text[206] = "Na poczπtek . . . PrÛbowa≥eú chociaø je wys≥uchaÊ ?";
        text[207] = "Kto wie, moøe dowiesz siÍ czegoú wartoúciowego ?";


        // Past Self continued Talk
        text[209] = "TRANSLATE THIS"; //

        text[210] = "I jak ? Dowiedzia≥eú siÍ czegoú uøytecznego ?";
        text[211] = "Podejrzewam, øe niezbyt.";
        text[212] = "Wiesz co siÍ mÛwi.";
        text[213] = "Nie bÍdzie zmian jeúli otoczenie pozostanie to samo.";
        text[214] = "      ";
        text[215] = "Wydaje mi siÍ, øe znajdziesz dla tego jakieú zastosowanie."; // Hands a knife to the player

        // After First Crow Killed
        text[220] = "RÛb co musisz.";
        // After 3 Crows Killed
        text[221] = "Mam nadziejÍ, øe warto.";
        text[225] = "Kilka wciπø jeszcze øyje.";
        // Crow location hints
        text[230] = "Jeden moøe byÊ w pobliøu zniszczonego pomieszczenia. Tego z ktÛrego przyby≥eú.";
        text[231] = "Te trzy filary z czego jeden zawieszony w powietrzu. Szuka≥eú tam ?";
        text[232] = "Kiedyú by≥ gdzieú tutaj most. ";
        text[233] = "Odwiedzi≥eú juø tego w pobliøu martwej sterty krukÛw ?";
        text[234] = "Jeden kruk jest w pobliøu dziury. Przynajmniej zawsze tam by≥.";
        text[235] = "A pamiÍtasz o tym gadatliwym przy drzwiach ?";
        text[236] = "Jakiú cichy moøe teø byÊ przy drzwiach.";
        text[237] = "Widzia≥eú tego wykluczonego przed úwiπtyniπ, siedzπcego na kamieniu ?";
        text[238] = "A co z ukochanπ parπ na drzewie ?";
        text[239] = "A co z ukochanπ parπ na drzewie ?";
        text[240] = "Czy dok≥adnie przeszuka≥eú drogÍ ? Wydaje mi siÍ, øe jeden wciπø powinien tam byÊ.";
        text[241] = "Punkt zbiegu rzek jeden z nich upatrzy≥ sobie jako miejsce na dom.";
        text[242] = "Jeden powinien byÊ w pobliøu. Zawsze obserwujπc.";

        text[250] = "To chyba juø wszystkie. ";
        text[251] = "Teraz jest to naprawdÍ zastyg≥y úwiat.";
        text[252] = "CÛø za b≥oga pustka. SpokÛj.";
        text[253] = "Niczym znak nadciπgajπcego koÒca";
        text[254] = "Powolnego. Pokazujπcego swoje k≥y. Czajπcego siÍ tuø za rogiem.";
        text[255] = "Biorπc pod uwagÍ mÛj stan . . .";
        text[256] = "Pozwolisz mi nareszcie odpoczπÊ ?"; // Enable Kill Interaction,


        // Insulting Crow 8 Pillars
        text[280] = "Wiesz co mi zawsze przychodzi na myúl, gdy na ciebie patrzÍ ?";
        text[281] = "Øe jesteú zwyczajnie defektem";
        text[282] = "B≥Ídem na kartach historii. Skazanym na usuniÍcie.";
        text[283] = "Zapomnienie";
        text[284] = "Jak niedba≥a linia zrobiona o≥Ûwkiem w szkicowniku.";
        text[285] = "PamiÍtaj o tym w tej swojej maleÒkiej g≥Ûwce.";

        // Insulting Crow 7
        text[290] = "TrochÍ ci zaje≥o dotarcie tutaj.";
        text[291] = "Ileø to moøna na ciebie zawsze czekaÊ ?";
        text[292] = "Moøe to przez to, øe jesteú zmÍczony ?";
        text[293] = "Ogarnij siÍ.";
        text[294] = "Nie przynosisz nic, oprÛcz wstydu.";
        text[295] = "Naleøy ci siÍ to wszystko. To twoja ciÍøko wypracowana nagroda.";
        text[296] = "No dawaj. Ciesz siÍ. Coú ciÍ powstrzymuje ?";

        // Insulting Crow 10
        text[300] = "Musisz zaczπÊ akceptowaÊ fakty.";
        text[301] = "Samemu wybra≥eú to wszystko";
        text[302] = "Kaøde wydarzenie to rezultat twojej nieudolnoúci.";
        text[303] = "Zdecydowa≥eú nawet uciec od wszystkich problemÛw.";
        text[304] = "ZakopaÊ je i zapomnieÊ o nich.";
        text[305] = "Czego innego moøna by≥o siÍ po tobie spodziewaÊ.";

        // Insulting Crow 3
        text[310] = "Widzisz tamtπ stertÍ zw≥ok ?";
        text[311] = "Co powiesz na to, abyú siÍ w niej po≥oøy≥ i poprostu zdech≥ ?";
        text[312] = "Nikt i tak przecieø nie zauwaøy";
        text[313] = "Nigdy nie by≥o przeznaczone ci istnieÊ i tak.";
        text[314] = "Zaakceptuj to.";

        // Insulting Crow 2
        text[320] = "Co ty wogÛle prÛbujesz tutaj osiπgnπÊ ?";
        text[321] = "Poddaj siÍ,";
        text[322] = ".  .  .                           ";
        text[323] = "Nie rozumiesz co siÍ do ciebie mÛwi ?";
        text[324] = "PODDAJ SI ";
        text[325] = "ZrÛb mi przysz≥ugÍ i skoÒcz juø z tπ fasadπ.";
        text[326] = "Nikt nawet nie chce, abyú robi≥ te rzeczy.";

        // Insulting Crow 12 Temple Crow 1
        text[330] = "Im bardziej z tym walczysz, tym wiÍcej tracisz";
        text[331] = "Koniec koÒcÛw, zostaniesz w tym wszystkim samemu";
        text[332] = "PogÛdü siÍ z tym";
        text[333] = "Czyø nie w≥aúnie o tym zawsze marzy≥eú ?";

        // Insulting Crow 13 Temple Crow 2
        text[340] = "Nadziei nie moøna wiecznie oszukiwaÊ.";
        text[341] = "W pewnym momencie, zwyczajnie staniesz w miejscu.";
        text[342] = "Staniesz i bÍdziesz siÍ zastanawia≥, po co.";
        text[343] = "Nareszcie uúwiadomisz sobie, øe nie ma sensu nawet prÛbowaÊ.";
        text[344] = "W≥aúnie wtedy, przypomnisz sobie moje s≥owa.";


        // Insulting Crow 1
        text[350] = "øa≥osne";
        text[351] = "NaprawdÍ myúla≥eú, øe to bÍdzie takie proste ?";
        text[352] = "znajdü w sobie to coú";
        text[353] = "wtedy napewno wszystko siÍ u≥oøy";
        text[354] = "jeszcze tylko kilka krokÛw i wszystko bÍdzie dobrze ";
        text[355] = "idü naprzÛd, uwierz w siebie";
        text[356] = "Nie rozúmieszaj mnie";
        text[357] = "wiedzia≥eú øe to nie zadzia≥a";
        text[358] = "rÛwnie dobrze moøna spaliÊ to wszystko i zaczπÊ od zera";

        // Insulting Crow 4
        text[360] = "A kogÛø to my tu mamy ?";
        text[361] = "D≥ugo wyczekiwany zbawca!";
        text[362] = "Ten, ktÛry przywrÛci sprawy na odpowieni tor!";
        text[363] = "Poraøka a nie zbawca";
        text[364] = "SpÛjrz na siebie";
        text[365] = "Ktoú taki jak ty, dokonujπcy czegoú ?";
        text[366] = "To chyba jakiú øart";

        // Insulting Crow 6
        text[370] = "HahAhAhaHAha";
        text[371] = "Dobry øart !";
        text[372] = "Skπd siÍ wziπ≥ taki klaun jak ty, co ?";
        text[373] = "åmietnisko ?";
        text[374] = "Bo niby gdzie indziej znaleüÊ kogoú tak bezuøytecznego ?";
        text[375] = "Juø nie mogÍ siÍ doczekaÊ aby zobaczyÊ jak siÍ ≥amiesz.";
        text[376] = "Walcz o swoje øycie !";
        text[377] = "No dawaj, Dla zabawy !";
        text[378] = "TRANSLATE THIS";

        // Insulting Crow 9
        text[380] = "Masz zamiar w≥oøyÊ w to jaki kolwiek wysi≥ek ?";
        text[381] = "Jedyne co widzÍ, to jak krÍcisz siÍ woko≥o.";
        text[382] = "Jakbyú w zupe≥noúci nie wiedzia≥ co zrobiÊ.";
        text[383] = "Jak bardzo g≥upi moøesz byÊ ?";

        // Insulting Crow 5
        text[390] = "I jak, uda≥o siÍ ?";
        text[391] = "SkoÒcz z tymi z≥udzeniami.";
        text[392] = "Nigdy nic dobrze nie zrobi≥eú.";
        text[393] = "WiÍc czemu myúlisz, øe teraz mia≥oby byÊ inaczej ?";
        text[394] = "Nigdy ci siÍ nie uda. Z tym moøesz mi wierzyÊ.";

        // Insulting Crow 11
        text[400] = "To by≥o oczywiste od samego poczπtku";// Self fulfilling Prophecy
        text[401] = "Jesteú jak samospe≥niajπca siÍ przepowiednia";
        text[402] = "Nie zmienisz tego, co zapisano ci w kartach.";
        text[403] = "Ca≥y twÛj wysi≥ek na marne.";
        text[404] = "Jak z dzieckiem . . .";

    }

    void FillTextScene3()
    {
        text[100] = "Scieøka";
        text[101] = "WybÛr";
        text[102] = "PoddaÊ siÍ";
        text[103] = "ByÊ";

        text[110] = "Co to za miejsce ?";
        text[111] = "Kim jestem ?";
        text[112] = "O co tutaj chodzi ?";

        // What is this place answer
        text[115] = "This place used to be a past. Used to be a future.";
        text[116] = "The beggining of everything.";
        text[117] = "Now its just ... all that is left.";
        // Who Am I answer
        text[120] = "Go forward and find your answer.";
        text[121] = "You're the one with the keys and a will.";
        // What's going on answer
        text[125] = "You got lost.";


        // Rock Pushing
        text[130] = "Left alone to deal with, what feels like impossible task."; // Ignored
        text[131] = "Is that your idea of being merciful ?"; // Killed
        text[132] = "Left with no purpose, just to rot and be forgotten."; // Ball taken away
        text[133] = "The goal is fullfilled. But whose success is that really ?"; // Ball placed on the top
        text[134] = "Take  ( E )";
        text[135] = "Drop  ( E )";
        text[136] = "Put Back  ( E )";
    }
}