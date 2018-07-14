using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.TheaPhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPictures = int.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            int usefullPicturesPercentage = int.Parse(Console.ReadLine());
            int uploadTime = int.Parse(Console.ReadLine());

            long allFilterTime = (long)numberOfPictures * filterTime;// - каствам към long, защото може да прескочи int-a
            int goodPictures = (int)Math.Ceiling(numberOfPictures * (usefullPicturesPercentage / 100.00));
            long allUploadTime = (long)goodPictures * uploadTime;// - каствам към long, защото може да прескочи int-a

            long allTimeSeconds = allFilterTime + allUploadTime;

            TimeSpan time = TimeSpan.FromSeconds(allTimeSeconds);
            Console.WriteLine("{0}:{1:00}:{2:00}:{3:00}", time.Days, time.Hours, time.Minutes, time.Seconds);

            //int days = (int)allTimeSeconds / 86400;
            //int hours = (int)allTimeSeconds / 3600;
            //if (hours >= 24)
            //{
            //    hours = hours % 24;
            //}
            //int minutes = (int)allTimeSeconds / 60;
            //if (minutes >= 60)
            //{
            //    minutes = minutes % 60;
            //}
            //int seconds = (int)allTimeSeconds % 60;

            //Console.WriteLine("{0}:{1:00}:{2:00}:{3:00}", days, hours, minutes, seconds);

        }
    }
}
