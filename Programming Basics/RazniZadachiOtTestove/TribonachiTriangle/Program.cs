using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TribonachiTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal n1 = int.Parse(Console.ReadLine());
            decimal n2 = int.Parse(Console.ReadLine());
            decimal n3 = int.Parse(Console.ReadLine());
            int allRows = int.Parse(Console.ReadLine());

            decimal currentTribonachi = 0;

            Console.WriteLine(n1);
            Console.WriteLine(n2 + " " + n3);

            for (int rows = 3; rows <= allRows; rows++)
            {
                for (int i = 1; i <= rows; i++)
                {
                    currentTribonachi = n1 + n2 + n3;
                    Console.Write(currentTribonachi + " ");
                    n1 = n2;
                    n2 = n3;
                    n3 = currentTribonachi;

                }
                Console.WriteLine();
            }
        }
    }
}
