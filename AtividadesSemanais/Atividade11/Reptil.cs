using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade11
{
    class Reptil : Animal
    {
        public Reptil()
        {
            this.comunicar();
        }

        protected override void comunicar()
        {
            base.comunicar();
            Console.WriteLine(" -> Reptil");
        }
    }
}
