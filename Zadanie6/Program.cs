using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie6
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int n);

            int[] tablica = new int[n];

            for (int i = 0; i < n; i++)
            {
                int.TryParse(Console.ReadLine(), out tablica[i]);
            }

            foreach (int item in tablica)
            {
                Console.WriteLine(item);
            }

            int licznikUjemnych = 0;

            foreach (int item in tablica)
            {
                if (item < 0) licznikUjemnych++;
            }

            Console.WriteLine($"Ilość elementów ujemnych w tablicy wynosi: {licznikUjemnych}");


            Console.ReadKey();
    
        }
    }
}
