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

        
        text = new string[200];
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


        text[70] = "1-1 Dno";
        text[71] = "1-2 Bezruch";
        text[72] = "1-2 Cichy åwiat";


        text[96] = "BRAK TEKSTU";
        text[97] = "Nawet nie drgnie";
        text[98] = "GRA SKO—CZONA NA TEN MOMENT. Jest kilka rzeczy, ktÛre zmieni≥y siÍ na mapie, moøna iúÊ i je sprawdziÊ. Jednak poza tym nie ma juø nic innego do zrobienia";
        //text[99] = "Jesteú jedynie nieprzewidzianym goúciem w czyimú umyúle. Odkryj prawdÍ ukrytπ pod warstwπ rzeczywistoúci.";
        text[99] = "Jesteú jedynie nieprzewidzianym goúciem w czyimú umyúle. Ciesz siÍ podrÛøπ i obserwuj rozwÛj historii";


        text[100] = "                               ";
        text[101] = "? ? ?";
        text[102] = "* puk puk puk *";
        text[103] = "Co to za düwiÍk ?";
        text[104] = "ZNAJDè TO !!!";
        text[105] = "ZAPOMNIJ !!!";
        text[106] = "Stracone . . .";
        text[107] = "Juø Nied≥ugo";
        text[108] = "Dlaczego";
        text[109] = "Jakby . . . czas stanπ≥ w miejscu";
        text[110] = "zakoÒcz to```";
        text[111] = "samemu";
        text[112] = "zawiÛd≥";
        text[113] = "wszystko stracone";
        text[114] = "juø nie ma powodu";
        text[115] = "ostatnia . . . proúba";
        text[116] = "wyglπda jakby czegoú tu brakowa≥o";
        text[117] = "Weü - Iskra  ( E )";
        text[118] = "Od≥Ûø - Iskra  ( E )";
        text[119] = "Strach";
        text[120] = "zniszcz . . . egzystencje";
        text[121] = "zostaw to";
        text[122] = "prosze, nie dawaj nadziei";
        text[123] = "a wiÍc powtarzamy cykl";
        text[124] = "jesteú g≥upcem";
        text[125] = "Odejdü.";
        text[126] = "CzujÍ, jakbym by≥ ostatni";
        text[127] = "Znajdü drogÍ";
        text[128] = "Upadek jest nieunikniony";
        text[129] = "Trzymane razem ale przez co ?";
        text[130] = "zmÍczony";
        text[131] = "jaki jest cel mojego istnienia";
        text[132] = "co jest ze mnπ nie tak";
        text[133] = "czy w≥aúnie tak to mia≥o wyglπdaÊ ?";
        text[134] = "proúciej by≥oby gdybym . . .";

        text[135] = "øa≥osne";
        text[136] = "NaprawdÍ myúla≥eú, øe to bÍdzie takie proste ?";
        text[137] = "znajdü w sobie to coú";
        text[138] = "wtedy napewno wszystko siÍ u≥oøy";
        text[139] = "jeszcze tylko kilka krokÛw i wszystko bÍdzie dobrze ";
        text[140] = "idü naprzÛd, uwierz w siebie";
        text[141] = "Nie rozúmieszaj mnie";
        text[142] = "wiedzia≥eú øe to nie zadzia≥a";
        text[143] = "rÛwnie dobrze moøna spaliÊ to wszystko i zaczπÊ od zera";
    }
}