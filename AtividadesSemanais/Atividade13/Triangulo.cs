using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade13
{
    class Triangulo : IForma
    {
        private double Base;
        private double altura;

        public Triangulo(double altura, double Base)
        {
            this.altura = altura;
            this.Base = Base;
        }

        public double calcularArea()
        {
            return (this.Base * this.altura) / 2;
        }

    }
}
