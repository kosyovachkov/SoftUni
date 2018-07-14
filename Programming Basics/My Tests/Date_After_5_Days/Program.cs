using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date_After_5_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());

            //int daysOfMonth = 0;
            //int daysAfter = 0;
            int curMonth = 0;
            int curDay = 0;

            if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10)
            {
                //daysOfMonth = 31;
                if ((day + 5)>31)
                {
                    curDay = day + 5 - 31;
                    curMonth = month + 1;
                }

                else
                {
                    curDay = day + 5;
                    curMonth = month;
                }
                
            }

            else if (month == 12)
            {
                if ((day + 5) > 31)
                {
                    curDay = day + 5 - 31;
                    curMonth = month - 11;
                }

                else
                {
                    curDay = day + 5;
                    curMonth = month;
                }
            }

            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                if ((day + 5) > 30)
                {
                    curDay = day + 5 - 30;
                    curMonth = month + 1;
                }

                else
                {
                    curDay = day + 5;
                    curMonth = month;
                }
            }

            else
            {
                if ((day + 5) > 28)
                {
                    curDay = day + 5 - 28;
                    curMonth = month + 1;
                }

                else
                {
                    curDay = day + 5;
                    curMonth = month;
                }
            }

            Console.WriteLine("{0}.{1:00}", curDay, curMonth);
        }
    }
}
