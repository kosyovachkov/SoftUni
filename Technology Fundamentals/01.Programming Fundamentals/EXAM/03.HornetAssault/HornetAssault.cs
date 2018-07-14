namespace _03.HornetAssault
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class HornetAssault
    {
        public static void Main()
        {
            List<long> bees = Console.ReadLine().Split().Select(long.Parse).ToList();
            List<long> hornet = Console.ReadLine().Split().Select(long.Parse).ToList();

            for (int i = 0; i < bees.Count; i++)
            {
                long sumOfHornetPower = hornet.Sum();

                if (sumOfHornetPower > bees[i])
                {
                    bees.RemoveAt(i);
                    i--;
                }
                else if (sumOfHornetPower == bees[i])
                {
                    bees.RemoveAt(i);
                    hornet.RemoveAt(0);
                    i--;
                }
                else if (sumOfHornetPower < bees[i])
                {
                    bees[i] = bees[i] - sumOfHornetPower;
                    hornet.RemoveAt(0);
                }

                if (hornet.Count==0)
                {
                    break;
                }
            }

            if (bees.Count > 0)
            {
                Console.WriteLine(string.Join(" ", bees));
            }

            else if (hornet.Count > 0)
            {
                Console.WriteLine(string.Join(" ", hornet));
            }
        }
    }
}
