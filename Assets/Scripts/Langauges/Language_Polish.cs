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


        text[70] = "1-1 Dno";
        text[71] = "1-2 Bezruch";
        text[72] = "1-2 Cichy åwiat";


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

    }
}

/* Crow Lines
ZAPOMNIJ !!!
Stracone . . .
Juø Nied≥ugo
Dlaczego

 */
