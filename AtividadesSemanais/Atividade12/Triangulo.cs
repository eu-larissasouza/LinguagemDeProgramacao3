using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade12
{
    class Triangulo : Forma
    {
        private double Base;
        private double altura;

        public Triangulo(double altura, double Base)
        {
            base.setCor("Vermelho");
            this.altura = altura;
            this.Base = Base;
            Console.WriteLine("Area do Triangulo: " + this.calcularArea() + "\n\n");
        }

        public Triangulo(double altura, double Base, string cor)
        {
            base.setCor(cor);
            this.altura = altura;
            this.Base = Base;
            Console.WriteLine("Area do Triangulo: " + this.calcularArea() + "\n\n");
        }

        public override double calcularArea()
        {
            return (Base * altura) / 2;
        }

    }
}
