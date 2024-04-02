using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.ProblemMethods
{
    public class SparseArrays
    {
        static int[] MatchingStrings(string[] strings, string[] queries)
        {
            Dictionary<string, int> frequencyMap = new Dictionary<string, int>();

            // Count the frequency of each string in the input array
            foreach (string str in strings)
            {
                if (!frequencyMap.ContainsKey(str))
                {
                    frequencyMap[str] = 1;
                }
                else
                {
                    frequencyMap[str]++;
                }
            }

            // Check the frequency of each query in the frequency map
            int[] results = new int[queries.Length];
            for (int i = 0; i < queries.Length; i++)
            {
                if (frequencyMap.ContainsKey(queries[i]))
                {
                    results[i] = frequencyMap[queries[i]];
                }
                else
                {
                    results[i] = 0;
                }
            }

            return results;
        }
    }
}
