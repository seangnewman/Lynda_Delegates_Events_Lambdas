﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousDelegates
{

    public delegate string MyDelegate(int arg1, int arg2);

    class Program
    {
        static void Main(string[] args)
        {
            // SNIPPET GOES HERE
            MyDelegate f = delegate (int arg1, int arg2)
            {
                return (arg1 + arg2).ToString();
            };

            Console.WriteLine("The number is {0}", f(10,20));

            // Keep the console window open until a key is pressed
            Console.WriteLine("\nPress Enter Key to Continue...");
            Console.ReadLine();
        }
    }
}
