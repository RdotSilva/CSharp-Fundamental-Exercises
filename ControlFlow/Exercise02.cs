using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    class Exercise02
    {
        public void Exercise()
        {
            Console.Write("Enter 1st number: ");
            var num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 2nd number: ");
            var num1 = Convert.ToInt32(Console.ReadLine());

            var maxNumber = (num1 > num2) ? num1 : num2;
            if (num1 == num2)
                Console.WriteLine("Numbers are the same.");
            else
                Console.WriteLine("Max is " + maxNumber);
        }
    }
}
