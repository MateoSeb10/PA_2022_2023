﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejmeplo5_DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int limiteSuperior = 20, contador = 1;
            Console.WriteLine("IMPRIMIR NUMEROS DEL 1 AL 20");
            do
            {
                Console.WriteLine("Valor:", contador);

                contador++;
            } while (contador <= limiteSuperior);
            Console.Read();
        }
    }
}
