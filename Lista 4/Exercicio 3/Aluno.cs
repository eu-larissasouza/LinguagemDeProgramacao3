using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{ 
    class Aluno
    {
        private string nome;
        private string registroAluno;
        private string email;

        public string Nome { get => nome; set => nome = value; }
        public string RegistroAluno { get => registroAluno; set => registroAluno = value; }
        public string Email { get => email; set => email = value; }
    }
}
