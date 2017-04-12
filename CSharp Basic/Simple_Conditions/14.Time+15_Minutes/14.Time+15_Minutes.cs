using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Time_15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputHours = int.Parse(Console.ReadLine());
            int inputMinutes = int.Parse(Console.ReadLine());

            int hoursToMinutes = inputHours * 60;
            int allMinutes = hoursToMinutes + inputMinutes;
            allMinutes = allMinutes + 15;

            int newMinutes = allMinutes % 60;
            int newHours = allMinutes / 60;

            if (newHours > 23)
            {
                newHours = 24 - newHours;
            }

            Console.WriteLine("{0}:{1:00}", newHours, newMinutes);


        }
    }
}
