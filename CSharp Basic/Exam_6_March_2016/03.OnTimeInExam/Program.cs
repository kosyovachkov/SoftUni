using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.OnTimeInExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivelHour = int.Parse(Console.ReadLine());
            int arrivelMinutes = int.Parse(Console.ReadLine());

            int examTime = examHour * 60 + examMinutes;
            int arrivelTime = arrivelHour * 60 + arrivelMinutes;

            int difference = Math.Abs(examTime - arrivelTime);

            if (examTime == arrivelTime)
            {
                Console.WriteLine("On time");
            }
            else if (examTime > arrivelTime)
            {
                if (difference <= 30 && difference > 0)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine("{0} minutes before the start", difference);
                }

                else if (difference > 30 && difference < 60)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine("{0} minutes before the start", difference);
                }

                else
                {
                    Console.WriteLine("Early");
                    Console.WriteLine("{0}:{1:00} hours before the start", examHour - arrivelHour, difference % 60);
                }
            }

            else
            {
                if (difference < 60 && difference > 0)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine("{0} minutes after the start", difference);
                }

                else
                {
                    Console.WriteLine("Late");
                    Console.WriteLine("{0}:{1:00} hours after the start", arrivelHour - examHour, difference % 60);
                }
            }
        }
    }
}
