using System;

namespace TestesC_VSC
{
    class Pessoa
    {

        public Pessoa(string nome, int idade, char sexo){
            Nome = nome;
            Idade = idade;
            Sexo = sexo;
        }

       private string _nome;

       public int Idade { get; set; }

       public char Sexo { get; private set; }

       public string Nome{
           get {return _nome;}
           set{
               if( value != null && value.Length > 1){
                   _nome = value;
               }
           }
       } 
    }
}
