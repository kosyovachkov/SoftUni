using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_nachi
{
    class Program
    {
        static void Main(string[] args)
        {
            char firtsLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());

            int fisrtNum = 0;
            int secNum = 0;
            switch (firtsLetter)
            {

                case 'A': fisrtNum = 1; secNum = 1;
                    break;


                default:
                    break;
            }
        }
    }
}
