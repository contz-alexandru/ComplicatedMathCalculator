// Complicated Calculator V1 by Contz Alexandru
// No Regex Usage
namespace ConsoleApp1
{
    internal class Program
    {
        const string operators = @"+-*/:^%";
        public double Operation(double x, double y, char o)
        {
            switch (o)
            {
                case '+':
                    return x + y;
                case '-':
                    return x - y;
                case '*':
                    return x * y;
                case '/' or ':':
                    return x / y;
                case '%':
                    return x % y;
                case '^':

                    break;
            }
        }
        static void Main(string[] args)
        {
            // Read user input
            Console.Write("Enter your math problem (+,-,*,/,:,^,%): ");
            string input = Console.ReadLine();
            while (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Your input is empty, try again!");
                Console.Write("Enter your math problem (+,-,*,/,:,^,%): ");
                input = Console.ReadLine();
            }
            // Actual Program
            double[] numberArray = new double[input.Length - 1];
            string[] operatorArray = new string[input.Length - 1];
            int arrayIndex = 0;
            string numberString = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    numberString += input[i];
                }
                else if (",.".Contains(input[i]) && numberString != string.Empty)
                {
                    if (numberString.EndsWith(',') is false && numberString.EndsWith('.') is false)
                    {
                        numberString += input[i];
                    }
                }
                else if (operators.Contains(input[i]))
                {
                    if () { }
                }
                else
                {
                    input = input.Remove(i, 1);
                    i--;
                }
            }

        }
    }
}
