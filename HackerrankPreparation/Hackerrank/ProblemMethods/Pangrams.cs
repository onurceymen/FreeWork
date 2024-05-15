using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.ProblemMethods
{
    public class Pangrams
    {
        public static bool IsPangrams(string s)
        {
            //Tüm Karakterleri Küçük Harfe Çevir
            var charSet = new HashSet<char>();
            foreach (char ch in s.ToLower())
            {
                if (char.IsLetter(ch))
                {
                    charSet.Add(ch);
                }
            }
            return charSet.Count == 26;
            //Sadece Alfabetik Karakterleri Kontrol Et 
            //Ingiliz Alfabesi 26 Harften oluşur 
        }
    }
}

/*
 * 
 * Console.WriteLine("Please enter a sentence to check if it's a pangram:");
string userInput = Console.ReadLine();

bool isPangram = Pangrams.IsPangrams(userInput);
if (isPangram)
{
    Console.WriteLine("The sentence is a pangram.");
}
else
{
    Console.WriteLine("The sentence is not a pangram.");
}

Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();


 * */