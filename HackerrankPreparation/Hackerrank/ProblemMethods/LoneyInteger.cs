using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.ProblemMethods
{
    public class LoneyInteger
    {
        public int FindUnique(int[] array)
        {
            int unique = 0;
            foreach (int element in array)
            {
                unique ^= element;
            }
            return unique;
        }
    }
}
