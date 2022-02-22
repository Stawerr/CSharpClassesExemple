using System;
using System.Collections.Generic;
using System.Text;

namespace exemploClasses
{
    class Pessoa
    {
        private string _nome;
        private int _idade;

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
        public Pessoa(Pessoa p)
        {
            Nome = p.Nome;
            Idade = p.Idade;

        }

        public override string ToString()
        {
            return "nome : " + Nome + " idade : " + Idade;
        }
    }
}
