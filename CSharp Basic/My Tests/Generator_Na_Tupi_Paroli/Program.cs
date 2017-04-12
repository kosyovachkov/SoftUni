using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace ConsoleApplication2

{

    class Program

    {

        static void Main(string[] args)

        {

            var n = int.Parse(Console.ReadLine());

            var l = int.Parse(Console.ReadLine());



            for (int a = 1; a < n; a++)

            {

                for (int b = 1; b < n; b++)

                {

                    for (var c = 'a'; c < 'a' + l; c++)

                    {

                        for (var d = 'a'; d < 'a' + l; d++)

                        {

                            for (int e = Math.Max(a, b); e < n; e++)

                            {

                                Console.Write("{0}{1}{2}{3}{4} ", a, b, c, d, e);



                            }

                        }

                    }

                }



            }

        }



        /// tova e drugo reshenie, koeto e podobno

//        int n = int.Parse(Console.ReadLine());
//        int L = int.Parse(Console.ReadLine());
 
//        for (int symbol1 = 1; symbol1 <= n; symbol1++)
//        {
//            for (int symbol2 = 1; symbol2 <= n; symbol2++)
//            {
//                for (char symbol3 = (char)97; symbol3 <= (char)L+96; symbol3++)
//                {
//                    for (char symbol4 = (char)97; symbol4 <=(char) L + 96; symbol4++)
//                    {
//                        for (int symbol5 = 1; symbol5 <= n; symbol5++)
//                        {
//                            if (symbol5 > symbol1 && symbol5 > symbol2)
//                            {
//                                Console.Write("{0}{1}{2}{3}{4} ", symbol1, symbol2, symbol3, symbol4, symbol5);
 
//                            }
//}
//                    }
//                }
//            }
//        }

    }

}