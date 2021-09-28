using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade11
{
    class Gato : Mamifero
    {
        public Gato()
        {

        }

        protected override void comunicar()
        {
            base.comunicar();
            Console.WriteLine(" -> Gato");
            Console.WriteLine("Som: \tMiau Miau Miau\n\n");
        }        
    }
}
