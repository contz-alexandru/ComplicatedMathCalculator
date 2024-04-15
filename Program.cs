// Complicated Calculator V1 by Contz Alexandru
// No Regex Usage

namespace ConsoleApp1
{
    internal class Program
    {
        const string operators = @"+-*/:^%";
        const string points = @".,";
        static void Main(string[] args)
        {
            string input = string.Empty;
            bool hasDigit = false;

            // Checking for digits and filtering input
            while (hasDigit is false)
            {
                Console.Write("Enter your math problem (+,-,*,/,:,^,%): ");
                input = Console.ReadLine();
                while (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Your input is empty, try again!");
                    Console.Write("Enter your math problem (+,-,*,/,:,^,%): ");
                    input = Console.ReadLine();
                }
                for (int i = 0; i < input.Length; i++)
                {
                    if (char.IsDigit(input[i]) is false && operators.Contains(input[i]) is false && points.Contains(input[i]) is false)
                    {
                        input = input.Remove(i, 1);
                        i--;
                    }
                    else if (char.IsDigit(input[i]))
                        hasDigit = true;
                }
                if (!hasDigit)
                {
                    Console.WriteLine("No supported math problem available!, Try again!");
                }
            }
            Console.WriteLine(input);

            //
            string[] operatorArray = new string[input.Length];

            string numberString = string.Empty;
            double[] numberArray = new double[input.Length];

            int j = 0;
            // Filter operators
            for (int i = 0; i < input.Length; i++)
            {
                if (operators.Contains(input[i]))
                {
                    operatorArray[j] = string.Empty;
                    while (operators.Contains(input[i]))
                    {
                        operatorArray[j] += input[i];
                        i++;
                    }
                    i--;
                    if (operatorArray[j].Length > 2)
                        operatorArray[j] = operatorArray[j].Remove(0, operatorArray[j].Length - 2);
                }
                else
                {
                    if (points.Contains(input[i]))
                    {
                        if (numberString.Contains(input[i]) is false)
                            numberString += input[i];
                    }
                    else numberString += input[i];
                }
            }





            Console.WriteLine(numberString);
            for (int i = 0; i < operatorArray.Length; i++)
            {
                Console.WriteLine(operatorArray[i]);
            }
        }
    }
}
