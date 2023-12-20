using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace zaliczenie
{
    public abstract class SortowanieElementarne
    {
        public int dlugosc;
        public int od;
        public int dO;
        public int[] t;
        public abstract void Sortuj(int[] t);

        public void los(int[] tab)
        {
            Random liczby = new Random();

            for (int i = 0; i < dlugosc; i++)
            {
                tab[i] = liczby.Next(od, dO);
                t[i] = tab[i];


            }
        }
        public void mal(int[] tab)
        {
            for (int i = 0; i < dlugosc; i++)
            {

                tab[i] = dO - i;
                t[i] = tab[i];

            }
        }
        public void ros(int[] tab)
        {
            for (int i = 0; i < dlugosc; i++)
            {
                tab[i] = od;
                t[i] = tab[i];
                od++;

            }

        }
        public void wykres(Chart chart, int[] tab)
        {
            chart.Series["Wykres"].Points.Clear();
            for (int i = 0; i < dlugosc; i++)
            {
                chart.Series["Wykres"].Points.AddXY(i, t[i]);

            }
        }
    }
}
