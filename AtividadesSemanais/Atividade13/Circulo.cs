using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade13
{
    class Circulo : IForma
    {
        private double raio;

        public Circulo(double raio)
        {
            this.raio = raio;
        }

        public double calcularArea()
        {
            return (this.raio * this.raio) * 3.14;
        }

    }
}
