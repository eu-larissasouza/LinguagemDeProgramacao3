﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade7
{
    class Pessoa
    {

        private string nome = "Larissa";
        private string sobrenome = "Souza";
        private byte idade = 17;
        private float altura = 1.60F;
        private float peso = 55.5F;

        public string getNome()
        {
            return this.nome;
        }

        public string getSobrenome()
        {
            return this.sobrenome;
        }

        public byte getIdade()
        {
            return this.idade;
        }

        public float getAltura()
        {
            return this.altura;
        }

        public float getPeso()
        {
            return this.peso;
        }

    }
}
