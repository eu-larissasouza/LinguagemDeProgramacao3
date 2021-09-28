using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade11
{
    class Anfibio : Animal
    {
        public Anfibio()
        {
            
            this.comunicar();
        }

        protected override void comunicar()
        {
            base.comunicar();
            Console.WriteLine(" -> Anfibio");
        }
    }
}
