using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade11
{
    class Mamifero:Animal
    {
        public Mamifero()
        {
            this.comunicar();
        }

        protected override void comunicar()
        {
            base.comunicar();
            Console.WriteLine(" -> Mamífero");
        }
    }
}
