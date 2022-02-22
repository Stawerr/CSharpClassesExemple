using System;

namespace exemploClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            // Class1 + Class Reta
            Ponto p1 = new Ponto(1,2);
            Ponto p2 = new Ponto(3,4);

            Reta r = new Reta(p1, p2);


            //Console.WriteLine(r.Distancia());
            Console.WriteLine(r.ToString());
            //-----------------------------------------

            // Class Pessoa
            string a = "renato";
            int idade = 30;
            Pessoa pessoa = new Pessoa(a, idade);

            Console.WriteLine(pessoa.ToString());
        }
    }
}
