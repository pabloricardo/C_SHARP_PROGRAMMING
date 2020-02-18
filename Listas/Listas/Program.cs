using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("Maria");
            list.Add("Brenda");
            list.Add("Fernando");
            list.Add("Bruno");
            list.Add("Ana");
            list.Insert(2, "Carlos");

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("List count: " + list.Count());

            string s1 = list.Find(x => x[0] == 'B');
            Console.WriteLine("First 'B' " + s1);

            string s2 = list.FindLast(x => x[0] == 'B');
            Console.WriteLine("Last 'B' " + s2);

            Console.WriteLine("Nomes que tem 5 caracteres");
            List<String> list2 = list.FindAll(x => x.Length == 5);
            foreach (string item in list2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Lista com o Carlos removido");
            list.Remove("Carlos");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
