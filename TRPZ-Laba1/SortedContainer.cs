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

        //Maks-BubleSort
        public static int[] BubleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j + 1] < array[j])
                    {
                        int tmp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tmp;
                    }
                }
            }
            return array;
        }

        //Anton - Sorting by choice 


        static public int[] SrtByChoice(int[] items)
        {
            int sortedRangeEnd = 0;

            while (sortedRangeEnd < items.Length)
            {
                int nextIndex = FindIndexOfSmallestFromIndex(items, sortedRangeEnd);
                Swap(items, sortedRangeEnd, nextIndex);

                sortedRangeEnd++;
            }

            return items;
        }

        static private int FindIndexOfSmallestFromIndex(int[] items, int sortedRangeEnd)
        {
            int currentSmallest = items[sortedRangeEnd];
            int currentSmallestIndex = sortedRangeEnd;

            for (int i = sortedRangeEnd + 1; i < items.Length; i++)
            {
                if (currentSmallest.CompareTo(items[i]) > 0)
                {
                    currentSmallest = items[i];
                    currentSmallestIndex = i;
                }
            }

            return currentSmallestIndex;
        }

    }
}
