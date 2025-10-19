using System;
using System.Collections.Generic;

class Program
{

    static Dictionary<char, int> charCounter(string input)
    {
        Dictionary<char, int> myList = new Dictionary<char, int>();

        foreach (char c in input.ToLower())
        {
            if (c == ' ')
            {
                continue;
            }
            else if (myList.ContainsKey(c))
            {
                myList[c]++;
            }
            else
            {
                myList[c] = 1;
            }

        }
        return myList;
    }
  
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter String (use comma for multiple string) : ");
            string input = Console.ReadLine();

            string[] word = input.Split(',');

            foreach (string word1 in word)
            {
                string word2 = word1.Trim();

                Dictionary<char, int> result = charCounter(word2);
                Console.Write(word2 + " --> ");

                foreach (var pair in result)
                {
                    Console.Write($"{pair.Key}= {pair.Value}\t");
                }
                Console.WriteLine();
            }
        }
        Console.ReadKey();
    }
}

