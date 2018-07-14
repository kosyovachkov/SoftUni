using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int leftFoodKg = int.Parse(Console.ReadLine());
            double dogFood = double.Parse(Console.ReadLine());
            double catFood = double.Parse(Console.ReadLine());
            double tortueFood = double.Parse(Console.ReadLine());

            double dogNeededFood = dogFood * days;
            double catNeededFood = catFood * days;
            double tortueNeededFood = tortueFood / 1000 * days;

            double allNeededFood = dogNeededFood + catNeededFood + tortueNeededFood;

            if (leftFoodKg>=allNeededFood)
            {
                Console.WriteLine("{0} kilos of food left.", Math.Floor(leftFoodKg-allNeededFood));
            }

            else
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(allNeededFood - leftFoodKg));
            }
          
        }
    }
}
