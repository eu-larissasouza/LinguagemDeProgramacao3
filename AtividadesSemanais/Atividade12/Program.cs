using System;

namespace Atividade12
{
    class Program
    {
	    public static void Main(string[] args)
        {
            Retangulo ret1 = new Retangulo(15.0, 4.0);
            Retangulo ret2 = new Retangulo(10.0, 2.0, "Azul");

            Circulo cir1 = new Circulo(8.0);
            Circulo cir2 = new Circulo(12.0, "Branco");

            Quadrado quad1 = new Quadrado(15.0);
            Quadrado quad2 = new Quadrado(10.0, "Cinza");

            Triangulo tri1 = new Triangulo(15.0, 4.0);
            Triangulo tri2 = new Triangulo(10.0, 2.0, "Amarelo");
        }
    }
}
