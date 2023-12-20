using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace zaliczenie
{
    public class PrzezWstawianie : SortowanieElementarne
    {
        public override void Sortuj(int[] t)
        {
            for (int i = 1; i < dlugosc; i++)
            {
                int klucz = t[i];
                int j = i - 1;

                while (j >= 0 && t[j] > klucz)
                {
                    t[j + 1] = t[j];
                    j = j - 1;
                }

                t[j + 1] = klucz;
            }
        }
    }
}
