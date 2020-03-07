using System;

namespace TestesC_VSC
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa("Fernando", 23, 'M');
            System.Console.WriteLine("Nome " + p1.Nome);
            System.Console.WriteLine("Idade " + p1.Idade);
            System.Console.WriteLine("Sexo " + p1.Sexo);

            p1.Idade = 21;
            p1.Nome = "A";

            System.Console.WriteLine("Nome " + p1.Nome);
            System.Console.WriteLine("Idade " + p1.Idade);
            System.Console.WriteLine("Sexo " + p1.Sexo);
        }
    }
}
