using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejmeplo3_If_Anidado
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operador condiconal 
            /*
             Compra <= $200 => recargo
              */
            float valorCompra = 0, recargo = 0;
            Console.Write("Ingrese el valor de la compra: ");
            valorCompra = Convert.ToSingle(Console.ReadLine());
            if (valorCompra >= 200)
            {
                recargo = valorCompra * 0.12f;
            }
            else
            {
                if (valorCompra >= 100)
                {
                    recargo = valorCompra * 0.10f;
                }
                else
                {
                    recargo = 0;
                }
            }
           
            Console.WriteLine("El valor de compra es: " + recargo);
            Console.Read();
        }
    }
}
