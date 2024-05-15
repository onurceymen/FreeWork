using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackerrank.ProblemMethods
{
    public class CountingSort
    {
        public static int[] CountingSorts(int[] arr)
        {
            // 0'dan 99'a kadar olan sayıların her birinin tekrar sayısını tutacak bir dizi
            int[] frequency = new int[100];

            // Dizideki her eleman için frekansını artır
            foreach (var number in arr)
            {
                frequency[number]++;
            }

            return frequency;
        }
    }
}


/*
 * 
        // Kullanıcıdan dizi boyutunu ve diziyi al
        Console.WriteLine("Dizi boyutunu giriniz:");
        int n = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"Dizinin elemanlarını giriniz ({n} adet):");
        int[] arr = new int[n];
        string[] inputs = Console.ReadLine().Split(' ');

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(inputs[i]);
        }

        // CountingSort sınıfının metoduyla frekans dizisini hesapla ve yazdır
        int[] result = CountingSort.countingSort(arr);

        Console.WriteLine("Frekanslar:");
        Console.WriteLine(string.Join(" ", result));

*/