using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie8
{
    class Program
    {
        public static double g(int n) {
            if (n == 0) return -2;
            else
                return (g(n - 1) + 3) / 2.0;
        }
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int n);
            
            Console.WriteLine(g(n));
            Console.ReadKey();
        }
    }
}
