using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _01.CountWorkingDays
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime firstdate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime secondtdate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            DateTime[] holidays = new DateTime[11];
            {
                holidays[0] = new DateTime(2016, 01, 01);
                holidays[1] = new DateTime(2016, 03, 03);
                holidays[2] = new DateTime(2016, 05, 01);
                holidays[3] = new DateTime(2016, 05, 06);
                holidays[4] = new DateTime(2016, 05, 24);
                holidays[5] = new DateTime(2016, 09, 06);
                holidays[6] = new DateTime(2016, 09, 22);
                holidays[7] = new DateTime(2016, 11, 01);
                holidays[8] = new DateTime(2016, 12, 24);
                holidays[9] = new DateTime(2016, 12, 25);
                holidays[10] = new DateTime(2016, 12, 26);
            }

            int counter = 0;

            for (DateTime start = firstdate; start <= secondtdate; start = start.AddDays(1))
            {
                DateTime dayNow = new DateTime(2016, start.Month, start.Day);

                if (!holidays.Contains(dayNow) && start.DayOfWeek != DayOfWeek.Saturday && start.DayOfWeek != DayOfWeek.Sunday)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
