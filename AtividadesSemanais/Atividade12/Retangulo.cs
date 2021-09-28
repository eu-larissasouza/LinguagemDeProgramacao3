using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade12
{
    class Retangulo : Forma
    {
        private double altura;
        private double largura;

        public Retangulo(double altura, double largura)
        {
            base.setCor("Verde");
            this.altura = altura;
            this.largura = largura;
            Console.WriteLine("Area do Retangulo: " + this.calcularArea() + "\n\n");
        }

        public Retangulo(double altura, double largura, string cor)
        {
            base.setCor(cor);
            this.altura = altura;
            this.largura = largura;
            Console.WriteLine("Area do Retangulo: " + this.calcularArea() + "\n\n");
        }

        public override double calcularArea()
        {
            return largura * altura;
        }

    }
}
