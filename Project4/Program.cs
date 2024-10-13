using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4;
class Program
{
    static void Main(string[] args)
    {
        //the if statement
        /*
        Console.WriteLine("Antiaye's generous giveaway!");
        Console.Write("Choose a door: 1, 2, or 3: ");
        string userValue = Console.ReadLine();
        string message;

        if (userValue == "1")
        {
            message = "You have just won a new Lamborghini Technomar 63 yatch! Congratulations!";
        }
        else if (userValue == "2")
        {
            message = "You just won for yourself a brand new  Lamborghini Urus! Sweet!";
        }
        else if (userValue == "3")
        {
            message = "You just won a cute British Shorthair cat! Way to go!";
        }
        else
        {
            message = "Sorry, wrong choice. Better luck next time!";
        }
        Console.WriteLine(message);
        Console.ReadLine();
        */

        //the conditional operator
        Console.WriteLine("Antiaye's generous giveaway!");
        Console.Write("Choose a door: 1, 2, or 3: ");
        string userValue = Console.ReadLine();

        string message = (userValue == "1") ? "boat" : "5 cedis note";
        //Console.WriteLine("You won a " + message + "! Congratulations!");
        //Console.WriteLine("You won a {0}! Congratulations!", message);
        Console.WriteLine("You entered: {0}, therefore you won a {1}! Congratulations!", userValue, message);

        Console.ReadLine();
    }
}
