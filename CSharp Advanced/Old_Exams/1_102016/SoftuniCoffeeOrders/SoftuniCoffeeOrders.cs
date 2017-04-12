using System;
using System.Collections.Generic;
using System.Globalization;

public class SoftuniCoffeeOrders
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        decimal totalSum = 0;
        List<decimal> allSums = new List<decimal>();

        for (int i = 0; i < n; i++)
        {
            decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
            DateTime curDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);

            int daysInMonth = DateTime.DaysInMonth(curDate.Year, curDate.Month);

            int numberOfCapsules = int.Parse(Console.ReadLine());

            decimal curSum = pricePerCapsule * numberOfCapsules * daysInMonth;
            totalSum += curSum;

            allSums.Add(curSum);


        }

        foreach (var item in allSums)
        {
            Console.WriteLine($"The price for the coffee is: ${item:f2}");
        }

        Console.WriteLine($"Total: ${totalSum:f2}");
    }
}

