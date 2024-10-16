using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project8;

class Program
{
    static void Main(string[] args)
    {
        //old version of program - bad
        /*
        Console.WriteLine("The Nice Game");
        Console.Write("What's your first name? ");
        string firstName = Console.ReadLine();
        Console.Write("What's your last name? ");
        string lastName = Console.ReadLine();
        Console.Write("In what city were you born? ");
        string city = Console.ReadLine();
        char[] firstNameArray = firstName.ToCharArray();
        Array.Reverse(firstNameArray);
        char[] lastNameArray = lastName.ToCharArray();
        Array.Reverse(lastNameArray);
        char[] cityArray = city.ToCharArray();
        Array.Reverse(cityArray);

        string result = "";
        foreach (char item in firstNameArray)
        {
            result += item;
        }
        result += " ";
        foreach (char item in lastNameArray)
        {
            result += item;
        }
        result += " ";
        foreach (char item in cityArray)
        {
            result += item;
        }

        Console.WriteLine("Results: " + result);
        Console.ReadLine();
        */

        //edits made to the new version
        // string reversedFirstName = ReverseString(firstName);
        // string reversedLastName = ReverseString(lastName);
        // string reversedCity = ReverseString(city);

        // Console.WriteLine(reversedFirstName + " " + reversedLastName + " " + reversedCity);
        //calling display result version 1
        // DisplayResult(reversedFirstName, reversedLastName, city);

        //new version of program - good
        Console.WriteLine("The Nice Game");
        Console.Write("What's your first name? ");
        string firstName = Console.ReadLine();
        Console.Write("What's your last name? ");
        string lastName = Console.ReadLine();
        Console.Write("In what city were you born? ");
        string city = Console.ReadLine();


        //calling display result version 2
        DisplayResult(ReverseString(firstName), ReverseString(lastName), ReverseString(city));
        Console.ReadLine();
    }

    //reverses a string
    private static string ReverseString(string message)
    {
        char[] messageArray = message.ToCharArray();
        Array.Reverse(messageArray);
        return String.Concat(messageArray);
    }

    private static void DisplayResult(string item1, string item2, string item3)
    {
        Console.Write("Results: ");
        Console.WriteLine(String.Format("{0} {1} {2}", item1, item2, item3));
    }
}
