using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int minimumV = int.MaxValue;

            for (int i = 0; i < number; i++)
            {
                int chislo = int.Parse(Console.ReadLine());
                if (chislo < minimumV)
                {
                    minimumV = chislo;
                }
            }

            Console.WriteLine(minimumV);
        }
    }
}
