using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomProblems.Solution
{
    public class MultiplicationTableMaster
    {
        public MultiplicationTableMaster(int number)
        {
            if (number >= 1 && number <= 10) 
            {
                for (int i = 1; i <= 10; i++) 
                {
                    Console.WriteLine(number + " * " + i + " = " + number * i); 
                }
            }
            else
            {
                Console.WriteLine("Sayı 10 eşit veya 10 dan küçük değil");
            }

        }
    }
}
