﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A and B:");

            float a = float.Parse(Console.ReadLine());
            float a = float.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Enter the menu item: ");
            Console.WriteLine("1.+\n2.-\n3.*\n4./\n");

            int q = int.Parse(Console.ReadLine());

            switch (q)
            { 
                case 1:
                    sum(a, b);
                    break;
                case 2:
                    min(a, b);
                    break;
                case 3:
                    umn(a, b);
                    break;
                case 4:
                    del(a, b);
                    break;
            }
        }

        static void umn(float a, float b)
        {
            Console.Clear();
            Console.WriteLine($"{a * b}");
            Console.ReadKey();
        }
    }
}
