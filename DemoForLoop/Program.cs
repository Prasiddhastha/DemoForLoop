﻿using System;
namespace CsharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            for(var i=1;i<=10;i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine(" ");
            for(var i=10;i>=1;i--)
            {
                if(i % 2 == 0)
                {
                    Console.WriteLine($"{i}");
                }
            }
        }
    }
}
