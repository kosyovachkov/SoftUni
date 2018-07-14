using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int workDays = int.Parse(Console.ReadLine());
            double payMoneyForDay = double.Parse(Console.ReadLine());
            double usdRates = double.Parse(Console.ReadLine());

            double profitForYear = workDays * payMoneyForDay * 12;
            double bonus = workDays * payMoneyForDay * 2.5;
            double brutoProfitForYear = profitForYear + bonus;
            double taxForYear = brutoProfitForYear * 0.25;
            double netoProftForYear = brutoProfitForYear - taxForYear;

            double usdToLev = netoProftForYear * usdRates;

            double netoProfitForDay = usdToLev / 365;

            Console.WriteLine("{0:F2}", netoProfitForDay);


        }
    }
}


//Решена за 11.44 минути