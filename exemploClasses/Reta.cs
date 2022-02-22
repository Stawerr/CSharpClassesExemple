using System;
using System.Collections.Generic;
using System.Text;

namespace exemploClasses
{
    class Reta
    {
        private Ponto ponto1;
        private Ponto ponto2;

        internal Ponto Ponto1 { get => ponto1; set => ponto1 = value; }
        internal Ponto Ponto2 { get => ponto2; set => ponto2 = value; }

        public Reta(Ponto ponto1, Ponto ponto2)
        {
            Ponto1 = ponto1;
            Ponto2 = ponto2;
        }

        public int Distancia()
        {
            return Math.Abs(Ponto1.X - Ponto2.X);
        }

        public override string ToString()
        {
            return "Distancia : " + Distancia();
        }
    }
}