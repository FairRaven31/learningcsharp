using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace Project3;

class Program
{
    static void Main(string[] args)
    {
        //declaring variables
        /*
        int x;
        int y;

        x = 7;
        y = x + 3;
        Console.WriteLine(y);
        Console.ReadLine();
        */

        Console.WriteLine("What is your name");
        Console.Write("Type your first name: ");
        string myFirstName;
        myFirstName = Console.ReadLine();

        // Console.Write("Type your last Name: ");
        // string myLastName;
        // myLastName = Console.ReadLine();

        Console.Write("Type your last name");
        string myLastName = Console.ReadLine();

        Console.WriteLine("Hello, " + myFirstName + " " + myLastName);
        Console.ReadLine();
    }
}
