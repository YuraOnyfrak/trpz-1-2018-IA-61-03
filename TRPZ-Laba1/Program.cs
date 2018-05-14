using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPZ_Laba1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = new int[] { 3, 6, 4, 2, 4, 6, 7, 2, 11, 33, 53, 62, 4, 2 };

            Console.WriteLine("Our list: \n");
            foreach (int i in list)
            {
                Console.Write(i + " ");
            }

            //Sorting of Shella

            int[] listByShella = SortedContainer.ShellaSort(list);
            Console.WriteLine("\n\nOur list which was sorted by sorting of Shella: \n");
            foreach (int i in listByShella)
            {
                Console.Write(i + " ");
            }

            //Sorting of Choice

            int[] listByChoice = SortedContainer.SrtByChoice(list);
            Console.WriteLine("\n\nOur list which was sorted by sorting of choice: \n");
            foreach (int i in listByChoice)
            {
                Console.Write(i + " ");
            }

            Console.ReadKey(); /*Delay*/
        }
    }
}
