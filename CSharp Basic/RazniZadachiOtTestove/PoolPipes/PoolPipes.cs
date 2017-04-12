using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolPipes
{
    class PoolPipes
    {
        static void Main(string[] args)
        {
            double volume = double.Parse(Console.ReadLine());
            double pipe1 = double.Parse(Console.ReadLine());
            double pipe2 = double.Parse(Console.ReadLine());
            double restHours = double.Parse(Console.ReadLine());

            double pipeoneFlow = pipe1 * restHours;
            double pipetwoFlow = pipe2 * restHours;
            double volumeNow = pipeoneFlow + pipetwoFlow;
            double pipeonePercent = Math.Floor(pipeoneFlow / volumeNow * 100);
            double pipetwoPercent = Math.Floor(pipetwoFlow / volumeNow * 100);


            double volumePercent = Math.Floor(volumeNow / volume * 100);

            if (volumeNow <= volume)
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", volumePercent, pipeonePercent, pipetwoPercent);
            }

            else
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", restHours, volumeNow - volume);
            }
        }
    }
}
