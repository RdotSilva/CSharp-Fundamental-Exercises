using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists
{
    class Exercise02
    // Write a program and ask the user to enter their name. 
    // Use an array to reverse the name and then store the result in a new string. 
    // Display the reversed name on the console.
    {
        public void Exercise()
        {
            Console.WriteLine("Enter your name and I will reverse it:  ");

            var name = Console.ReadLine();
            Console.WriteLine(ReverseString(name));

        }

        public static string ReverseString(string stringToReverse)
        {
        char[] arr = stringToReverse.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
        }
    }
}
