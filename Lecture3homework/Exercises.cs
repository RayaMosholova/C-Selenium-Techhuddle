﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture3homework
{
    class Exercises
    {
        public static void Ex1()
        {
            int sum = 0;
            for (int i = 0; i < 8; i++)
            {
                sum = sum + i;
            }

            Console.WriteLine("The Sum of natural numbers up to 7: " + sum);
        }
        public static void Ex2()
        {
            double sum = 0;
            Console.WriteLine("Input the 10 numbers");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Number-{i}: ");
                double input = double.Parse(Console.ReadLine());
                sum = sum + input;
            }
            Console.WriteLine("The sum of 10 numbers is: " + sum);
            Console.WriteLine($"The average of 10 numbers is: {sum / 10}");
        }
        public static void Ex3()
        {
            Console.Write("Input amount of numbers: ");
            int count = int.Parse(Console.ReadLine());

            int sum = 0;
            int oddNumber = 1;
            Console.Write("Odd numbers: ");
            for (int i = 0; i < count; i++)
            {
                Console.Write(oddNumber + " ");
                sum = sum + oddNumber;
                oddNumber = oddNumber + 2;
            }

            Console.WriteLine();
            Console.WriteLine($"Sum of odd numbers up to {count} terms: " + sum);
        }
        public static void Ex4()
        {
            int number = 4;

            for (int i = 1; i <= number; i++)
            {
                Console.Write(new string(' ', number - i));
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
        public static void Ex5()
        {
            Console.Write("Input amount of numbers to display: ");
            int count = int.Parse(Console.ReadLine());

            int x = 0;
            int y = 1;
            int z;

            Console.WriteLine($"Fibonacci series up to {count} numbers: ");
            Console.Write("0 1 ");
            for (int i = 2; i < count; i++)
            {
                z = x + y;
                x = y;
                y = z;
                Console.Write(y + " ");

            }
        }
        public static void Ex6()

        {
            int sum = 0;

            Console.Write("Numbers between 100 and 200, divisible by 9: ");
            for (int i = 100; i <= 200; i++)
            {
                if (i % 9 == 0)
                {
                    sum = sum + i;
                    Console.Write(i + " ");
                }

            }
            Console.WriteLine();
            Console.WriteLine("The sum is : " + sum);
        }
        public static void Ex7()
        {
            Console.Write("Enter a number to convert: ");

            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"The Binary of {number} is: {Convert.ToString(number, 2)}");

        }
        public static void Ex8()
        {
            Console.Write("Input a binary number: ");

            string number = Console.ReadLine();

            Console.WriteLine($"The decimal of {number} is: {Convert.ToInt32(number, 2)}");
        }
        public static void Ex9()
        {
            // Used help for ALL the following exercises
            int number = 5;

            for (int i = 1; i <= number; i++)
            {

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 5; i >= 1; i--)
            {

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 5; i >= 1; i--)
            {

                for (int j = i; j >= 1; j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            for (int i = 1; i <= 5; i++)
            {

                for (int j = 5; j >= i; j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int counter = 0;
            for (int i = 1; i <= 5; i++)
            {

                for (int j = 1; j <= i; j++)
                {
                    counter = counter + 1;
                    Console.Write(counter + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            counter = 65;
            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write((char)counter + " ");
                    counter = counter + 1;
                    if (counter == 91) counter = 65;
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write(Convert.ToInt32(i == 1 || j == 1 || i == n || j == n) + " ");
                }
                Console.WriteLine();
            }
        }

        public static void Ex10()
        {
            Console.Write("x = ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            double sum = 0;
            for (int i = 0; i <= n; i++)
            {
                sum += Math.Pow(x, i);
            }

            Console.WriteLine(sum);
        }
    }
}
