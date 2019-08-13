using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow
{
    class Exercise04
    // Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.
    // Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a car.
    // If the user enters a value less than the speed limit, program should display Ok on the console.
    // If the value is above the speed limit, the program should calculate the number of demerit points.
    // For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console.
    // If the number of demerit points is above 12, the program should display License Suspended.
    {
        public void Exercise()
        {
            Console.Write("Enter speed limit: ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter vehicle speed: ");
            var vehicleSpeed = Convert.ToInt32(Console.ReadLine());

            var speedOver = vehicleSpeed - speedLimit;

            var demeritPoints = speedOver / 5;

            if (speedOver <= 0)
                Console.WriteLine("Speed OK");
            else if (demeritPoints <= 12)
                Console.WriteLine("Total demerit points: " + demeritPoints);
            else
                Console.WriteLine("License suspended!");

        }
    }
}
