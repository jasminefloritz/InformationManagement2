using System;
using System.Collections.Generic;

namespace SW1
{
    class Program
    {
        static (double peso, double yen) convert(double dollar)
        {
            double peso = dollar * 57.17;
            double yen = dollar * 146.67;
            return (peso, yen);
        }
        static string isPrime(int num)
        {
            if (num <= 1)
            {
                return $"{num}\t not a prime nor composite";
            }
            for(int i=2; i<= Math.Sqrt(num); i++)
            {
                if(num % i == 0)
                {
                    return $"{num}\tComposite";
                }
            }
            return $"{num}\tPrime";
        }
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string input = Console.ReadLine();

            string[] nums = input.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List<int> numList = new List<int>();

            foreach(var n in nums)
            {
                if (int.TryParse(n , out int value))
                    numList.Add(value);
                else
                    Console.WriteLine($"{n} is not a number");
            }

            int item = 1;
            foreach(int n in numList)
            {
                Console.WriteLine($"{item}.  {isPrime(n)}");
                item++;
            }



            Console.Write("Enter currency in ($): ");
            string inp = Console.ReadLine();

            string[] dollar = inp.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            List <double> inpList = new List<double>();

            foreach (var n in dollar)
            {
                if (double.TryParse(n, out double value))
                    inpList.Add(value);
                else
                    Console.WriteLine($"{n} is not a value");
            }

            
            foreach (double n in inpList)
            {
                var (peso, yen) = convert(n);
                Console.WriteLine($"{"Dollar($)",-12}{"Phil Peso(P)",-15}{"Jpn Yen(Y)",-15}");
                Console.WriteLine($"{n,-12:F2}\t{peso,-15:F2}\t{yen,-20:F2}");
               
            }

            Console.ReadKey();
        }
    }
}
