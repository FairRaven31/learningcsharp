﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project6;

class Program
{
    static void Main(string[] args)
    {
        //the for loop
        for (int i = 0; i < 10; i++)
        {
            // Console.WriteLine(i);
            if (i == 7)
            {
                Console.WriteLine("Found seven!");
                break;
            }
        }

        for (int i = 0; i <= 200; i++)
        {
            Console.WriteLine(i);
        }
        Console.ReadLine();
    }
}
