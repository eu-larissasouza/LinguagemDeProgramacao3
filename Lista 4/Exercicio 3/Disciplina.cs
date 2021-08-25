using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    class Disciplina
    {
        private string nome;
        private string descricao;
        private string turma;
        private Aluno[] alunos = new Aluno[4];

        public string Nome { get => nome; set => nome = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Turma { get => turma; set => turma = value; }
        public Aluno[] Alunos { get => alunos; set => alunos = value; }
    }
}
