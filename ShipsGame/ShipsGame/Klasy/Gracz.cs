using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipsGame.Klasy
{
    public class Gracz
    {
        public string Nazwa;
        // -1 to będzie pole puste
        // A liczby od 0-3 to są statki o wielkości o +1 wieksze
        public int[,] Plansza;
        public int[] Flota;
        // Tablica 2D, która
        // zapamiętuje miejsca, w które ktoś się wstrzelił
        public bool[,] OdkrytePola;
        public int LiczbaStatkowDoZatopienia;
        public static int ROZMIAR_PLANSZY = 10;
        public static int OSTATNI_INDEX_PLANSZY = ROZMIAR_PLANSZY - 1;
        public Gracz()
        {
            // Flota składa się z 4 statków
            Nazwa = "Gracz1";
            Flota = new int[] { 1, 2, 3, 4 };
            Plansza = new int[ROZMIAR_PLANSZY, ROZMIAR_PLANSZY];
            OdkrytePola = new bool[ROZMIAR_PLANSZY, ROZMIAR_PLANSZY];

            // Liczba Statkow do Zatopienia rowna sie 4
            LiczbaStatkowDoZatopienia = Flota.Length;

            for (int i = 0; i < ROZMIAR_PLANSZY; i++)
            {
                //Przejdz przez wiersze
                for (int j = 0; j < ROZMIAR_PLANSZY; j++)
                {
                    Plansza[i,j] = -1;
                    OdkrytePola[i, j] = false;
                }
                
            }

        
        }
    }
}
