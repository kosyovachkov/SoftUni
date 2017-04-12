using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write(new String(' ', n+1));
            Console.WriteLine("|");

            for (int i = 1; i < n + 1; i++)
            {
                Console.Write(new String(' ', n - i));
                Console.Write(new String('*', i));
                Console.Write(" | ");
                Console.WriteLine(new String('*', i));
            }

        }
    }
}
