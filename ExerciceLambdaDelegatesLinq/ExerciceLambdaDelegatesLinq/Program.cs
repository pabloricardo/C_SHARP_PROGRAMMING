using ExerciceLambdaDelegatesLinq.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace ExerciceLambdaDelegatesLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseDirectory = System.AppDomain.CurrentDomain.BaseDirectory;
            string fileName = "products.txt";
            string path = baseDirectory + fileName;

            List<Product> list = new List<Product>();

            using (StreamReader sr = File.OpenText(path)){
                while (!sr.EndOfStream)
                {
                    string[] field = sr.ReadLine().Split(',');
                    string name = field[0];
                    double price = double.Parse(field[1], CultureInfo.InvariantCulture);
                    list.Add(new Product(name, price));
                }
            }

            var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Average price = " + avg.ToString("F2", CultureInfo.InvariantCulture));

            var names = list.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
