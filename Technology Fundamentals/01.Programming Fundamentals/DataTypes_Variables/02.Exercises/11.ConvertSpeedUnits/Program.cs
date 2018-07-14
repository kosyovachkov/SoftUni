using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            float distance = float.Parse(Console.ReadLine());
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());

            //meters per seconds

            float allSeconds = seconds + (minutes * 60) + (hour * 3600);
            Console.WriteLine(distance/allSeconds);

            //kilometers per hour

            float allHours = hour + seconds / 3600f + minutes / 60f;
            float kilometers = distance / 1000f;
            Console.WriteLine(kilometers / allHours);

            //miles per hours
            float miles = distance / 1609f;
            Console.WriteLine(miles / allHours);
        }
    }
}
