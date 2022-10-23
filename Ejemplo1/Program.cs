using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operador condiconal 
            /*
             Compra <= $200 => recargo
              */
            float valorCompra=0, recargo=0;
            Console.Write("Ingrese el valor de la compra: ");
            valorCompra = Convert.ToSingle( Console.ReadLine());

            //recargo = valorCompra >= 200 ? (valorCompra * 0.12f):0;
            recargo = valorCompra >= 200 ? (valorCompra * 0.12f) : valorCompra >= 100 ? (valorCompra * 0.1f) : 0;

            Console.WriteLine("El valor a pagar es "+ recargo);

            

            Console.Read();


        }
    }
}
