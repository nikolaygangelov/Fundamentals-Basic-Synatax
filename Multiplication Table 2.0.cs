using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());
            int product = input * multiplier;

            if (multiplier > 10)
            {
                Console.WriteLine($"{input} X {multiplier} = {product}");
            }
            else
            {
                while (multiplier <= 10)
                {
                    Console.WriteLine($"{input} X {multiplier} = {input * multiplier}");
                    multiplier++;
                }
            }
        }
    }
}
