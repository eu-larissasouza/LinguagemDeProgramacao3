using System;

namespace Aula_7
{
    class Program
    {
        public static void Main(string[] args){
            Pessoa p1 = new Pessoa();

            Console.WriteLine("Nome Completo: " + p1.getNome() + " " + p1.getSobrenome());

            Console.WriteLine("Idade: " + p1.getIdade());

            Console.WriteLine("Sua altura: " + p1.getAltura());

            Console.WriteLine("Seu peso: " + p1.getPeso());
        }
    }
}
