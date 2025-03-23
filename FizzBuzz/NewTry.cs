// See https://aka.ms/new-console-template for more information
using System;

class NewTry
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter three numbers separated by spaces:");
        string userValue = Console.ReadLine() ?? string.Empty;
        string[] input = userValue.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        if (userValue == string.Empty || userValue.Split().Length != 3)
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