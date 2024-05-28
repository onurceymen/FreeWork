using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.AlgorithmicPrograms
{
    public class InterestIncome
    {
        public float ProblemOne(int month, float money)
        {
            float interest = 0.08f;

            for (int i = 1; i <= month; i++)
            {
              money += money * interest;
              Console.WriteLine($"{i} ay sonra {money} birim TL para olur.");
            }

            Console.WriteLine($"Topalam {month} Ay Sonra {money} birim TL Olur.");

            return money;
        }


        public float ProblemTwo(float money, int ReturnMoney)
        {
            int month = 0;
            float interest = 0.08f;

            while (money < ReturnMoney) 
            {
                money += money * interest;
                month++;
                Console.WriteLine($"{month} ay sonra, {money} birim TL olur.");

            }
            Console.WriteLine($"{month} Ay Sonra, {money} birim TL olur. ");

            return money;
        }
    }
}
