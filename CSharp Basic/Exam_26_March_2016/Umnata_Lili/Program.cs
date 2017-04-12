using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umnata_Lili
{
    class Program
    {
        static void Main(string[] args)
        {
            int ageLily = int.Parse(Console.ReadLine());
            double priceForLongery = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            double savedMoney = 0;
            double newMoney = 0;
            double allMoney = 0;
            int receivedToys = 0;


            for (int i = 1; i <= ageLily; i++)
            {
                if (i % 2 != 0)
                {
                    receivedToys++;
                }

                else
                {
                    newMoney = 10;
                    savedMoney = newMoney + savedMoney;
                    allMoney += savedMoney; 
                }
            }

            allMoney = (allMoney - (ageLily / 2)) + (receivedToys * toyPrice) ;

            if (allMoney >= priceForLongery)
            {
                Console.WriteLine("Yes! {0:f2}", allMoney - priceForLongery);
            }

            else
            {
                Console.WriteLine("No! {0:f2}", Math.Abs(allMoney - priceForLongery));
            }

        }
    }
}
