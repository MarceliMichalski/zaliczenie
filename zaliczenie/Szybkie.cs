using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
namespace zaliczenie
{
    public class Szybkie : SortowanieZlozone
    {
        public override void Sortuj(int[] t, int lewy, int prawy)
        {
            if (lewy < prawy)
            {
                int indeksPivota = Podziel(t, lewy, prawy);
                Sortuj(t, lewy, indeksPivota - 1);
                Sortuj(t, indeksPivota + 1, prawy);
            }
        }

        private int Podziel(int[]t, int lewy, int prawy)
        {
            int pivot = t[prawy];
            int i = lewy - 1;

            for (int j = lewy; j < prawy; j++)
            {
                if (t[j] <= pivot)
                {
                    i++;
                    Zamien(t, i, j);
                }
            }

            Zamien(t, i + 1, prawy);
            return i + 1;
        }

        private void Zamien(int[] t, int i, int j)
        {
            int temp = t[i];
            t[i] = t[j];
            t[j] = temp;
        }
    }
}
