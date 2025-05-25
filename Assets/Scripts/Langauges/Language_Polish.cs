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

        
        text = new string[300];
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


        // LEVEL NAMES
        text[70] = "1-1 Dno";
        text[71] = "1-2 Bezruch";
        text[72] = "1-2 Cichy åwiat";


        // Additional Texts
        text[94] = "                               ";
        text[95] = "? ? ?";
        text[96] = "BRAK TEKSTU";
        text[97] = "Nawet nie drgnie";
        text[98] = "GRA SKO—CZONA NA TEN MOMENT. Jest kilka rzeczy, ktÛre zmieni≥y siÍ na mapie, moøna iúÊ i je sprawdziÊ. Jednak poza tym nie ma juø nic innego do zrobienia";
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
        text[109] = "PODDAJ SI ";
        text[110] = "bojÍ siÍ";
        text[111] = "nie mogÍ juø tego znieúÊ";
        text[112] = "przepadnij";
        text[113] = "zniknij";
        text[114] = "zbyt zimno";
        text[115] = "to za duøo";
        text[116] = "bez nadziei";
        text[117] = "SZYBCIEJ";
        text[118] = "zostaÒ";
        text[119] = "przegrasz";


        // SCENE 02
        // Crow Random Lines
        text[150] = "ZNAJDè TO !!!";
        text[151] = "ZAPOMNIJ !!!";
        text[152] = "Stracone . . .";
        text[153] = "Juø Nied≥ugo";
        text[154] = "Dlaczego";
        text[155] = "zakoÒcz to```";
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
        text[169] = "prosze, nie dawaj nadziei";
        text[170] = "CzujÍ, jakbym by≥ ostatni";
        text[171] = "Upadek jest nieunikniony";


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
        text[267] = "decyzje podjÍte przez osoby, ktÛrym nie chcia≥o siÍ myúleÊ";
        text[268] = "dzia≥ania podejmowane bez poczucia konsekwencji.";

        text[269] = "Witaj.";
        text[270] = "åwiat, ktÛry widzisz, jest tym, o ktÛrym wielu mog≥oby powiedzieÊ, øe jest nie do naprawienia.";
        text[271] = "åwiat skazany na poraøkÍ.";
        text[272] = "A jednak. Stoisz tu.";
        text[273] = "Trying to make things right. Trying to fix this shithole.";
        text[273] = "PrÛbujesz jakoú to wszystko odkrÍciÊ. PrÛbujesz naprawiÊ tπ dziurÍ.";
        text[274] = "Powodzenia. Ja nie da≥em radÍ.";

        text[275] = "A wiÍc tak, úwiat w ktÛrym wszystko zastyg≥o.";
        text[276] = "Dok≥adnie w takim stanie, w jakim je zostawiono.";;
        text[277] = "Dla kogoú do podniesienia, tylko z wygody";
        text[278] = "Jak przypadkowy b≥yszczπcy kamyk na drodze";
        text[280] = "Jak roúlina, ktÛra nie by≥a podlewana przez bÛg wie jak d≥ugi czas, b≥agajπca o trochÍ deszczu.";
        text[280] = "Tylko prÛbojπca przetrwaÊ, staÊ siÍ w pe≥ni tym czym jest.";
        text[281] = "Ale deszcz nigdy nie nadejdzie.";
        text[282] = "Nic, co mog≥oby poprawiÊ kurs zdarzeÒ.";
        text[283] = "Jedyne co zosta≥o, to czekaÊ na to co nieuniknione.";
        text[284] = "Ca≥a nadzieja, ktÛrπ mog≥eú mieÊ, przepad≥a";
        text[285] = "Witaj w úwiecie.";
    }
}