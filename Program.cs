namespace Example
{
    public class Calculator
    {
        // Adds two integer numbers and returns their sum
        public int AddNumbers(int a, int b)
        {
            return a + b;
        }


        public int divide_numbers(int A_Number_1, int B_Number_2)
        {
            if (B_Number_2 == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return 0;
            }
            int x = A_Number_1 / B_Number_2; 
            Console.WriteLine("Done");
            return x;
        }
    }

    var result = Calc.DivideNumbers(10, 0);
    Console.WriteLine($"DivideNumbers result: {result}");
        static void Main(string[] args)
        {
            Calculator Calc = new Calculator();

            var res = Calc.divide_numbers(10, 0);
            Console.WriteLine("Result");
        }
    }
}
