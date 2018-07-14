using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniCoffeeSupplies
{
    public class SoftUniCoffeeSupplies
    {
        static void Main()
        {
            string[] delimeters = Console.ReadLine().Split();
            string nameDelimeter = delimeters[0];
            string coffeeDelimeter = delimeters[1];

            Dictionary<string, string> namesAndCoffee = new Dictionary<string, string>();
            Dictionary<string, long> coffeeAndCount = new Dictionary<string, long>();

            string firstInput = Console.ReadLine();
            while (!firstInput.Equals("end of info"))
            {
                if (firstInput.Contains(nameDelimeter))
                {
                    //firstInput = firstInput.Replace(nameDelimeter, "/");
                    string[] input = firstInput.Split(new string[] { nameDelimeter }, StringSplitOptions.None);
                    string name = input[0];
                    string coffee = input[1];

                    if (!namesAndCoffee.ContainsKey(name))
                    {
                        namesAndCoffee[name] = coffee;
                    }
                }

                else if (firstInput.Contains(coffeeDelimeter))
                {
                    //firstInput = firstInput.Replace(coffeeDelimeter, "/");
                    string[] input = firstInput.Split(new string[] { coffeeDelimeter }, StringSplitOptions.None);
                    string coffee = input[0];
                    long quantity = long.Parse(input[1]);

                    if (!coffeeAndCount.ContainsKey(coffee))
                    {
                        coffeeAndCount[coffee] = 0;
                    }

                    coffeeAndCount[coffee] += quantity;
                }

                firstInput = Console.ReadLine();
            }

            foreach (var coffee in namesAndCoffee)
            {
                if (!coffeeAndCount.Keys.Contains(coffee.Value))
                {
                    Console.WriteLine($"Out of {coffee.Value}");
                }
            }

            string input2 = Console.ReadLine();

            while (!input2.Equals("end of week"))
            {
                string[] input = input2.Split();
                string name = input[0];
                long count = long.Parse(input[1]);

                foreach (var kvp in namesAndCoffee)
                {
                    if (kvp.Key.Equals(name))
                    {
                        coffeeAndCount[kvp.Value] -= count;
                        if (coffeeAndCount[kvp.Value] <= 0)
                        {
                            Console.WriteLine($"Out of {kvp.Value}");
                            //coffeeAndCount.Remove(kvp.Value);
                        }
                    }
                }

                input2 = Console.ReadLine();
            }

            Console.WriteLine("Coffee Left:");
            foreach (var item in coffeeAndCount.Where(x => x.Value > 0).OrderByDescending(x => x.Value))
            {
                Console.WriteLine("{0} {1}", item.Key, item.Value);
            }

            Console.WriteLine("For:");

            foreach (var kvp in namesAndCoffee.OrderBy(x => x.Value).ThenByDescending(x => x.Key))
            {

                if (coffeeAndCount.Keys.Contains(kvp.Value))
                {
                    if (coffeeAndCount[kvp.Value] > 0)
                    {
                        Console.WriteLine("{0} {1}", kvp.Key, kvp.Value);
                    }

                }
            }
        }
    }
}
