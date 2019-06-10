using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instituto
{
    class Dia3calculadoraDeEdad
    {
        public void edad()
        {
            int fecha1, fecha2, edad;

            Console.WriteLine("-------------------");
            Console.WriteLine("CALCULADORA DE EDAD");
            Console.WriteLine("-------------------");


            Console.WriteLine("Ingrese el año actual");
            fecha1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el año de nacimiento");
            fecha2 = Convert.ToInt32(Console.ReadLine());

            edad = fecha1 - fecha2;

            Console.WriteLine("Su edad es: " + edad);

            if (edad >= 18)
            {
                Console.WriteLine("Usted es mayor de edad");
            }
            else
            {
                Console.WriteLine("Usted es menor de edad");
            }

            Console.ReadKey();
        }
    }
}
