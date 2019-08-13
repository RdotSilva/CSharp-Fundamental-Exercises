using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    class Exercise01
    {
        // Write a program and ask the user to enter a number. The number should be between 1 to 10.
        // If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid".
        // (This logic is used a lot in applications where values entered into input boxes need to be validated.)
        static void Main(string[] args)
        {
            Console.Write("Enter a number from 1-10: ");
            var number = Convert.ToInt32(Console.ReadLine());
            if (number > 0 && number <= 10)
                Console.WriteLine("Valid number entered");
            else
                Console.WriteLine("Invalid number entered");
        }
    }
}
