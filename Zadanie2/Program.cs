using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int a);
            int.TryParse(Console.ReadLine(), out int b);

            //if (a < b) Console.WriteLine(a);
            //if (a > b) Console.WriteLine(b);
            //if (a == b) Console.WriteLine("Liczby są sobie równe");

            if (a < b) Console.WriteLine(a);
            else {
                if (a > b) Console.WriteLine(b);
                else Console.WriteLine("Są równe");
            }
            Console.ReadKey();
        }
    }
}
