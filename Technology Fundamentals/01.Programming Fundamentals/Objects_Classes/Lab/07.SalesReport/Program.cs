using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SalesReport
{
    class Sale
    {
        public string town { get; set; }
        public string product { get; set; }
        public decimal price { get; set; }
        public double quantity { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            SortedDictionary<string, double> finalReport = new SortedDictionary<string, double>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string town = input[0];
                double townSales = (double.Parse(input[2]) * double.Parse(input[3]));

                if (finalReport.ContainsKey(town))
                {
                    finalReport[town] += townSales;

                }
                else
                {
                    finalReport.Add(town, townSales);
                }
            }

            foreach (var item in finalReport)
            {
                Console.WriteLine($"{item.Key} -> {item.Value:f2}");
            }

        }
    }


}
