using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            int counterDays = 1;

            int treatedPatients = 0;
            int untreatedPatients = 0;
            int untreatedPatientsForDay = 0;
            int doctors = 7;

            for (int i = 1; i <= days; i++)
            {
                int patientsForDay = int.Parse(Console.ReadLine());


                if (counterDays % 3 == 0 && untreatedPatients > treatedPatients)
                {
                    doctors++;
                }

                if (patientsForDay > doctors)
                {
                    treatedPatients += doctors;
                    untreatedPatientsForDay = patientsForDay - doctors;
                    untreatedPatients += untreatedPatientsForDay;
                }

                else
                {
                    treatedPatients += patientsForDay;
                }

                

                counterDays++;

            }
            

            Console.WriteLine("Treated patients: {0}.", treatedPatients);
            Console.WriteLine("Untreated patients: {0}.", untreatedPatients);
        }
    }
}


//Решена за 01.30.00