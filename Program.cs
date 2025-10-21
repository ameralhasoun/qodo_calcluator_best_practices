using System;

namespace Example
{
    public class Calculator
    {
        // First method
        public int AddNumbers(int a, int b)
        {
            return a + b;
        }

        public int divide_numbers(int a, int b)
        {
            return a / b;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            int result1 = calc.AddNumbers(5, 3);
            Console.WriteLine($"AddNumbers result: {result1}");

            int result2 = calc.divide_numbers(10, 0);
            Console.WriteLine("Done");
        }
    }
}