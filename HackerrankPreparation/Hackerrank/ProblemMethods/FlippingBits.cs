using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.ProblemMethods
{
    public class FlippingBits
    {
        public FlippingBits(int sorgu)
        {
            for (int i = 0; i < sorgu; i++) 
            {
                Console.WriteLine("Tersine çevrilecek sayısı giriniz");
                uint n = uint.Parse(Console.ReadLine().Trim());
                uint result = FlippingBits.FlipBits(n);
                Console.WriteLine("Tersine Cevrilmiş Değer " + result);
            }
        }

        public static uint FlipBits(uint n)
        {
            return ~n;
        }



    }
}
