using System;


public class CharityMarathon
{
    static void Main()
    {
        int days = int.Parse(Console.ReadLine());
        int participants = int.Parse(Console.ReadLine());
        int averrageLaps = int.Parse(Console.ReadLine());
        int lengthInMeters = int.Parse(Console.ReadLine());
        int trackCapacity = int.Parse(Console.ReadLine());
        decimal money = decimal.Parse(Console.ReadLine());

        int maxCapacity = trackCapacity * days;

        if (participants > maxCapacity)
        {
            participants = maxCapacity;
        }

        long fullLength = (long)participants * averrageLaps * lengthInMeters;//каствам един от множителите за да съм сигурен че връща long, а не int.
        long lengthKm = fullLength / 1000;

        decimal allMoney = lengthKm * money;

        Console.WriteLine($"Money raised: {allMoney:f2}");
    }
}

