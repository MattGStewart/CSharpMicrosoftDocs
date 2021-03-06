﻿using System;

namespace NumbersInCSharp 
{
    class Program
    {
        static void workingWithIntegers()
        {
            int a = 18;
            int b = 6;
            int c = a + b;
            System.Console.WriteLine(c);

            // subtraction
            c = a- b;
            System.Console.WriteLine(c);

            //Multiplication
            c = a * b;
            System.Console.WriteLine(c);

            // division
            c = a / b;
            System.Console.WriteLine(c);
        }

        static void OrderPrecedence()
        {
            int a = 5;
            int b = 4;
            int c = 2;
            int d = a + b * c;
            Console.WriteLine(d);

            d = (a + b) * c;
            Console.WriteLine(d);

            d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
            Console.WriteLine(d);

            int e = 7;
            int f = 4;
            int g = 3;
            int h = (e  + f) / g;
            Console.WriteLine(h);
        }

        static void TestLimits()
        {
            int a = 7;
            int b = 4;
            int c = 3;
            int d = (a + b) / c;
            int e = (a + b) % c;
            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");

            int max = int.MaxValue;
            int min = int.MinValue;
            Console.WriteLine($"The range of integers is {min} to {max}");

            int what = max + 3;
            Console.WriteLine($"An example of overflow: {what}");
        }

        static void WorkWithDoubles()
        {
                        double a = 5;
            double b = 4;
            double c = 2;
            double d = (a + b) / c;
            System.Console.WriteLine(d);

            double e = 19;
            double f = 23;
            double g = 8;
            double h = (e + f) / g;
            System.Console.WriteLine(h);

            double max = double.MaxValue;
            double min = double.MinValue;
            System.Console.WriteLine($"THe range of double is {min} to {max}");

            double third = 1.0 / 3.0;
            Console.WriteLine(third);        

        }

        static void WorkWithDecimals()
        {
                        decimal min = decimal.MinValue;
            decimal max = decimal.MaxValue;
            Console.WriteLine($"The range of the decimal type is {min} to {max}");

            double a = 1.0;
            double b = 3.0;
            Console.WriteLine(a / b);

            decimal c = 1.0M;
            decimal d = 3.0M;
            Console.WriteLine(c / d);
        }

        static void Main(string[] args)
        {
            // workingWithIntegers();
            // OrderPrecedence();
            // TestLimits();
            // WorkWithDoubles();
            // WorkWithDecimals();
            
        }
     }
}

