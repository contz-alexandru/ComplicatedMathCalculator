using System.Text.RegularExpressions;
namespace ConsoleApp1
{
    internal class Program
    {
        const string operators = @"+-*/:^%";
        const string symbols = @"(),.";
        static void Main(string[] args)
        {
            // No Regex Use
            Console.Write("Enter your math problem (+,-,*,/,:,^,% operators supported; (),. symbols supported): ");
            string input = Console.ReadLine();
            while (string.IsNullOrEmpty(input))
            { 
                Console.WriteLine("Your input is empty, try again!");
                Console.Write("Enter your math problem (+,-,*,/,:,^,%; (),. symbols supported): ");
                input = Console.ReadLine();
            }
            bool hasDigit = false;
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                    hasDigit = true;
                else if (symbols.Contains(input[i]) is false && operators.Contains(input[i]) is false)
                {
                    input = input.Remove(i, 1);
                    i--;
                }

            }
            if (hasDigit is false)
                Console.Write("No supported math problem available!, try again!");
            else
            {
                Console.WriteLine(input);
                Console.Read();
            }
        }
    }
}