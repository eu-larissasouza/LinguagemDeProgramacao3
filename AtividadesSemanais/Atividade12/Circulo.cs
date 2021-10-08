using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade12
{
    class Circulo : Forma
    {
        private double raio;

        public Circulo(double raio)
        {
            base.setCor("Laranja");
            this.raio = raio;
            Console.WriteLine("Area do Circulo: " + this.calcularArea() + "\n\n");
        }

        public Circulo(double raio, string cor)
        {
            base.setCor(cor);
            this.raio = raio;
            Console.WriteLine("Area do Circulo: " + this.calcularArea() + "\n\n");
        }

        public override double calcularArea()
        {
            return (raio * raio) * 3.14;
        }

    }
}