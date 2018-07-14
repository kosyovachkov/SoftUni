using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.AndreyBilliard
{

    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        //public Product(string name, decimal price)
        //{
        //    this.Name = name;
        //    this.Price = price;
        //}

        public Product ReadProduct(string[] input)
        {
            Product newProduct = new Product();
            newProduct.Name = input[0];
            newProduct.Price = decimal.Parse(input[1]);
            return newProduct;
        }


    }

    class Order
    {
        public string Name { get; set; }
        public int Quantity { get; set; }

        public static Order ReadOrder(string[] input)
        {
            Order newOrder = new Order();
            newOrder.Name = input[0];
            newOrder.Quantity = int.Parse(input[1]);
            return newOrder;
        }
    }

    class Custumer

    {
        public string Name { get; set; }
        public Dictionary<string, decimal> ShopList { get; set; }
        public decimal Bill { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, decimal> productsPrices = new Dictionary<string, decimal>();

            for (int i = 0; i < n; i++)
            {
                string[] productInput = Console.ReadLine().Split('-');
                if (!productsPrices.ContainsKey(productInput[0]))
                {
                    productsPrices.Add(productInput[0], decimal.Parse(productInput[1]));
                }
                productsPrices[productInput[0]] = decimal.Parse(productInput[1]);
            }

            string inputNameAndList = Console.ReadLine();

            List<Custumer> students = new List<Custumer>();

            while (inputNameAndList != "end of clients")
            {
                Dictionary<string, decimal> shopList = new Dictionary<string, decimal>();

                string[] arrayNameAndList = inputNameAndList.Split('-',',');
                string name = arrayNameAndList[0];
                //string[] arrayShopList = arrayNameAndList[1].Split(',');
                string listProductName = arrayNameAndList[1];
                decimal listProductQuantity = decimal.Parse(arrayNameAndList[2]);

                foreach (var item in productsPrices)
                {
                    if (listProductName == item.Key)
                    {

                        if (!shopList.ContainsKey(listProductName))
                        {
                            shopList.Add(listProductName, listProductQuantity);
                        }

                        else
                        {
                            shopList[listProductName] += (listProductQuantity);
                        }

                        Custumer student = new Custumer();

                        if (!students.Contains(student))
                        {
                            student.Name = name;
                            student.ShopList = shopList;
                            student.Bill = listProductQuantity * item.Value;
                            students.Add(student);
                        }

                        else
                        {

                            student.Bill += listProductQuantity * item.Value;
                        }
                        
                        
                    }
                }

                inputNameAndList = Console.ReadLine();
            }

            foreach (var item in students.OrderBy(x => x.Name))
            {
                Console.WriteLine("{0}", item.Name);

                foreach (var pair in item.ShopList)
                {
                    Console.WriteLine("-- {0} - {1}", pair.Key, pair.Value);
                }
                Console.WriteLine("Bill: {0:f2}", item.Bill);
            }

            decimal total = students.Select(x => x.Bill).Sum();

            Console.WriteLine("Total bill: {0:f2}", total);


        }
    }
}

