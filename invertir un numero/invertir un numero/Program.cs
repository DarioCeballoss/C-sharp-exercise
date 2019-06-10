using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invertir_un_numero
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, resto, invert, d, vuelta;
            vuelta = 0;
            invert = 0;

            //ingresa numero a invertir

            Console.WriteLine("ingrese un numero");
            num = d = Convert.ToInt32(Console.ReadLine());

            //contador de digitos

            while (d > 0)
            {
                d = d / 10;
                vuelta = vuelta + 1;
            }

            // Se genera el espacio para situar los numeros invertidos (MATH.POW=POTENCIA)
            int f = Convert.ToInt32(Math.Pow(10, vuelta));

            // armado del numero invertido exepto el ultimo digito

            for (int i = 1; i < vuelta; i++)
            {
                f = f / 10;
                resto = num % 10;
                num = num / 10;
                invert = invert + resto * f;

            }

            // Se agrega el ultimo digito

            resto = num % 10;
            num = num / 10;
            invert = invert + resto;

            //fin

            Console.WriteLine("El numero invertido es " + invert);


            Console.ReadKey();


        }
    }
}
