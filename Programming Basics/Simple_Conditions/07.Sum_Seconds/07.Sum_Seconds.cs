using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerOne = int.Parse(Console.ReadLine());
            int playerTwo = int.Parse(Console.ReadLine());
            int playerThree = int.Parse(Console.ReadLine());

            int fullTime = playerOne + playerTwo + playerThree;

            int seconds = fullTime % 60;
            int minutes = fullTime / 60;

            Console.WriteLine("{0}:{1:00}", minutes, seconds);
        }
    }
}
