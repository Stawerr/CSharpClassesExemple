using System;
using System.Collections.Generic;
using System.Text;

namespace exemploClasses
{
    class Funcionario :Pessoa
    {
       private string _categoria;
       private double _salario;

        public string Categoria { get => _categoria; set => _categoria = value; }
        public double Salario { get => _salario; set => _salario = value; }

        public Funcionario(string nome, int idade, string categoria, double salario):base(nome,idade)
        {
            
            Categoria = categoria;
            Salario = salario;
        }

        public override string ToString()
        {
            return "nome : " + Nome + " idade : " + Idade + " Categoria " + Categoria+" Salário "+Salario;
        }
    }
}
