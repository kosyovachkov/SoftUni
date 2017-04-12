using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fishing
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceScumria = double.Parse(Console.ReadLine());
            double priceCaca = double.Parse(Console.ReadLine());
            double kgPalamud = double.Parse(Console.ReadLine());
            double kgSafrid = double.Parse(Console.ReadLine());
            int kgMidi = int.Parse(Console.ReadLine());

            double pricePalamud = priceScumria * 1.6;
            double priceSafrid = 1.8 * priceCaca;
            double priceMidi = 7.5;

            double price = (pricePalamud * kgPalamud) + (priceSafrid * kgSafrid) + (priceMidi * kgMidi);

            Console.WriteLine("{0:f2}", price);
        }
    }
}
