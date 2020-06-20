using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            double wynik = (n + n * n) / 3.0;
            Console.WriteLine($"Wyraz o podanym numerze wynosi: {wynik}");
            Console.ReadKey();
        }
    }
}
