using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists
{
    class Exercise04
    // Write a program and ask the user to continuously enter a number or type "Quit" to exit. 
    // The list of numbers may include duplicates. Display the unique numbers that the user has entered.
    {
        public void Exercise()
        {
          var numList = new List<int>();

          while (true)
          {
            Console.Write("Enter a number, or Quit to quit:  ");
          
            var input = Console.ReadLine();

            if (input.Equals("Quit"))
                    break;

            numList.Add(Convert.ToInt32(input));
          }

          var distinctNums = numList.Distinct();

          foreach (var num in distinctNums) 
              Console.WriteLine(num);
        }
    }
}
