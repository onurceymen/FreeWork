using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.WhatIS
{
    public class ExampleReadOnly
    {
        private string[] _shelves;

        public ExampleReadOnly(string[] initialShelves)
        {
            _shelves = initialShelves;
        }

        //ReadOnly Olmayan bir Metot: kitapların yerleri değiştiriyor
        public void RearrangeBooks(int fromIndex, int toIndex)
        {
            if (fromIndex < 0 || fromIndex >= _shelves.Length || toIndex < 0 || toIndex >= _shelves.Length)
            {
                Console.WriteLine("Invalid index!");
                return;
            }

            //Kitabın Yerini Değiştirme
            string temp = _shelves[fromIndex];
            _shelves[fromIndex] = _shelves[toIndex];
            _shelves[toIndex] = temp;

            Console.WriteLine($"Book at index {fromIndex} has been moved to index {toIndex}");
        }

        public void DisplayShelves()
        {
            Console.WriteLine("Current Arrangemet of books : ");
            for (int i = 0; i < _shelves.Length; i++)
            {
                Console.WriteLine($"Shelf {i}: {_shelves[i]}");
            }
        }


        //This is Readonly Metot :It only reads the current status of the books and provides information
        public string GetBookAtShelfReadonlyMetot(int index)
        {
            if (index < 0 || index >= _shelves.Length)
            {
                return "Invalid İndex!";
            }
            
            return _shelves[index];
        }

        public void DisplayShelvesReadonlyMetot()
        {
            Console.WriteLine("Curren arrangement of books :");
            for (int i = 0; i < _shelves.Length; i++)
            {
                Console.WriteLine($"Shelf {i}: {_shelves[i]}");

            }
        }

    }
}
