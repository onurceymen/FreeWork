using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.ProblemMethods
{
    //Given five positive integers, find the minimum and maximum
    //values that can be calculated by summing exactly four of the five integers.
    //Then print the respective minimum and maximum
    //values as a single line of two space-separated long integers.

    public static class MinMaxSum
    {
        public static void MMSum(int[] arry)
        {
            Array.Sort(arry);
            int max = 0;
            int min = 0;


            for (int i = 0; i < arry.Length - 1; i++)
            {
                min += arry[i];
            }

            for (int i = 1; i < arry.Length; i++)
            {
                max += arry[i];
            }

            Console.WriteLine(min + " " + max);

        }


    }
}
