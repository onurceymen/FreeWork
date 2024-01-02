using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<object> userArrays = new List<object>();

        while (true)
        {
            Console.Write("Dizi türünü belirtin (int, double, string; çıkmak için 'exit'): ");
            string inputType = Console.ReadLine();

            if (inputType.ToLower() == "exit")
            {
                break;
            }

            Console.Write("Dizi eleman sayısını girin: ");
            string inputSize = Console.ReadLine();

            if (int.TryParse(inputSize, out int arraySize) && arraySize >= 0)
            {
                switch (inputType.ToLower())
                {
                    case "int":
                        int[] intArray = new int[arraySize];
                        for (int i = 0; i < arraySize; i++)
                        {
                            Console.Write($"Eleman {i + 1}: ");
                            if (int.TryParse(Console.ReadLine(), out int element))
                            {
                                intArray[i] = element;
                            }
                            else
                            {
                                Console.WriteLine("Geçersiz bir sayı girdiniz. Dizi oluşturma işlemi iptal edildi.");
                                break;
                            }
                        }
                        userArrays.Add(intArray);
                        break;

                    case "double":
                        double[] doubleArray = new double[arraySize];
                        for (int i = 0; i < arraySize; i++)
                        {
                            Console.Write($"Eleman {i + 1}: ");
                            if (double.TryParse(Console.ReadLine(), out double element))
                            {
                                doubleArray[i] = element;
                            }
                            else
                            {
                                Console.WriteLine("Geçersiz bir sayı girdiniz. Dizi oluşturma işlemi iptal edildi.");
                                break;
                            }
                        }
                        userArrays.Add(doubleArray);
                        break;

                    case "string":
                        string[] stringArray = new string[arraySize];
                        for (int i = 0; i < arraySize; i++)
                        {
                            Console.Write($"Eleman {i + 1}: ");
                            stringArray[i] = Console.ReadLine();
                        }
                        userArrays.Add(stringArray);
                        break;

                    default:
                        Console.WriteLine("Geçersiz tür. int, double veya string girin.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Geçersiz giriş. Pozitif bir sayı girin.");
            }
        }

        Console.WriteLine("\nOluşturulan Dizilerin İçeriği:");

        foreach (var array in userArrays)
        {
            if (array is int[])
            {
                Console.WriteLine("int[]: " + string.Join(", ", (int[])array));
            }
            else if (array is double[])
            {
                Console.WriteLine("double[]: " + string.Join(", ", (double[])array));
            }
            else if (array is string[])
            {
                Console.WriteLine("string[]: " + string.Join(", ", (string[])array));
            }
        }
    }
}


