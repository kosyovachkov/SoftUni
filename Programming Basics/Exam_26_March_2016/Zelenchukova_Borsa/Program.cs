using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zelenchukova_Borsa
{
    class Program
    {
        static void Main(string[] args)
        {

            double priceVegetables = double.Parse(Console.ReadLine());
            double priceFruits = double.Parse(Console.ReadLine());
            int weightVegetables = int.Parse(Console.ReadLine());
            int weightFruits = int.Parse(Console.ReadLine());


            double fullPriceVegetables = priceVegetables * weightVegetables;
            double fullPriceFruits = priceFruits * weightFruits;

            double priceLeva = fullPriceFruits + fullPriceVegetables;
            double priceEuro = priceLeva / 1.94;

            Console.WriteLine(priceEuro);
        }
    }
}
