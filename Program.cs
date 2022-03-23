using Aula._22._03._2022.Classes;
using Aula._22._03._2022.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula._22._03._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            IEletroDomestico eletro1 = new Televisao();

            eletro1.Ligar();
            eletro1.Desligar();

            Console.ReadLine();
        }
    }
}
