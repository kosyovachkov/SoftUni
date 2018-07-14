using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Trade_Comission
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine().ToLower();
            double sales = double.Parse(Console.ReadLine());

            double comission = -1;

            if (town == "sofia")
            {
                if (0 <= sales && sales <=500)
                {
                    comission = sales * 0.05;
                }

                else if (500 < sales && sales <= 1000)
                {
                    comission = sales * 0.07;
                }

                else if (100 < sales && sales <= 10000)
                {
                    comission = sales * 0.08;
                }

                else 
                {
                    comission = sales * 0.12;
                }
            }

            if (town == "varna")
            {
                if (0 <= sales && sales <= 500)
                {
                    comission = sales * 0.045;
                }

                else if (500 < sales && sales <= 1000)
                {
                    comission = sales * 0.075;
                }

                else if (100 < sales && sales <= 10000)
                {
                    comission = sales * 0.1;
                }

                else
                {
                    comission = sales * 0.13;
                }
            }

            if (town == "plovdiv")
            {
                if (0 <= sales && sales <= 500)
                {
                    comission = sales * 0.055;
                }

                else if (500 < sales && sales <= 1000)
                {
                    comission = sales * 0.08;
                }

                else if (100 < sales && sales <= 10000)
                {
                    comission = sales * 0.12;
                }

                else
                {
                    comission = sales * 0.145;
                }
            }

            if (comission < 0)
            {
                Console.WriteLine("error");
            }

            else
            {
                Console.WriteLine(comission);
            }
        }
    }
}
