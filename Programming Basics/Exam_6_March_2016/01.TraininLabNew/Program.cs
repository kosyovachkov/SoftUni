using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.TraininLabNew
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            w = w * 100;
            h = h * 100-100;

            double numberOfDesks = Math.Floor(h / 70);
            double nimberOfColumns = Math.Floor(w / 120);
            double allDesks = numberOfDesks * nimberOfColumns - 3;

            Console.WriteLine(allDesks);


        }
    }
}
