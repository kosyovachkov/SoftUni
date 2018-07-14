using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfYear = Console.ReadLine();
            double holidays = double.Parse(Console.ReadLine());
            double weekendsOut = double.Parse(Console.ReadLine());

            double sofiaWeekends = 48 - weekendsOut;
            double playingSofia  = sofiaWeekends * 3 / 4;
            double playingWeekends = playingSofia + weekendsOut;

            double playingHolidays = holidays * 2 / 3;

            double playingTime = playingWeekends + playingHolidays;

            double bonus = 0;

            if (typeOfYear == "leap")
            {
                bonus = playingTime * 0.15;
            }

            Console.WriteLine(Math.Truncate(playingTime + bonus));

        }
    }
}
