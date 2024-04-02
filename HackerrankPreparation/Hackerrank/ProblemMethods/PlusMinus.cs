using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.ProblemMethods
{
    public class PlusMinus
    {
        public double Positive { get; set; }
        public double Negative { get; set; }
        public double Zero { get; set; }

        public PlusMinus(int[] array)
        {
            int count = array.Length;
            int positiveCount = 0;
            int negativeCount = 0;
            int zeroCount = 0;

            foreach (int num in array)
            {
                if (num > 0)
                    positiveCount++;
                else if (num < 0)
                    negativeCount++;
                else
                    zeroCount++;
            }

            Positive = (double)positiveCount / count;
            Negative = (double)negativeCount / count;
            Zero = (double)zeroCount / count;
        }
    }
}
