using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace zaliczenie
{
    public class Babelkowe : SortowanieElementarne
    {
        public override void Sortuj(int[] t)
        {
            for (int i = 0; i < dlugosc - 1; i++)
            {
                for (int j = 0; j < dlugosc - 1; j++)
                {
                    if (t[j] > t[j + 1])
                    {
                        int temp = t[j];
                        t[j] = t[j + 1];
                        t[j + 1] = temp;
                    }
                }
            }
        }
    }
}
