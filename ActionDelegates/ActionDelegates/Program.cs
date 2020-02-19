using ActionDelegates.Entities;
using System;
using System.Collections.Generic;

namespace ActionDelegates
{
    class Program
    {
        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }

        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //list.ForEach(UpdatePrice);

            //Action<Product> act = UpdatePrice;
            //Action<Product> act = p => { p.Price += p.Price * 0.1; };
            //list.ForEach(act);

            list.ForEach(p => { p.Price += p.Price * 0.1; });

            foreach (Product product in list)
            {
                System.Console.WriteLine(product);
            }
        }
    }
}
