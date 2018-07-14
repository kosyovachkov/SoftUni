using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    class Currency_Converter
    {
        static void Main(string[] args)
        {

            double sum = double.Parse(Console.ReadLine());
            string firstCurrency = Console.ReadLine();
            string secondCurrency = Console.ReadLine();

            double bgn = 1;
            double usd = 1.79549;
            double eur = 1.95583;
            double gbp = 2.53405;

            double convertedSum = 1;

            

            if (firstCurrency == "BGN" && secondCurrency == "USD")
            {
                convertedSum = sum / usd;
                Console.WriteLine("{0} {1}", Math.Round(convertedSum, 2), secondCurrency);
            }

            else if (firstCurrency == "BGN" && secondCurrency == "EUR")
            {
                convertedSum = sum / eur;
                Console.WriteLine("{0} {1}", Math.Round(convertedSum, 2), secondCurrency);
            }

            else if (firstCurrency == "BGN" && secondCurrency == "GBP")
            {
                convertedSum = sum / gbp;
                Console.WriteLine("{0} {1}", Math.Round(convertedSum, 2), secondCurrency);
            }

            //

            else if (firstCurrency == "USD" && secondCurrency == "BGN")
            {
                convertedSum = sum * usd;
                Console.WriteLine("{0} {1}", Math.Round(convertedSum, 2), secondCurrency);
            }

            else if (firstCurrency == "USD" && secondCurrency == "EUR")
            {
                convertedSum = sum * usd / eur;
                Console.WriteLine("{0} {1}", Math.Round(convertedSum, 2), secondCurrency);
            }

            else if (firstCurrency == "USD" && secondCurrency == "GBP")
            {
                convertedSum = sum * usd / gbp;
                Console.WriteLine("{0} {1}", Math.Round(convertedSum, 2), secondCurrency);
            }

            //

            else if (firstCurrency == "EUR" && secondCurrency == "BGN")
            {
                convertedSum = sum * eur;
                Console.WriteLine("{0} {1}", Math.Round(convertedSum, 2), secondCurrency);
            }

            else if (firstCurrency == "EUR" && secondCurrency == "USD")
            {
                convertedSum = sum * eur / usd;
                Console.WriteLine("{0} {1}", Math.Round(convertedSum, 2), secondCurrency);
            }

            else if (firstCurrency == "EUR" && secondCurrency == "GBP")
            {
                convertedSum = sum * eur / gbp;
                Console.WriteLine("{0} {1}", Math.Round(convertedSum, 2), secondCurrency);
            }

            //


            else if (firstCurrency == "GBP" && secondCurrency == "BGN")
            {
                convertedSum = sum * gbp;
                Console.WriteLine("{0} {1}", Math.Round(convertedSum, 2), secondCurrency);
            }

            else if (firstCurrency == "GBP" && secondCurrency == "USD")
            {
                convertedSum = sum * gbp / usd;
                Console.WriteLine("{0} {1}", Math.Round(convertedSum, 2), secondCurrency);
            }

            else if (firstCurrency == "GBP" && secondCurrency == "EUR")
            {
                convertedSum = sum * gbp / eur;
                Console.WriteLine("{0} {1}", Math.Round(convertedSum, 2), secondCurrency);
            }
        }
    }
}



/////////////////////////////////////////////////////////////////////////////////
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Currency_Converter
//{
//    class Currency_Converter
//    {
//        static void Main(string[] args)
//        {

//            double sum = double.Parse(Console.ReadLine());
//            string firstCurrency = Console.ReadLine();
//            string secondCurrency = Console.ReadLine();

//            double bgn = 1;
//            double usd = 1.79549;
//            double eur = 1.95583;
//            double gbp = 2.53405;

//            double convertedSum = 1;



//            if (firstCurrency == "BGN" && secondCurrency == "USD")
//            {
//                convertedSum = sum / usd;
//            }

//            else if (firstCurrency == "BGN" && secondCurrency == "EUR")
//            {
//                convertedSum = sum / eur;
//            }

//            else if (firstCurrency == "BGN" && secondCurrency == "GBP")
//            {
//                convertedSum = sum / gbp;
//            }

//            //

//            else if (firstCurrency == "USD" && secondCurrency == "BGN")
//            {
//                convertedSum = sum * usd;
//            }

//            else if (firstCurrency == "USD" && secondCurrency == "EUR")
//            {
//                convertedSum = sum * usd / eur;
//            }

//            else if (firstCurrency == "USD" && secondCurrency == "GBP")
//            {
//                convertedSum = sum * usd / gbp;
//            }

//            //

//            else if (firstCurrency == "EUR" && secondCurrency == "BGN")
//            {
//                convertedSum = sum * eur;
//            }

//            else if (firstCurrency == "EUR" && secondCurrency == "USD")
//            {
//                convertedSum = sum * eur / usd;
//            }

//            else if (firstCurrency == "EUR" && secondCurrency == "GBP")
//            {
//                convertedSum = sum * eur / gbp;
//            }

//            //


//            else if (firstCurrency == "GBP" && secondCurrency == "BGN")
//            {
//                convertedSum = sum * gbp;
//            }

//            else if (firstCurrency == "GBP" && secondCurrency == "USD")
//            {
//                convertedSum = sum * gbp / usd;
//            }

//            else if (firstCurrency == "GBP" && secondCurrency == "EUR")
//            {
//                convertedSum = sum * gbp / eur;

//            }


//            Console.WriteLine("{0} {1}", Math.Round(convertedSum, 2), secondCurrency);
//        }
//    }
//}


    ////////////////////////////////////////////////////////////////////////////////////


//          var stojnost = double.Parse(Console.ReadLine());
//          string whodwal = Console.ReadLine();
//          string izhwal = Console.ReadLine();
                        
//            if (whodwal == "USD") stojnost = stojnost* 1.79549;
//            else if (whodwal == "EUR") stojnost = stojnost* 1.95583;
//            else if (whodwal == "GBP") stojnost = stojnost* 2.53405;
 

//            if (izhwal == "USD") stojnost = stojnost / 1.79549;
//            else if (izhwal == "EUR") stojnost = stojnost / 1.95583;
//            else if (izhwal == "GBP") stojnost = stojnost / 2.53405;
 

//            Console.WriteLine(Math.Round(stojnost, 2));








    //////////////////////////////////////////////////////

//    using System;
 
 
//    class CurrencyConverter
//{


//    static void Main()
//    {
//        var amount = double.Parse(Console.ReadLine());
//        string firstCurrency = Console.ReadLine();
//        string secondCurrency = Console.ReadLine();

//        double value1 = CheckCurrency(firstCurrency);
//        double value2 = CheckCurrency(secondCurrency);

//        double result = (value1 / value2) * amount;
//        Console.WriteLine("{0} {1}", Math.Round(result, 2), secondCurrency);


//    }
//    static double CheckCurrency(string curr)
//    {
//        switch (curr)
//        {
//            case "BGN":
//                return 1;

//            case "USD":
//                return 1.79549;

//            case "EUR":
//                return 1.95583;
//            case "GBP":
//                return 2.53405;

//            default:
//                return 1;

//        }
//    }
//}