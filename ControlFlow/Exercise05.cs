using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    // Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.
    // Display the count on the console.
    class Exercise05
    {
        public void Exercise()
        {

            var counter = 0;
            for (var i = 1; i <= 100; i++)
            {
                var divisibleByThree = (i % 3 == 0) ? true : false;

                if (divisibleByThree)
                    counter++;
            }
            Console.WriteLine("{0} numbers divisible by 3", counter);
        }
    }
}
