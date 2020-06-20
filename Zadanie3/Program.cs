using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int ile);

            int i = 1;
            int x = 0; 
            while (i<=ile)
            {
                if (x % 13 == 0 && x % 2 != 0){
                    i += 1;
                    Console.WriteLine(x);
                    x += 13; 
                }

                x += 13;
                    
            }

            Console.ReadKey();
        }
    }
}
