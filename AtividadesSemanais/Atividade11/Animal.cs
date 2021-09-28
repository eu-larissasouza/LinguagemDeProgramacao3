using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade11
{
    class Animal
    {
        protected virtual void comunicar()
        {
            Console.WriteLine("Todos os animais são capazes de emitir o seu próprio " +
            "som de uma maneira única.");
            Console.WriteLine(" -> Animal.");
        }
    }
}
