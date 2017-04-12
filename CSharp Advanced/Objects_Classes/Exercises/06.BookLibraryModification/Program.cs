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


        public Library()
        {
           // this.Name = name;
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

            Library finalLibrary = new Library();

           // Dictionary<string, DateTime> finalDictionary = new Dictionary<string, DateTime>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                Book forLibrary = Book.ReadBook(input);
                finalLibrary.Books.Add(forLibrary);
            }

            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);

            foreach (var item in finalLibrary.Books.Where(x => x.ReleaseDate>startDate).OrderBy(x => x.ReleaseDate).ThenBy(x => x.Tittle))
            {
                Console.WriteLine("{0} -> {1:dd.MM.yyyy}", item.Tittle, item.ReleaseDate);
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
