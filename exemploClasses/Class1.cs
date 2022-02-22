using System;
using System.Collections.Generic;
using System.Text;

namespace exemploClasses
{
    class Ponto
    {

        //Encapsulamento
        public int X { get ; set ; }
        public int Y { get ; set ; }
        public int Z { get; set; }

        public Ponto()
        {
            X = 560;
            Y = 320;   
        }
        public Ponto(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public Ponto(int x,int y,int z):this(x,y)
        {
            this.Z = z;
        }

        public override string ToString()
        {
            return "Ponto: (" + X.ToString() + "," + Y.ToString() + ")";
        }
    }
}
