using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    class Exercise03
    {
        // Write a program and ask the user to enter the width and height of an image.
        // Then tell if the image is landscape or portrait.
        public void Exercise()
        {
            Console.Write("Enter image width: ");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter image height: ");
            var height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(width > height ? "Image is landscape." : "Image is portrait.");
        }
    }
}
