using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnTimeForExam
{
    class OnTimeForExam
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arrivelHour = int.Parse(Console.ReadLine());
            int arrivelMinute = int.Parse(Console.ReadLine());

            int examTime = examHour * 60 + examMinute;
            int arrivelTime = arrivelHour * 60 + arrivelMinute;
            int differentHours = Math.Abs((examTime - arrivelTime) / 60);
            int differentMinutes = Math.Abs((examTime - arrivelTime) % 60);

            if (arrivelTime > examTime)
            {
                Console.WriteLine("Late");
                if (arrivelTime - examTime >= 60)
                {
                    Console.WriteLine("{0}:{1:00} hours after the start", differentHours, differentMinutes);
                }
                else if (arrivelTime - examTime < 60 && arrivelTime - examTime > 0)
                {
                    Console.WriteLine("{0} minutes after the start", differentMinutes);
                }
            }
            else if (arrivelTime == examTime)
            {
                Console.WriteLine("On time");
            }

            else
            {

                if (examTime - arrivelTime >= 60)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine("{0}:{1:00} hours before the start", differentHours, differentMinutes);
                }
                else if (examTime-arrivelTime < 60 && examTime-arrivelTime > 30)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine("{0} minutes before the start", differentMinutes);
                }

                else 
                {
                    Console.WriteLine("On time");
                    Console.WriteLine("{0} minutes before the start", differentMinutes);
                }
            }
        }
    }
}
