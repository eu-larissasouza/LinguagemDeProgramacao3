using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade11
{
    class Cachorro: Mamifero
    {
        public Cachorro()
        {

        }

        protected override void comunicar()
        {
            base.comunicar();
            Console.WriteLine(" -> Cachorro");
            Console.WriteLine("Som: \tAu Au Au\n\n");
        }
    }
}
