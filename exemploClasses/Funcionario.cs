using System;
using System.Collections.Generic;
using System.Text;

namespace exemploClasses
{
    class Funcionario :Pessoa
    {
       private string _categoria;
       private double _salario;

        public string Categoria { get => _categoria; set
            {
                if (value != null && value == "Manager" || value == "Employee")
                {
                    _categoria = value;
                }
                else
                {
                    Console.WriteLine("Categoria Invalida");
                }    
            }
        }
        public double Salario { get => _salario; set 
            {
                if(value > 500 && value < 2500)
                {
                    _salario = value;
                }
                else
                {
                    Console.WriteLine("Salário Invalido");
                }
            }
        }

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
