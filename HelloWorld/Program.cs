﻿using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. master : first commit");
            Console.WriteLine("2. new branch : hotfix");
            Console.WriteLine("3. hotfix : second commit");
            Console.WriteLine("4. merge : hotfix -> master");
            Console.WriteLine("5. master : second Commit");

            Console.ReadKey();
        }
    }
}
