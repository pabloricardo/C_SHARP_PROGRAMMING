using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto(999,25,"TV");
            p1.Nome = "T";
            Console.WriteLine(p1.Nome);
            Console.WriteLine(p1.Preco);
            Console.WriteLine(p1.Quantidade);
            Console.ReadKey();
        }
    }
}
