using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.ProblemMethods
{
    public class DiagonalDifference
    {
        public static int CalculateDifference(int[,] matrix)
        {
            int n = matrix.GetLength(0); // Matrisin boyutunu al (nxn)
            int primaryDiagonalSum = 0;
            int secondaryDiagonalSum = 0;

            for (int i = 0; i < n; i++)
            {
                primaryDiagonalSum += matrix[i, i]; // Ana köşegen
                secondaryDiagonalSum += matrix[i, n - i - 1]; // İkincil köşegen
            }

            return Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);

        }
    }
}
