using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace zaliczenie
{
    public class PrzezScalanie : SortowanieZlozone
    {
        public override void Sortuj(int[] t, int lewy, int prawy)
        {
            if (lewy < prawy)
            {
                int srodek = (lewy + prawy) / 2;
                Sortuj(t, lewy, srodek);
                Sortuj(t, srodek + 1, prawy);

                Scal(t, lewy, srodek, prawy);
            }
        }

        private void Scal(int[] dane, int lewy, int srodek, int prawy)
        {
            int rozmiarLewej = srodek - lewy + 1;
            int rozmiarPrawej = prawy - srodek;

            int[] lewa = new int[rozmiarLewej];
            int[] prawa = new int[rozmiarPrawej];

            for (int i = 0; i < rozmiarLewej; i++)
                lewa[i] = dane[lewy + i];

            for (int j = 0; j < rozmiarPrawej; j++)
                prawa[j] = dane[srodek + 1 + j];

            int indeksLewej = 0, indeksPrawej = 0;
            int indeksScalanej = lewy;

            while (indeksLewej < rozmiarLewej && indeksPrawej < rozmiarPrawej)
            {
                if (lewa[indeksLewej] <= prawa[indeksPrawej])
                {
                    dane[indeksScalanej] = lewa[indeksLewej];
                    indeksLewej++;
                }
                else
                {
                    dane[indeksScalanej] = prawa[indeksPrawej];
                    indeksPrawej++;
                }
                indeksScalanej++;
            }

            while (indeksLewej < rozmiarLewej)
            {
                dane[indeksScalanej] = lewa[indeksLewej];
                indeksLewej++;
                indeksScalanej++;
            }

            while (indeksPrawej < rozmiarPrawej)
            {
                dane[indeksScalanej] = prawa[indeksPrawej];
                indeksPrawej++;
                indeksScalanej++;
            }
        }
    }
}
