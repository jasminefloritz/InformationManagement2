using System;

namespace HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            do {
                Console.Write("Enter string: ");
                input = Console.ReadLine();

                string lowerInput = input.ToLower();

                string reversed = "";

                for (int i = lowerInput.Length - 1; i >= 0; i--)
                {
                    reversed += lowerInput[i];
                }
                string result = (lowerInput == reversed) ? "Yes" : "No";
                Console.WriteLine("Original             Reversed              Palindrome");
                Console.WriteLine("{0, -20} {1, -25} {2} ", input, reversed, result);

            } while (input != "*");
            Console.ReadKey();
        }
    }
}
