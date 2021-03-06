﻿using System;

namespace Example07
{
    class OptionalParameterDemo
    {
        static void Main()
        {
            Console.Write("Using 2 arguments: ");
            DisplaySize(4, 6);
            Console.Write("Using 3 arguments: ");
            DisplaySize(4, 6, 8);
        }
        private static void DisplaySize(int length, int width, int height = 1)
        {
            int area = length * width * height;
            Console.WriteLine("Size is {0}", area);
        }
    }

}
