using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade11
{
    class Jacare : Reptil
    {
        public Jacare()
        {
            
        }

        protected override void comunicar()
        {
            base.comunicar();
            Console.WriteLine(" -> Jacaré");
            Console.WriteLine("Som: \tRoar Roooor\n\n");
        }
    }
}
