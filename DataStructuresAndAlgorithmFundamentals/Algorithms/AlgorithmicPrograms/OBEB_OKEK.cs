using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.AlgorithmicPrograms
{
    public class OBEB_OKEK
    {
        public void OBEB(int a , int b)
        {
            int obeb, gA, gB, gcc;
            gA = a;
            gB = b;
            while (b != 0) 
            {
                gcc = a;
                a = b;
                b = gcc % a;
            }
            obeb = a;
            Console.WriteLine($"OBEB({gA},{gB})= {obeb}");
        }

        public void OKEK(int a , int b)
        {
            int obeb, okek;

            obeb = OBEB_rekusif(a, b);
            okek = a*b/obeb;
            Console.WriteLine($"OKEK ({a}{b}) = {okek}");

        }

        public int OBEB_rekusif(int a , int b)
        {
            if (b == a)
            {
                return a;
            }
            else
            {
                return OBEB_rekusif(b, a % b);
            }

        }
    }
}
