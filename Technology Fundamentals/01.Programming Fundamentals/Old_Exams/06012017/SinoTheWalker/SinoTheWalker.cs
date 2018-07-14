using System;
using System.Globalization;
using System.Collections.Generic;


public class SinoTheWalker
{
    static void Main()
    {
        string input = Console.ReadLine();
        DateTime dateNow = DateTime.ParseExact(input, "HH:mm:ss", CultureInfo.InvariantCulture);
        int steps = int.Parse(Console.ReadLine()) % 86400;
        int seconds = int.Parse(Console.ReadLine()) % 86400;

        //86400 секунди = 1 ден
        //Махаме целите дни, ако някой ни ги подава като вход
        //1 крачка * 86400 секунди = 1 ден време
        //86400 крачки * 1 секунда = 1 ден време
        //А дните ги махаме, защото за крайния резултат е едно и също дали са минали 1000 дни и 3 часа или само 3 часа.
        //Истинският проблем е overflow при умножението steps* seconds при големи числа, но просто е по-удобно да си пооправиш входните данни преди да изчисляваш нататък.

        long stepSeconds = (long)steps * seconds;
        DateTime newDate = dateNow.AddSeconds(stepSeconds);
        string currentdate = newDate.TimeOfDay.ToString();
        Console.WriteLine($"Time Arrival: {currentdate}");
        //Console.WriteLine("Time Arrival: {0:00}:{1:00}:{2:00}", newDate.Hour, newDate.Minute, newDate.Second); - и това е вярно

        
        
        
        
        //Решение с TimeSpan

        //TimeSpan time = TimeSpan.Parse(Console.ReadLine());
        //int step = int.Parse(Console.ReadLine()) % 86400;
        //int seconds = int.Parse(Console.ReadLine()) % 86400;

        //long sumStep = step * seconds;
        //TimeSpan asdf = TimeSpan.FromSeconds(sumStep);

        //TimeSpan timeSum = time + asdf;

        //Console.WriteLine("Time Arrival: {0:hh\\:mm\\:ss}", timeSum);
    }
}

