namespace Algorithms.AlgorithmicPrograms
{
    public class Factorial
    {
        public Factorial(int sayi)
        {
            int fak = 1;
            for (int i = 1; i <= sayi; i++)
            {
                fak *= i;
            }
            Console.WriteLine("Faktöriyel: " + fak);

        }
    }
}
