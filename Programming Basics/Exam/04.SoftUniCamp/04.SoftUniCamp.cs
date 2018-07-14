using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftUniCamp
{
    class Program
    {
        static void Main(string[] args)
        {
            double allGroups = int.Parse(Console.ReadLine());

            double carPeople = 0;
            double microbusPeople = 0;
            double smallBusPeople = 0;
            double bigBusPeople = 0;
            double trainPeople = 0;

            double allPeople = 0;


            for (int i = 0; i < allGroups; i++)
            {
                double peopleInGroup = double.Parse(Console.ReadLine());

                allPeople += peopleInGroup;

                if (peopleInGroup >= 41)
                {
                    trainPeople += peopleInGroup;
                }

                else if (peopleInGroup >= 26 && peopleInGroup <= 40)
                {
                    bigBusPeople += peopleInGroup;
                }

                else if (peopleInGroup >= 13 && peopleInGroup <= 25)
                {
                    smallBusPeople += peopleInGroup;
                }

                else if (peopleInGroup >= 6 && peopleInGroup <= 12)
                {
                    microbusPeople += peopleInGroup;
                }

                else
                {
                    carPeople += peopleInGroup;
                }


            }

            Console.WriteLine("{0:f2}%", carPeople / allPeople * 100);
            Console.WriteLine("{0:f2}%", microbusPeople / allPeople * 100);
            Console.WriteLine("{0:f2}%", smallBusPeople / allPeople * 100);
            Console.WriteLine("{0:f2}%", bigBusPeople / allPeople * 100);
            Console.WriteLine("{0:f2}%", trainPeople / allPeople * 100);
        }
    }
}
