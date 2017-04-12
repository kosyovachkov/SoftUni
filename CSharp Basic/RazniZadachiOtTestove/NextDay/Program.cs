using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NextDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());

           

            DateTime nowDate = new DateTime(year, month, day);
            DateTime nextDay = nowDate.AddDays(1);
            string format = "d.M.yyyy";


            Console.WriteLine(nextDay.ToString(format));

        }
    }
}

//d - ден без водеща 0, dd - с водеща 0
//М - месец без водеща 0, MM - с водеща 0


    //druga zadacha
//    using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
 
//namespace _1000_Days_After_Birth
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string birthday = Console.ReadLine();

//            DateTime convertDate = DateTime.ParseExact(birthday, "dd-MM-yyyy", null);

//            DateTime afterDays = convertDate.AddDays(999);

//            Console.WriteLine(afterDays.ToString("dd-MM-yyyy"));
//        }
//    }
//}
