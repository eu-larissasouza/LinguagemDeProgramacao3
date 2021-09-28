using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade11
{
    class Sapo : Anfibio
    {
        public Sapo()
        {

        }

        protected override void comunicar()
        {
            base.comunicar();
            Console.WriteLine(" -> Sapo");
            Console.WriteLine("Som: \tCroac Croac Croac\n\n");
        }
    }
}
