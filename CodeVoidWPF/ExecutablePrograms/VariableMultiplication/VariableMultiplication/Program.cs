﻿using System;

namespace VariableMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            /* variables declaration */
            int a = 2;
            int b = 3;
            int c = a * b;

            /* output the result on the console */
            Console.WriteLine("Variable C is: " + c);

            /* await a key to be pressed */
            Console.ReadKey();

        }
    }
}
