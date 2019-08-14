using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists
{
    class Exercise03
    // Write a program and ask the user to enter 5 numbers. 
    // If a number has been previously entered, display an error message and ask the user to re-try. 
    // Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
    {
        public void Exercise()
        {
          var count = 5;

          var numList = new List<int>();

          while (count > 0)
          {
            Console.Write("Enter a number: ");

            var number = Convert.ToInt32(Console.ReadLine());

            if (numList.Contains(number)) 
            {
              Console.WriteLine("You have already entered {0}, please enter new number", number);
              continue;
            }
            
            numList.Add(number);
            count--;
          }

          numList.Sort();

          foreach (var number in numList)
            Console.WriteLine(number);
        }
    }
}
