using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sequenece_2K_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());



            for (int i = 1; i <= n; i = i * 2 + 1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
