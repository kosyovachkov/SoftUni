using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _05.BookLibrary
{
    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }


        public Library(string name)
        {
            this.Name = name;
            this.Books = new List<Book>();
        }


    }

    class Book
    {
        public string Tittle { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }

        public static Book ReadBook(string[] input)
        {
            Book newBook = new Book();
            newBook.Tittle = input[0];
            newBook.Author = input[1];
            newBook.Publisher = input[2];
            newBook.ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            newBook.ISBN = input[4];
            newBook.Price = decimal.Parse(input[5]);

            return newBook;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            //Library finalLibrary = new Library("test");

            Dictionary<string, decimal> finalResult = new Dictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                Book forLibrary = Book.ReadBook(input);

                if (!finalResult.ContainsKey(forLibrary.Author))
                {
                    finalResult[forLibrary.Author] = forLibrary.Price;
                }

                else
                {
                    finalResult[forLibrary.Author] += forLibrary.Price;
                }
            }

            foreach (var item in finalResult.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine("{0} -> {1:f2}", item.Key, item.Value);
            }






            //string[] authors = finalLibrary.Books.Select(x => x.Author).OrderBy(x => x).Distinct().ToArray();

            //foreach (var item in authors)
            //{
            //    var bookPrices = finalLibrary.Books.Where(x => x.Author == item).Select(x => x.Price).Sum();
            //    Console.WriteLine("{0} -> {1}", item, bookPrices);
            //}





        }
    }


}
