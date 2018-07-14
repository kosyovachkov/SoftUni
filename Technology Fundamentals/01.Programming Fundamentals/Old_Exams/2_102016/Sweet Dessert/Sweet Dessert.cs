using System;
using System.Collections.Generic;
using System.Linq;

public class SweetDessert
{
    static void Main()
    {
        decimal money = decimal.Parse(Console.ReadLine());
        int numbreOfGuets = int.Parse(Console.ReadLine());
        decimal bananasPrice = decimal.Parse(Console.ReadLine());
        decimal eggsPrice = decimal.Parse(Console.ReadLine());
        decimal berriesPrice = decimal.Parse(Console.ReadLine());

        int portionIndex = 0;

        
        if (numbreOfGuets < 6&&numbreOfGuets>0)
        {
            portionIndex = 1;
        }

        else if (numbreOfGuets % 6 == 0)
        {
            portionIndex = numbreOfGuets / 6;
        }
        else if (numbreOfGuets % 6 != 0)
        {
            portionIndex = numbreOfGuets / 6 + 1;
        }

        decimal neededSum = portionIndex * ((2 * bananasPrice) + (4 * eggsPrice) + (0.2M * berriesPrice));

        if (money>=neededSum)
        {
            Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv.", neededSum);
        }

        else
        {
            Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.", neededSum-money);
        }

    }
}

