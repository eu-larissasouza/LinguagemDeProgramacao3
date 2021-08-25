using System;

namespace Exercicio2
{
    class Program
    {
        public static void Main(string[] args)
        {

            Cliente c1 = new Cliente();
            Conta conta1 = new Conta();

            c1.Nome = "Matheus";
            c1.Sobrenome = "Barbosa";
            c1.Cpf = "440.340.456-20";
            c1.Conta = conta1;

            conta1.Agencia = "5067";
            conta1.Numero = 765009;
            conta1.Saldo = 1225.55F;

            Cliente c2 = new Cliente();
            Conta conta2 = new Conta();

            c2.Nome = "Amanda";
            c2.Sobrenome = "Lima";
            c2.Cpf = "102.804.902-04";
            c2.Conta = conta2;

            conta2.Agencia = "3614";
            conta2.Numero = 621457;
            conta2.Saldo = 6805.99F;

            Cliente c3 = new Cliente();
            Conta conta3 = new Conta();

            c3.Nome = "Isabel";
            c3.Sobrenome = "Martins";
            c3.Cpf = "524.176.343-90";
            c3.Conta = conta3;

            conta3.Agencia = "6304";
            conta3.Numero = 352788;
            conta3.Saldo = 409.22F;


            Console.WriteLine("\nCliente: " + c1.Nome + " " + c1.Sobrenome);
            Console.WriteLine("\nCpf: " + c1.Cpf);
            Console.WriteLine("Agência: " + conta1.Agencia);
            Console.WriteLine("Número: " + conta1.Numero);
            Console.WriteLine("Saldo: " + conta1.Saldo);

            Console.WriteLine("\nCliente: " + c2.Nome + " " + c2.Sobrenome);
            Console.WriteLine("\nCpf: " + c2.Cpf);
            Console.WriteLine("Agência: " + conta2.Agencia);
            Console.WriteLine("Número: " + conta2.Numero);
            Console.WriteLine("Saldo: " + conta2.Saldo);

            Console.WriteLine("\nCliente: " + c3.Nome + " " + c3.Sobrenome);
            Console.WriteLine("\nCpf: " + c3.Cpf);
            Console.WriteLine("Agência: " + conta3.Agencia);
            Console.WriteLine("Número: " + conta3.Numero);
            Console.WriteLine("Saldo: " + conta3.Saldo);

        }
    }
}
