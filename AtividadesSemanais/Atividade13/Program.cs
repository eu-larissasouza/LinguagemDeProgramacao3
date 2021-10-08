using System;

namespace Atividade13
{
    class Program
    {
        static void mostrarArea(IForma forma)
        {
            Console.WriteLine("Área da forma: " + forma.calcularArea());
        }

        public static void Main(string[] args)
        {
            IForma forma = new Quadrado(15.0);
            mostrarArea(forma);

            forma = new Retangulo(8.0, 4.0);
            mostrarArea(forma);

            forma = new Triangulo(3.0, 12.0);
            mostrarArea(forma);

            forma = new Circulo(8.0);
            mostrarArea(forma);

        }
    }
}
