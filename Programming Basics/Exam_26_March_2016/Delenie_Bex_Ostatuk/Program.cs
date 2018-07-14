using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delenie_Bex_Ostatuk
{
    class Program
    {
        static void Main(string[] args)
        {

            int numbers = int.Parse(Console.ReadLine());

            double countTwo = 0;
            double countThree = 0;
            double countFour = 0;

            


            for (int i = 0; i < numbers; i++)
            {
                int chislo = int.Parse(Console.ReadLine());

                if (chislo % 2 == 0)
                {
                    countTwo += 1;
                }
                if (chislo % 3 == 0)
                {
                    countThree += 1;
                }

                if (chislo % 4 == 0)
                {
                    countFour += 1;
                }
            }
            double devideTwo = countTwo / numbers * 100;
            double devideThree = countThree / numbers * 100;
            double devideFour = countFour / numbers * 100;


            Console.WriteLine("{0:f2}%", devideTwo);
            Console.WriteLine("{0:f2}%", devideThree);
            Console.WriteLine("{0:f2}%", devideFour);
        }
    }
}
