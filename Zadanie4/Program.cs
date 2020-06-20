using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie4
{
    class Program
    {
        public static int Iloczyn(int x) {
            if (x < 10) return x;
            else {
                int lokalnaCyfra = x % 10;
                return lokalnaCyfra * Iloczyn(x / 10);
            }
        }
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int x);
            int cyfra;
            int iloczyn = 1;

            //for (;x>0;)
            //{
            //    cyfra = x % 10;
            //    iloczyn = iloczyn * cyfra;
            //    x = x / 10; 
            //}

            iloczyn = Iloczyn(x);
            Console.WriteLine($"iloczy cyfr wynosi: {iloczyn}");
            Console.ReadKey();

        }
    }
}
