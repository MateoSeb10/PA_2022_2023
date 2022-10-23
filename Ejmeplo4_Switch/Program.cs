using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejmeplo4_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            var numero = 0;
            Console.WriteLine("IMPRESION DE NUEMROS EN LETRAS");
            Console.WriteLine("Ingrese un numero del 1 al 8: ");
            numero =Convert.ToInt32( Console.ReadLine());
            switch (numero)
            {
                case 1:
                    Console.WriteLine("UNO");
                
                    break;
                case 2:
                    Console.WriteLine("DOS");

                    break;
                case 3:
                    Console.WriteLine("TRES");

                    break;
                case 4:
                    Console.WriteLine("CUATRO");

                    break;
                case 5:
                    Console.WriteLine("CINCO");

                    break;
                case 6:
                    Console.WriteLine("SEIS");

                    break;
                case 7:
                    Console.WriteLine("SIETE");

                    break;
                case 8:
                    Console.WriteLine("OCHO");

                    break;

                default:
                    Console.WriteLine("El numero esta fuera de rango");
                    break;

                    
            }
            Console.Read();

        }
    }
}
