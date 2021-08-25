using System;

namespace Exercicio4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Postagem p1 = new Postagem();

            p1.Titulo = "Lyrics: On My Way (feat. Sabrina Carpenter & Farruko)";
            p1.Data = "15/06/2021";
            p1.Conteudo = "\n So take aim and fire away\n I've never been so wide awake\n No, nobody but me can keep me safe\n And I'm on my way\n";
            p1.Visitas = 50;

            Postagem p2 = new Postagem();

            p2.Titulo = "Relógio";
            p2.Data = "20/07/2021";
            p2.Conteudo = "\n As coisas são\n As coisas vêm\n As coisas vão\n As coisas\n Vão e vêm\n Não em vão\n As horas\n Vão e vêm\n Não em vão\n";
            p2.Visitas = 100;

            Postagem p3 = new Postagem();

            p3.Titulo = "Uma citação de Tom Jobim que amo muito";
            p3.Data = "09/08/2021";
            p3.Conteudo = "\n Ah, quem me dera ser poeta\n Pra cantar em seu louvor\n Belas canções, lindos poemas\n Doces frases de amor\n";
            p3.Visitas = 250;


            Usuario u1 = new Usuario();

            u1.Nome = "Larissa";
            u1.Sobrenome = "Souza";
            u1.Senha = "AbCd2004";

            u1.Postagens[0] = p1;
            u1.Postagens[1] = p2;
            u1.Postagens[2] = p3;


            Console.WriteLine("\nUsuário: " + u1.Nome + " " + u1.Sobrenome);

            Console.WriteLine("\n\n-------- Publicações --------\n\n");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("---- Publicação no. " + (i + 1) );
                Console.WriteLine("\nTitulo: " + u1.Postagens[i].Titulo);
                Console.WriteLine("\nData : " + u1.Postagens[i].Data);
                Console.WriteLine("\nConteúdo: " + u1.Postagens[i].Conteudo);
                Console.WriteLine("Visitas: " + u1.Postagens[i].Visitas + "\n\n");
            }

        }
    }
}
