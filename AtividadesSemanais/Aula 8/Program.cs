using System;

namespace Aula_8
{
    class Program
    {
        public static void Main(string[] args)
        {
            Casa c = new Casa();

            c.Area = 150;
            c.Altura = 6.5F;
            c.Preco = 625M;

            Console.WriteLine("Sua Casa");

            Console.WriteLine("Área: " + c.Area + " m² construídos");

            Console.WriteLine("Altura: " + c.Altura + " metros");

            Console.WriteLine("Preço: R$ " + c.Preco + " mil");
        }
    }
}
