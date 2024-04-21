using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a whole number:");
        int number;
        number = Convert.ToInt32(Console.ReadLine());
        int divisors = 0;

        for (int i = 1; i <= number; ++i)
        {
            if (number % i == 0)
            {
                divisors++;
            }
        }

        if (divisors == 2)
        {
            Console.WriteLine("It`s a prime number!");
        }
        else
        {
            Console.WriteLine("It`s not a prime number");
        }
        Console.ReadKey();
    }
}