using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    class Exercise06
    // Write a program and continuously ask the user to enter a number or "ok" to exit.
    // Calculate the sum of all the previously entered numbers and display it on the console
    {
        static void Main(string[] args)
        {
            var sum = 0;

            while (true)
            {
                Console.Write("Enter a number or ok to exit:  ");

                var input = Console.ReadLine();

                if (input.ToLower().Equals("ok"))
                    break;

                sum += Convert.ToInt32(input);
            }

            Console.WriteLine("{0} is the sum of all the numbers entered", sum);
        }
    }
}
