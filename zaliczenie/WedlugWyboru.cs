using System.Collections.Generic;

namespace zaliczenie
{
    public class WedlugWyboru : SortowanieElementarne
    {
        public override void Sortuj(int[] t)
        {
            for (int i = 0; i < dlugosc-1; i++)
            {
                int indeksMin = i;
                for (int j = i + 1; j < dlugosc; j++)
                {
                    if (t[j] < t[indeksMin])
                    {
                        indeksMin = j;
                    }
                }

                int temp = t[i];
                t[i] = t[indeksMin];
                t[indeksMin] = temp;
            }
        }
    }
}
