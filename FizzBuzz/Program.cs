using System;

class Program
{
    static void Main()
    {
        // Read the input values
        string? inputLine = Console.ReadLine();
        if (string.IsNullOrEmpty(inputLine))
        {
            Console.WriteLine("You must type three numbers");
            return;
        }

        string[] input = inputLine.Split();
        int fizzDivisor = int.Parse(input[0]);
        int buzzDivisor = int.Parse(input[1]);
        int end = int.Parse(input[2]);

        // Loop through the range from 1 to end
        for (int i = 1; i <= end; i++)
        {
            if (i % fizzDivisor == 0 && i % buzzDivisor == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (i % fizzDivisor == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (i % buzzDivisor == 0)
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