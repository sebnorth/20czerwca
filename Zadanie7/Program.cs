using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie7
{
    class Program
    {
        public static double Stozek(double r, double h) {
            return 1/3.0 * Math.PI * r * r * h;
        }
        
        static void Main(string[] args)
        {
            double.TryParse(Console.ReadLine(), out double R);
            double.TryParse(Console.ReadLine(), out double H);
            Console.WriteLine(Stozek(R,H));
            Console.ReadKey();
        }
    }
}
