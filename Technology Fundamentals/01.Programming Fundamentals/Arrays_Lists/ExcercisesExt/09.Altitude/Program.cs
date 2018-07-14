using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Altitude
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            long altitude = long.Parse(input[0]);
            bool isCrashed = false;

            for (int i = 1; i < input.Length; i += 2)
            {
                string command = input[i];
                long diff = long.Parse(input[i + 1]);

                switch (command)
                {
                    case "up":
                        altitude += diff;
                        break;
                    case "down":
                        altitude -= diff;
                        break;
                    default:
                        break;
                }
                if (altitude <= 0)
                {
                    isCrashed = true;
                    break;
                }
            }

            if (isCrashed)
            {
                Console.WriteLine("crashed");
            }

            else
            {
                Console.WriteLine($"got through safely. current altitude: {altitude}m");
            }
        }
    }
}
