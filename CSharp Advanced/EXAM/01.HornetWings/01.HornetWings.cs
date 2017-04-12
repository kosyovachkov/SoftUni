namespace _01.HornetWings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class HornetWings
    {
        public static void Main()
        {
            int wingFlaps = int.Parse(Console.ReadLine());
            double distanceForFlaps = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());

            double distance = wingFlaps / 1000 * distanceForFlaps;
            //double secForRest = wingFlaps / endurance;

            double hornetFlapsSeconds = wingFlaps / 100;
            double hornetRest = wingFlaps / endurance * 5;

            double neededTime = hornetFlapsSeconds + hornetRest;

            Console.WriteLine($"{distance:f2} m.");
            Console.WriteLine($"{neededTime} s.");

        }
    }
}
