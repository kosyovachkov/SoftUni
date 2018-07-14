using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            string[] phrases = new string[] { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };

            string[] events = new string[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles.I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };

            string[] authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random rnd = new Random();

            



            for (int i = 0; i < n; i++)
            {
                string phrase = phrases[rnd.Next(0, phrases.Length)];
                string eventN = events[rnd.Next(0, events.Length)];
                string author = authors[rnd.Next(0, authors.Length)];
                string city = cities[rnd.Next(0, cities.Length)];

                Console.WriteLine($"{phrase} {eventN} {author} - {city}");
            }
           

            //for (int p = 0; p < n; p++)
            //{

            
            //for (int i = 0; i < phrases.Length; i++)
            //{
            //    for (int j = 0; j < events.Length; j++)
            //    {

            //        for (int k = 0; k < authors.Length; k++)
            //        {

            //            for (int l = 0; l < cities.Length; l++)

            //            {
            //                phrase = phrases[rnd.Next(i)];
            //                eventN = events[rnd.Next(j)];
            //                author = authors[rnd.Next(k)];
            //                city = cities[rnd.Next(l)];
                            
            //            }

            //        }
            //    }
            //}

            //    Console.WriteLine($"{phrase} {eventN} {author} - {city}");
            //}
        }
    }
}
