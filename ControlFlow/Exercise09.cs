using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    
    class Exercise09
        // Write a program and ask the user to enter a series of numbers separated by comma.
        // Find the maximum of the numbers and display it on the console.
        // For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
    {
        public void Exercise()
        {
            Console.Write("Enter a series of numbers separated by comma: ");

            var input = Console.ReadLine();

            var splitInput = input.Split(',');

            var maxNumber = Convert.ToInt32(splitInput[0]);

            foreach (var number in splitInput)
            {
                var newNumber = Convert.ToInt32(number);
                if (newNumber > maxNumber)
                    maxNumber = newNumber;
            }

            Console.WriteLine("Max number is {0}", maxNumber);
        }
    }
}
