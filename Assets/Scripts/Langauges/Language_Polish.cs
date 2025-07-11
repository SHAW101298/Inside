using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Language_Polish : LanguageBase
{
    public static Language_Polish Instance;
    public string[] text;
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

        
        text = new string[550];
        // UI TEXT
        text[0] = "Rozpocznij GrÍ";
        text[1] = "Jak graÊ";
        text[2] = "Opcje";
        text[3] = "Wyjdü z gry";
        text[4] = "WyjúÊ z gry ?";
        text[5] = "Tak";
        text[6] = "Nie";
        text[7] = "Muzyka";
        text[8] = "DüwiÍki";
        text[9] = "Pe≥en Ekran";
        text[10] = "RozdzielczoúÊ";
        text[11] = "Limit FPS";
        text[12] = "Vsync";
        text[13] = "PowrÛt";
        text[14] = "Zapisz i Wyjdü";
        text[15] = "Wyjdü bez Zapisywania";
        text[16] = "Sterowanie";
        text[17] = "Poruszanie SiÍ";
        text[18] = "Skok";
        text[19] = "Interakcja";
        text[20] = "Bieg";
        text[21] = "WrÛÊ do gry";
        text[22] = "Do Menu";
        text[23] = "JÍzyk";
        text[24] = "Wybierz Rozdzia≥";


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


        // Additional Texts
        text[94] = "                               ";
        text[95] = "? ? ?";
        text[96] = "BRAK TEKSTU";
        text[97] = "Nawet nie drgnie";
        text[98] = "GRA SKO—CZONA NA TEN MOMENT. Wciπø moøna przeszukaÊ mapÍ w celu wybicia krukÛw i wys≥uchania ich, ale to wszystko. ";
        text[99] = "Jesteú jedynie nieprzewidzianym goúciem w czyimú umyúle. Ciesz siÍ podrÛøπ i obserwuj rozwÛj historii";
        //text[99] = "Jesteú jedynie nieprzewidzianym goúciem w czyimú umyúle. Odkryj prawdÍ ukrytπ pod warstwπ rzeczywistoúci.";


        // Erratic Thoughts Intro Scene
        text[100] = "biegnij";
        text[101] = "do≥πcz";
        text[102] = "nie ma juø czasu";
        text[103] = "uciekaj";
        text[104] = "juø nadchodzπ";
        text[105] = "sparaliøowany";
        text[106] = "pomocy";
        text[107] = "s≥aby";
        text[108] = "nie odchodü";
        text[109] = "poddaj siÍ";
        text[110] = "bojÍ siÍ";
        text[111] = "nie mogÍ juø tego znieúÊ";
        text[112] = "przepadnij";
        text[113] = "zniknij";
        text[114] = "zbyt zimno";
        text[115] = "to za duøo";
        text[116] = "bez nadziei";
        text[117] = "szybciej";
        text[118] = "zostaÒ";
        text[119] = "przegrasz";
        text[120] = "zabij";
        text[121] = "umrzyj";
        text[122] = "tnij";
        text[123] = "wspomnienia";
        text[124] = "zapamiÍtaj";
        text[125] = "ukryj siÍ";
        text[126] = "unikaj";
        text[127] = "w pu≥apce";
        text[128] = "defekt";
        text[129] = "bez znaczenia";
        text[130] = "skacz";

        text[131] = "CzeúÊ";
        text[132] = "Mi≥o ciÍ poznaÊ";
        text[133] = "MÛg≥bym prosiÊ ciÍ o ma≥π przys≥ugÍ ?";
        text[134] = "ZostaÒ ze mnπ trochÍ d≥uøej";

        text[135] = "NiebezpieczeÒstwo";
        text[136] = "PowstrzymaÊ";
        text[137] = "OpanowaÊ";
        text[138] = "WRACAJ TU !!!";

        text[139] = "Nie";
        text[140] = "SprÛbuj";
        text[141] = "jeszcze raz";
        text[142] = "mam doúÊ";

        // SCENE 02
        #region

        // Crow Random Lines
        text[150] = "ZNAJDè TO !!!";
        text[151] = "ZAPOMNIJ !!!";
        text[152] = "Stracone . . .";
        text[153] = "Juø Nied≥ugo";
        text[154] = "Dlaczego";
        text[155] = "zakoÒcz to";
        text[156] = "samemu";
        text[157] = "zawiÛd≥";
        text[158] = "wszystko stracone";
        text[159] = "juø nie ma powodu";
        text[160] = "Strach";
        text[161] = "zostaw to";
        text[162] = "zmÍczony";
        text[163] = "a wiÍc powtarzamy cykl";
        text[164] = "jesteú g≥upcem";
        text[165] = "Odejdü.";
        text[166] = "ostatnia . . . proúba";
        text[167] = "zniszcz . . . egzystencje";
        text[168] = "Znajdü drogÍ";
        text[169] = "prosze, odejdü";
        text[170] = "CzujÍ, jakbym by≥ ostatni";
        text[171] = "Upadek jest nieunikniony";
        text[172] = "zmarnowane";
        text[173] = "bez wysi≥ku";
        text[174] = "k≥amstwa";


        // Bench Thoughts
        text[200] = "jaki jest cel mojego istnienia";
        text[201] = "co jest ze mnπ nie tak";
        text[202] = "czy w≥aúnie tak to mia≥o wyglπdaÊ ?";
        text[203] = "proúciej by≥oby zwyczajnie . . .";


        // On Interactions
        text[210] = "Od≥Ûø - Iskra  ( E )";
        text[211] = "Weü - Iskra  ( E )";
        text[212] = "Trzymane razem ale przez co ?";
        text[213] = "Jakby . . . czas stanπ≥ w miejscu";
        text[214] = "wyglπda jakby czegoú tu brakowa≥o";
        text[215] = "Drzwi do lepszej przysz≥oúci";
        text[216] = "Weü - Sztylet  ( E )";


        // Insulting Crow 1
        text[250] = "øa≥osne";
        text[251] = "NaprawdÍ myúla≥eú, øe to bÍdzie takie proste ?";
        text[252] = "znajdü w sobie to coú";
        text[253] = "wtedy napewno wszystko siÍ u≥oøy";
        text[254] = "jeszcze tylko kilka krokÛw i wszystko bÍdzie dobrze ";
        text[255] = "idü naprzÛd, uwierz w siebie";
        text[256] = "Nie rozúmieszaj mnie";
        text[257] = "wiedzia≥eú øe to nie zadzia≥a";
        text[258] = "rÛwnie dobrze moøna spaliÊ to wszystko i zaczπÊ od zera";


        // Lore Drop
        text[260] = "Cichy åwiat.";
        text[261] = "åwiat ktÛry poprostu siÍ zatrzyma≥.";
        text[262] = "Nie z powodu jakiegoú kataklizmu.";
        text[263] = "Nie z powodu opuszczenia.";
        text[264] = "Ale z powodu szkÛd.";
        text[265] = "SzkÛd wyrzπdzonych przez innych";
        text[266] = "nieprzemyúlane decyzje";
        text[267] = "decyzje podjÍte przez osoby, ktÛrym nie chcia≥o siÍ zastanowiÊ drugi raz";
        text[268] = "dzia≥ania podejmowane bez poczucia konsekwencji.";

        text[269] = "Witaj.";
        text[270] = "åwiat, ktÛry widzisz, jest tym, o ktÛrym wielu mog≥oby powiedzieÊ, øe jest nie do naprawienia.";
        text[271] = "åwiat skazany na poraøkÍ.";
        text[272] = "A jednak. Stoisz tu.";
        text[273] = "PrÛbujesz jakoú to wszystko odkrÍciÊ. PrÛbujesz naprawiÊ tπ dziurÍ.";
        text[274] = "Powodzenia. Ja nie da≥em radÍ.";

        text[275] = "A wiÍc tak, úwiat w ktÛrym wszystko zastyg≥o.";
        text[276] = "Dok≥adnie w takim stanie, w jakim je zostawiono.";;
        text[277] = "Dla kogoú do podniesienia, tylko z zaciekawienia.";
        text[278] = "Jak przypadkowy b≥yszczπcy kamyk na drodze";
        text[279] = "Jak roúlina, ktÛra nie by≥a podlewana przez bÛg wie jak d≥ugi czas, b≥agajπca o trochÍ deszczu.";
        text[280] = "Tylko prÛbujπca przetrwaÊ, staÊ siÍ w pe≥ni tym czym jest.";
        text[281] = "Ale deszcz nigdy nie nadejdzie.";
        text[282] = "Nic, co mog≥oby poprawiÊ kurs zdarzeÒ.";
        text[283] = "Jedyne co zosta≥o, to czekaÊ na to co nieuniknione.";
        text[284] = "Ca≥a nadzieja, ktÛrπ mog≥eú mieÊ, przepad≥a";
        text[285] = "Witaj w úwiecie.";

        text[286] = "Chcesz jakiú wskazÛwek ?";
        text[287] = "Idü znajdü swojπ w≥asnπ iskierkÍ nadzieii";
        text[288] = "Kto wie, moøe drzwi do lepszego jutra stanπ dla ciebie otworem.";

        text[289] = "TRANSLATE THIS.";

        text[290] = "Ahhh, Juø czujÍ, øe znalaz≥eú to czego brakowa≥o.";
        text[291] = "Teraz jesteú w stanie je us≥yszeÊ, prawda ?";
        text[292] = "Ohhh, jak brakowa≥o mi tej ciszy.";
        text[293] = "Takøe od teraz, to ty tu rzπdzisz.";
        text[294] = "DziÍki za zdjÍcie problemu ze mnie.";

        text[295] = "Jeúli nie wiesz co teraz zrobiÊ, mogÍ sprÛbowaÊ ci jakoú pomÛc.";
        text[296] = "Na poczπtek . . . PrÛbowa≥eú chociaø je wys≥uchaÊ ?";
        text[297] = "Kto wie, moøe dowiesz siÍ czegoú wartoúciowego ?";

        // Insulting Crow 2
        text[300] = "Co ty wogÛle prÛbujesz tutaj osiπgnπÊ ?";
        text[301] = "Poddaj siÍ,";
        text[302] = ".  .  .                           ";
        text[303] = "Nie rozumiesz co siÍ do ciebie mÛwi ?";
        text[304] = "PODDAJ SI ";
        text[305] = "ZrÛb mi przysz≥ugÍ i skoÒcz juø z tπ fasadπ.";
        text[306] = "Nikt nawet nie chce, abyú robi≥ te rzeczy.";

        // Insulting Crow 3
        text[310] = "Widzisz tamtπ stertÍ zw≥ok ?";
        text[311] = "Co powiesz na to, abyú siÍ w niej po≥oøy≥ i poprostu zdech≥ ?";
        text[312] = "Nikt i tak przecieø nie zauwaøy";
        text[313] = "Nigdy nie by≥o przeznaczone ci istnieÊ i tak.";
        text[314] = "Zaakceptuj to.";

        // Insulting Crow 13 Temple Crow 2
        text[315] = "Nadziei nie moøna wiecznie oszukiwaÊ.";
        text[316] = "W pewnym momencie, zwyczajnie staniesz w miejscu.";
        text[317] = "Staniesz i bÍdziesz siÍ zastanawia≥, po co.";
        text[318] = "Nareszcie uúwiadomisz sobie, øe nie ma sensu nawet prÛbowaÊ.";
        text[319] = "W≥aúnie wtedy, przypomnisz sobie moje s≥owa.";

        // Insulting Crow 4
        text[320] = "A kogÛø to my tu mamy ?";
        text[321] = "D≥ugo wyczekiwany zbawca!";
        text[322] = "Ten, ktÛry przywrÛci sprawy na odpowieni tor!";
        text[323] = "Poraøka a nie zbawca";
        text[324] = "SpÛjrz na siebie";
        text[325] = "Ktoú taki jak ty, dokonujπcy czegoú ?";
        text[326] = "To chyba jakiú øart";

        // Insulting Crow 5
        text[330] = "I jak, uda≥o siÍ ?";
        text[331] = "SkoÒcz z tymi z≥udzeniami.";
        text[332] = "Nigdy nic dobrze nie zrobi≥eú.";
        text[333] = "WiÍc czemu myúlisz, øe teraz mia≥oby byÊ inaczej ?";
        text[334] = "Nigdy ci siÍ nie uda. Z tym moøesz mi wierzyÊ.";

        // Insulting Crow 12 Temple Crow 1
        text[336] = "Im bardziej z tym walczysz, tym wiÍcej tracisz";
        text[337] = "Koniec koÒcÛw, zostaniesz w tym wszystkim samemu";
        text[338] = "PogÛdü siÍ z tym";
        text[339] = "Czyø nie w≥aúnie o tym zawsze marzy≥eú ?";

        // Insulting Crow 6
        text[340] = "HahAhAhaHAha";
        text[341] = "Dobry øart !";
        text[342] = "Skπd siÍ wziπ≥ taki klaun jak ty, co ?";
        text[343] = "åmietnisko ?";
        text[344] = "Bo niby gdzie indziej znaleüÊ kogoú tak bezuøytecznego ?";
        text[345] = "Juø nie mogÍ siÍ doczekaÊ aby zobaczyÊ jak siÍ ≥amiesz.";
        text[346] = "Walcz o swoje øycie !";
        text[347] = "No dawaj, Dla zabawy !";
        text[348] = "TRANSLATE THIS";

        // Insulting Crow 7
        text[350] = "TrochÍ ci zaje≥o dotarcie tutaj.";
        text[351] = "Ileø to moøna na ciebie zawsze czekaÊ ?";
        text[352] = "Moøe to przez to, øe jesteú zmÍczony ?";
        text[353] = "Ogarnij siÍ.";
        text[354] = "Nie przynosisz nic, oprÛcz wstydu.";
        text[355] = "Naleøy ci siÍ to wszystko. To twoja ciÍøko wypracowana nagroda.";
        text[356] = "No dawaj. Ciesz siÍ. Coú ciÍ powstrzymuje ?";

        // Insulting Crow 8
        text[360] = "Wiesz co mi zawsze przychodzi na myúl, gdy na ciebie patrzÍ ?";
        text[361] = "Øe jesteú zwyczajnie defektem";
        text[362] = "B≥Ídem na kartach historii. Skazanym na usuniÍcie.";
        text[363] = "Zapomnienie";
        text[364] = "Jak niedba≥a linia zrobiona o≥Ûwkiem w szkicowniku.";
        text[365] = "PamiÍtaj o tym w tej swojej maleÒkiej g≥Ûwce.";

        // Insulting Crow 9
        text[370] = "Masz zamiar w≥oøyÊ w to jaki kolwiek wysi≥ek ?";
        text[371] = "Jedyne co widzÍ, to jak krÍcisz siÍ woko≥o.";
        text[372] = "Jakbyú w zupe≥noúci nie wiedzia≥ co zrobiÊ.";
        text[373] = "Jak bardzo g≥upi moøesz byÊ ?";

        // Insulting Crow 10
        text[380] = "Musisz zaczπÊ akceptowaÊ fakty.";
        text[381] = "Samemu wybra≥eú to wszystko";
        text[382] = "Kaøde wydarzenie to rezultat twojej nieudolnoúci.";
        text[383] = "Zdecydowa≥eú nawet uciec od wszystkich problemÛw.";
        text[384] = "ZakopaÊ je i zapomnieÊ o nich.";
        text[385] = "Czego innego moøna by≥o siÍ po tobie spodziewaÊ.";

        // Insulting Crow 11
        text[390] = "To by≥o oczywiste od samego poczπtku";// Self fulfilling Prophecy
        text[391] = "Jesteú jak samospe≥niajπca siÍ przepowiednia";
        text[392] = "Nie zmienisz tego, co zapisano ci w kartach.";
        text[393] = "Ca≥y twÛj wysi≥ek na marne.";
        text[394] = "Jak z dzieckiem . . .";

        // Past Self continued Talk
        text[399] = "TRANSLATE THIS"; //

        text[400] = "I jak ? Dowiedzia≥eú siÍ czegoú uøytecznego ?";
        text[401] = "Podejrzewam, øe niezbyt.";
        text[402] = "Wiesz co siÍ mÛwi.";
        text[403] = "Nie bÍdzie zmian jeúli otoczenie pozostanie to samo.";
        text[404] = "      ";
        text[405] = "Wydaje mi siÍ, øe znajdziesz dla tego jakieú zastosowanie."; // Hands a knife to the player

        // After First Crow Killed
        text[410] = "RÛb co musisz.";
        // After 3 Crows Killed
        text[411] = "Mam nadziejÍ, øe warto.";
        text[415] = "Kilka wciπø jeszcze øyje.";
        // Crow location hints
        text[416] = "Jeden moøe byÊ w pobliøu zniszczonego pomieszczenia. Tego z ktÛrego przyby≥eú.";
        text[417] = "Czy dok≥adnie przeszuka≥eú drogÍ ? Wydaje mi siÍ, øe jeden wciπø powinien tam byÊ.";
        text[418] = "Te trzy filary z czego jeden zawieszony w powietrzu. Szuka≥eú tam ?";
        text[419] = "Jeden kruk jest w pobliøu dziury. Przynajmniej zawsze tam by≥.";
        text[420] = "Jeden powinien byÊ w pobliøu. Zawsze obserwujπc.";
        text[421] = "A co z ukochanπ parπ na drzewie ?";
        text[422] = "A co z ukochanπ parπ na drzewie ?";
        text[423] = "A pamiÍtasz o tym gadatliwym przy drzwiach ?";
        text[424] = "Jakiú cichy moøe teø byÊ przy drzwiach.";
        text[425] = "Widzia≥eú tego wykluczonego przed úwiπtyniπ, siedzπcego na kamieniu ?";
        text[426] = "Kiedyú by≥ gdzieú tutaj most. ";
        text[427] = "Odwiedzi≥eú juø tego w pobliøu martwej sterty krukÛw ?";
        text[428] = "Punkt zbiegu rzek jeden z nich upatrzy≥ sobie jako miejsce na dom.";

        text[430] = "To chyba juø wszystkie. ";
        text[431] = "Teraz jest to naprawdÍ zastyg≥y úwiat.I to nie tak, øe narzekam.";
        text[432] = "CÛø za b≥oga pustka. SpokÛj.";
        text[433] = "Niczym znak nadciπgajπcego koÒca.";
        text[434] = "Powolnego. Pokazujπcego swoje k≥y. Czajπcego siÍ tuø za rogiem.";
        text[435] = "Biorπc pod uwagÍ mÛj stan . . .";
        text[436] = "Pozwolisz mi nareszcie odpoczπÊ ?"; // Enable Kill Interaction,

 #endregion

        text[450] = "Droga";
        text[451] = "WybÛr";
        text[452] = "PoddaÊ siÍ";
        text[453] = "ByÊ";

        text[455] = "Co to za miejsce ?";
        text[456] = "Kim jestem ?";
        text[457] = "O co tutaj chodzi ?";



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
}