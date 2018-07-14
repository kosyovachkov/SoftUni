using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Hospital
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            int treatedP = 0;
            int untreatedP = 0;
            int doctors = 7;

            for (int i = 1; i <= days; i++)
            {
                int patients = int.Parse(Console.ReadLine());


                if (i % 3 == 0 && untreatedP > treatedP)
                {
                    doctors++;
                }

                if (patients <= doctors)
                {
                    treatedP += patients;
                }

                else
                {
                    treatedP += doctors;
                    untreatedP += (patients - doctors);
                }

                //if (i % 3 == 0 && untreatedP > treatedP)
                //{
                //    doctors++;
                //}
            }

            Console.WriteLine("Treated patients: {0}.", treatedP);
            Console.WriteLine("Untreated patients: {0}.", untreatedP);
        }
    }
}
