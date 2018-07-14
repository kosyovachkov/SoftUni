using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int neededHours = int.Parse(Console.ReadLine());
            int workDays = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double realWorkingHours = (workDays - (workDays * 0.1)) * 8;

            double workersHours = workers * workDays * 2;

            double timeForJob = Math.Floor(realWorkingHours + workersHours);

            if (neededHours<=timeForJob)
            {
                Console.WriteLine("Yes!{0} hours left.", timeForJob-neededHours);
            }

            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", neededHours-timeForJob);
            }


        }
    }
}

//Решена за 14.00 минути