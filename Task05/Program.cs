using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number (N): ");
        int N = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        for (int i = 1; i <= N; i++)
        {
            sum += i;
        }

        Console.WriteLine($"Sum from 1 to {N} = {sum}");
        Console.WriteLine();

        Console.WriteLine("Numbers from 1 to 20 (skip multiples of 4, stop at 15):");

        int num = 1;
        while (num <= 20)
        {
            if (num == 15)

            if (num % 4 == 0)
            {
                num++;
            }

            Console.WriteLine(num);
            num++;
        }


        int[] numbers = { 2, 4, 6, 8, 10 };
        int arraySum = 0;

        foreach (int value in numbers)
        {
            arraySum += value;
        }

        Console.WriteLine("Sum of array elements = " + arraySum);
    }
}
