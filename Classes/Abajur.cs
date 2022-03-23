using Aula._22._03._2022.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula._22._03._2022.Classes
{
    public class Abajur : IEletroDomestico
    {
        public void Desligar()
        {
            Console.WriteLine($"{nameof(Abajur)} Desligou.");
        }

        public void Ligar()
        {
            Console.WriteLine($"{nameof(Abajur)} Ligou.");
        }
    }
}
