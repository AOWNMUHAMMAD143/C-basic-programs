using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FIrst c# code for "Hello world and name printing and for greetings.
            //to change the forground and background colour in c#
            //Console.ForegroundColor = ConsoleColor.blue;
            //Console.BackgroundColor = ConsoleColor.Magenta;
            string name;
            int age;
            string address;

            Console.WriteLine("Hello world\nAsalam o Alaikum!");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Wha tis your name?");
            Console.ResetColor();
            name = Console.ReadLine();

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("How old are you?");
            Console.ResetColor();
            /* 
             *  Prompt the user to enter their age and validate the input.
The while loop ensures that only a valid integer is accepted.
If the user enters a non-numeric value, an error message is displayed, 
and they are prompted to enter a valid number again.
int.TryParse() safely attempts to convert the input into an integer.
If conversion fails, the loop continues until a valid number is entered.
             */
            while (!int.TryParse(Console.ReadLine(), out age)) 
            {
                Console.WriteLine("INVALID Age!\nPlease enter a valid age (in numbers)");
                
            }
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Where do you live?");
            Console.ResetColor();
            address = Console.ReadLine();

            Console.WriteLine("Here is the provided information!\nName : " + name);
            Console.WriteLine("Age : "+ age);
            Console.WriteLine("Address : "+ address);
        }
    }
}
