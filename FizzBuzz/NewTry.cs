// See https://aka.ms/new-console-template for more information
using System;

class NewTry
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter three numbers separated by spaces:");
        string userValue = Console.ReadLine() ?? string.Empty;
        string[] input = userValue.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        if (input.Length != 3 || !int.TryParse(input[0], out _) || !int.TryParse(input[1], out _) || !int.TryParse(input[2], out _))
        {
            Console.WriteLine("You must type three numbers");
            return;
        }


        int fizz = int.Parse(input[0]);
        int buzz = int.Parse(input[1]);
        int end = int.Parse(input[2]);

        for (int i = 1; i <= end; i++)
        {
            if (i % fizz == 0 && i % buzz == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % fizz == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % buzz == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}