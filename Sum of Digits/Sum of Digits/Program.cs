﻿namespace Sum_of_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, sum = 0, r;

            Console.Write("Enter a number:");
            num = int.Parse(Console.ReadLine());
            while (num != 0)
            {
                 r = num % 10;
                num = num / 10;
                sum = sum + r;
            }
            

            Console.WriteLine("Sum of Digits of the Number : " + sum);
            Console.ReadLine();
        }

    }
}