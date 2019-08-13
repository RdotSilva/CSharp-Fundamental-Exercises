using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    class Exercise08
    // Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number.
    // If the user guesses the number, display “You won"; otherwise, display “You lost".
    // (To make sure the program is behaving correctly, you can display the secret number on the console first.)
    {
        static void Main(string[] args)
        {
            var num =  new Random().Next(1, 10);

            var maxTries = 4;
            var triesLeft = maxTries;

            for (var i = 0; i < maxTries; i++)
            {
                Console.Write("Guess the number from 1-10 you have 4 tries: ");
                var guess = Convert.ToInt32(Console.ReadLine());

                if (guess == num)
                {
                    Console.WriteLine("Winner!");
                    return;
                }

                triesLeft--;

                if (triesLeft > 0)
                    Console.WriteLine("Guess again, {0} tries left.", triesLeft);
            }

            Console.WriteLine("You ran out of guesses!");

        }
    }
}
