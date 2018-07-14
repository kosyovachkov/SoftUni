using System;
using System.Collections.Generic;
using System.Linq;


namespace SoftUniWaterSupplies
{
    class SoftUniWaterSupplies
    {
        static void Main()
        {
            double amountOfWater = double.Parse(Console.ReadLine());
            double[] bottles = Console.ReadLine().Split().Select(double.Parse).ToArray();
            double botlleCapacity = double.Parse(Console.ReadLine());

            int currentIndex = -1;

            if (amountOfWater % 2 == 0)
            {
                for (int i = 0; i < bottles.Length; i++)
                {
                    amountOfWater = amountOfWater - (botlleCapacity - bottles[i]);
                    if (amountOfWater < 0)
                    {
                        amountOfWater = amountOfWater + (botlleCapacity - bottles[i]);
                        currentIndex = i;
                        break;
                    }
                }

                if (currentIndex == -1)
                {
                    Console.WriteLine("Enough water!");
                    Console.WriteLine("Water left: {0}l.", amountOfWater);
                }

                else
                {
                    double neededForBottles = 0;
                    int count = 0;
                    List<int> index = new List<int>();
                    for (int i = currentIndex; i < bottles.Length; i++)
                    {
                        neededForBottles = neededForBottles + (botlleCapacity - bottles[i]);
                        count++;
                        index.Add(i);
                    }

                    neededForBottles -= amountOfWater;
                    string indexes = string.Join(", ", index);

                    Console.WriteLine("We need more water!");
                    Console.WriteLine("Bottles left: {0}", count);
                    Console.WriteLine("With indexes: {0}", indexes);
                    Console.WriteLine("We need {0} more liters!", neededForBottles);


                }


            }

            else
            {
                for (int i = bottles.Length - 1; i >= 0; i--)
                {
                    amountOfWater = amountOfWater - (botlleCapacity - bottles[i]);
                    if (amountOfWater < 0)
                    {
                        amountOfWater = amountOfWater + (botlleCapacity - bottles[i]);
                        currentIndex = i;
                        break;
                    }
                }

                if (currentIndex == -1)
                {
                    Console.WriteLine("Enough water!");
                    Console.WriteLine("Water left: {0}l.", amountOfWater);
                }

                else
                {
                    double neededForBottles = 0;
                    int count = 0;
                    List<int> index = new List<int>();
                    for (int i = currentIndex; i >= 0; i--)
                    {
                        neededForBottles = neededForBottles + (botlleCapacity - bottles[i]);
                        count++;
                        index.Add(i);
                    }

                    neededForBottles -= amountOfWater;
                    string indexes = string.Join(", ", index);

                    Console.WriteLine("We need more water!");
                    Console.WriteLine("Bottles left: {0}", count);
                    Console.WriteLine("With indexes: {0}", indexes);
                    Console.WriteLine("We need {0} more liters!", neededForBottles);
                }
            }
        }
    }
}
