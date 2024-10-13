using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project7;

class Program
{
    static void Main(string[] args)
    {
        // The wrong way to do it
        /*
        int number1 = 4;
        int number2 = 8;
        int number3 = 15;
        int number4 = 16;
        int number5 = 23;

        if (number1 == 16)
        {
        }
        else if (number2 == 16)
        {
        }
        else if (number3 == 16)
        {
        }
        */

        //arrays
        /*
        int[] numbers = new int[5];

        numbers[0] = 4;
        numbers[1] = 8;
        numbers[2] = 15;
        numbers[3] = 16;
        numbers[4] = 23;

        Console.WriteLine(numbers[1]);
        Console.WriteLine(numbers.Length);
        Console.ReadLine();
        */

        //declaring and assigning an array
        int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 };

        string[] names = new string[] { "Nicole", "Nicol", "Derrick", "Tahiru" };

        //accessing values in an array
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
        Console.ReadLine();

        string rabindranathTagore = "It is simple to be happy, but it is difficult to be simple.";
        char[] quoteCharacterArray = rabindranathTagore.ToCharArray();
        Array.Reverse(quoteCharacterArray);

        foreach (var quoteCharacter in quoteCharacterArray)
        {
            Console.Write(quoteCharacter);
        }
        Console.ReadLine();
    }
}
