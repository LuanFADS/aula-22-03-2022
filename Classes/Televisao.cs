using Aula._22._03._2022.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula._22._03._2022.Classes
{
    public class Televisao : IEletroDomestico
    {
        void IEletroDomestico.Desligar()
        {
            Console.WriteLine($"{nameof(Televisao)} Desligou.");
        }

        void IEletroDomestico.Ligar()
        {
            Console.WriteLine($"{nameof(Televisao)} Ligou.");
        }
    }
}
