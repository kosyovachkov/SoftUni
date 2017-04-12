using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _01.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            DateTime input = DateTime.ParseExact(inputText, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(input.DayOfWeek); 
        }
    }
}
