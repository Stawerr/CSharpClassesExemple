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
            string nome = "renato";
            int idade = 30;
            DateTime dt = new DateTime(1995, 01, 16,1,1,1);
            Pessoa pessoa = new Pessoa("renato", dt);

            Console.WriteLine(pessoa.ToString());
            Funcionario funcionario = new Funcionario(nome, idade, "Manager", 2000);
            Console.WriteLine(funcionario.ToString());
        }
    }
}