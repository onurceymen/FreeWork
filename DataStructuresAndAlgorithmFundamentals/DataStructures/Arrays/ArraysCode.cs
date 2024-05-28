using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Arrays
{
    public class ArraysCode
    {
        private int[] array;

        public void CreateArray(int size)
        {
            if (array == null) 
            {
                array = new int[size];
                Console.WriteLine($"Dizi {size} elemanlı olarak oluşturuldu");
            }
            else
            {
                Console.WriteLine("Zaten bir dizi mevcut yeni bir dizi oluşturamazsınız");
            }
        }

        public void DisplayArray()
        {
            if (array == null)
            {
                Console.WriteLine("Hiçbir dizi oluşturulmamış.");
            }
            else if (array.Length == 0)
            {
                Console.WriteLine("Dizi oluşturuldu ama henüz eleman eklenmedi.");
            }
            else
            {
                Console.WriteLine("Dizi Elemanları:");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine($"Index {i}: {array[i]}");
                }
            }
        }

        public void AddElement(int index, int value)
        {
            if(array == null) 
            {
                Console.WriteLine("Öncelikle Bir Dizi oluşturmalısınız");
            }
            else if (index < 0 || index >= array.Length)
            {
                Console.WriteLine("Geçersiz indeks. Lütfen Uygun Bir indeks Giriniz");
            }
            else
            {
                array[index] = value;
                Console.WriteLine($"Indeks {index} değer {value} olarak ayarlandı.");
            }
        }
        
        public void DeleteArray()
        {
            array = null;
            Console.WriteLine("Dizi Silindi");
        }
    }
}
