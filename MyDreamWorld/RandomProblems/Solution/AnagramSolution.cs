using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomProblems.Solution
{
    public class AnagramSolution
    {
        public static bool IsAnagram(string s1, string s2)
        {
            //Büyük/küçük Harf Duyarlılığını kaldır
            s1 = s1.ToLower();
            s2 = s2.ToLower();

            //Noktalama İşaretleri Ve boşlukları Kaldır
            char[] charsToTrim = { ' ', '.', ',', '!', '?' };

            s1 = new string(s1.Where(c => !charsToTrim.Contains(c)).ToArray());
            s2 = new string(s2.Where(c => !charsToTrim.Contains(c)).ToArray());

            //Uzunluk Kontrolü
            if (s1.Length != s2.Length) return false;

            //Harfleri Sıralayıp Karşılaştıracaksın 
            var sortedS1 = String.Concat(s1.OrderBy(c => c));
            var sortedS2 = String.Concat(s2.OrderBy(c => c));

            //Geriye Değer Döndüreceksin
            return sortedS1 == sortedS2;
        }

    }
}


/*
 *  public static bool IsAnagram(string s1, string s2)
    {
        // İlk işlemleri yap: küçük harfe çevir, boşluk ve noktalama işaretlerini kaldır
        s1 = s1.ToLower().Replace(" ", "");
        s2 = s2.ToLower().Replace(" ", "");

        // Uzunluk kontrolü
        if (s1.Length != s2.Length)
            return false;

        // Frekans tablosu oluştur
        int[] frequency = new int[256];  // ASCII karakter seti için yeterli

        // s1 string'indeki her karakter için frekansı artır
        for (int i = 0; i < s1.Length; i++)
        {
            frequency[s1[i]]++;
        }

        // s2 string'indeki her karakter için frekansı azalt
        for (int i = 0; i < s2.Length; i++)
        {
            frequency[s2[i]]--;
            // Eğer bir noktada frekans negatif olursa, bu harf s1'de yok demektir.
            if (frequency[s2[i]] < 0)
            {
                return false;
            }
        }

        // Eğer tüm frekanslar sıfırsa, string'ler anagramdır
        return true;
    }

    public static void Main()
    {
        string s1 = "Listen!";
        string s2 = "Silent!";

        bool result = IsAnagram(s1, s2);
        Console.WriteLine($"'{s1}' and '{s2}' are anagrams: {result}");
    }
 * */