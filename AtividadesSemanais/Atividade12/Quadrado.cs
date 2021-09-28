using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade12
{
    class Quadrado : Forma
    {
        private double lado;

        public Quadrado(double lado)
        {
            base.setCor("Azul");
            this.lado = lado;
            Console.WriteLine("Area do quadrado: " + this.calcularArea() + "\n\n");
        }

        public Quadrado(double lado, string cor)
        {
            base.setCor(cor);
            this.lado = lado;
            Console.WriteLine("Area do quadrado: " + this.calcularArea() + "\n\n");
        }

        public override double calcularArea()
        {
            return lado * lado;
        }

    }
}
