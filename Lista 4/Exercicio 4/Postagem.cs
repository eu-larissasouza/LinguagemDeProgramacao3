using System;

namespace Exercicio4
{
    class Postagem
    {
        private string titulo;
        private string data;
        private string conteudo;
        private int visitas;


        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Data
        {
            get { return data; }
            set { data = value; }
        }

        public string Conteudo
        {
            get { return conteudo; }
            set { conteudo = value; }
        }

        public int Visitas
        {
            get { return visitas; }
            set { visitas = value; }
        }

    }
}
