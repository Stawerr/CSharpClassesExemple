using System;
using System.Collections.Generic;
using System.Text;

namespace exemploClasses
{
    class Pessoa
    {
        private string _nome;
        private int _idade;
        private DateTime _dataNascimento;


        public DateTime DataNascimento
        {
            get { return _dataNascimento; }
            set 
            {
                if (value <= DateTime.Now)
                {
                    _dataNascimento = value;
                }
            }
        }

        public string Nome {
            get => _nome;
            set
            {
                if (value != null) {
                    _nome = value;
                }
            }
        }
        public int Idade {
            get => _idade;
            set {
                if (value>0 && value < 100)
                {
                    _idade = value;
                }
               
            }
        }

        public Pessoa()
        {
            Nome = "No name";
            Idade = 18;
        }
        public Pessoa(string n, int i) :this()
        {
            Nome = n;
            Idade = i;
        }
        public Pessoa(string n) : this()
        {
            Nome = n;
        }
        public Pessoa(string n, DateTime dataNascimento) : this(n)
        {
            DataNascimento = dataNascimento;
        }
        public Pessoa(Pessoa p)
        {
            Nome = p.Nome;
            Idade = p.Idade;

        }


        public int calcularIdade()
        {
            if (DataNascimento.DayOfYear > DateTime.Now.DayOfYear)
            {
                return DateTime.Now.Year - DataNascimento.Year-1;
            }
            return DateTime.Now.Year - DataNascimento.Year;
        }
        public override string ToString()
        {
            return "nome : " + Nome + " idade : " + Idade+ " Idade Calculada "+ calcularIdade();
            
        }
    }
}
