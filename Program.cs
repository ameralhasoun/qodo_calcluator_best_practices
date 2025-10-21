using System;

namespace Example
{
    public class Calculator
    {
        // Adds two integer numbers and returns their sum
        public int AddNumbers(int a, int b)
        {
            return a + b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            int result1 = calc.AddNumbers(5, 3);

            Console.WriteLine($"AddNumbers result: {result1}");
        }
    }
}
