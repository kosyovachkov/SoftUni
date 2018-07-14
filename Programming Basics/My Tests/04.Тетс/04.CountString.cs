using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Тетс
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string town = Console.ReadLine().ToLower();   

            string text = n.ToString();

            char secondDigit = town[2];

            Console.WriteLine(secondDigit);


        }
    }
}
