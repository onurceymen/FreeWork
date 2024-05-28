using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.AlgorithmicPrograms
{
    public class Equations
    {
        public int Delta(int a, int b, int c)
        {
            int delta = 0;
            double x1,x2;

            delta = b * b - 4 * a * c;

            if (delta > 0) 
            {
                x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"x1={x1}, x2={x2}");
            }

            else if (delta == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine($"Tek Kök vardır: x = {x1}");
            }
            else { Console.WriteLine("Kökler karmaşıktır"); }

            return delta;

        }
    }
}
