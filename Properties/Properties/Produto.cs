using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Produto
    {
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }
        public string _nome;

        public Produto(double preco, int qtd, string nome)
        {
            Preco = preco;
            Quantidade = qtd;
            _nome = nome;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if(value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

    }
}
