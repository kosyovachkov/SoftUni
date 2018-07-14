using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnduranceRally
{
    public class EnduranceRally
    {
        public static void Main()
        {
            string[] racers = Console.ReadLine().Split();
            double[] trackZones = Console.ReadLine().Split().Select(double.Parse).ToArray();
            int[] checkpoints = Console.ReadLine().Split().Select(int.Parse).ToArray();

            foreach (var racer in racers)
            {
                double startFuel = racer[0];
                bool isCheckpoint = false;
                int reachedIndex = 0;

                for (int i = 0; i < trackZones.Length; i++)
                {
                    reachedIndex = i;

                    for (int j = 0; j < checkpoints.Length; j++)
                    {
                        if (i == checkpoints[j])
                        {
                            isCheckpoint = true;
                            break;
                        }
                    }

                    if (isCheckpoint)
                    {
                        startFuel += trackZones[i];
                        isCheckpoint = false;
                    }
                    else
                    {
                        startFuel -= trackZones[i];
                    }

                    if (startFuel <= 0)
                    {
                        break;
                    }
                }

                if (startFuel > 0)
                {
                    Console.WriteLine($"{racer} - fuel left {startFuel:f2}");
                }
                else
                {
                    Console.WriteLine($"{racer} - reached {reachedIndex}");
                }
            }
        }
    }
}


