using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPZ_Laba1
{
    class SortedContainer
    {
        static public void Swap(int[] array, int indexLeft, int indexRight)
        {
            if (array[indexLeft] != array[indexRight])
            {
                int item = array[indexLeft];
                array[indexLeft] = array[indexRight];
                array[indexRight] = item;
            }
        }


        static public int[] ShellaSort(int[] mas)
        {
            int step = mas.Length / 2;

            for (int i = 0; i < mas.Length - step; i++)
            {
                if (mas[i] > mas[i + step])
                {
                    Swap(mas, i, i + step);
                }

            }
            step /= 2;

            while (step >= 1)
            {
                for (int i = 0; i < mas.Length - step; i++)
                {
                    if (mas[i] > mas[i + step])
                    {
                        Swap(mas, i, i + step);

                    }
                    int item = i;

                    for (int j = i; j > 1; j -= step)
                    {

                        if (mas[item] < mas[j - step])
                        {
                            Swap(mas, j - step, item);
                        }
                        item = j - step;
                    }

                }
                step /= 2;
            }

            return mas;
        }


    }
}
