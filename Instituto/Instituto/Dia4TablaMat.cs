using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instituto
{
    class Dia4TablaMat
    {
        public void tablass()
        {

            int tabla;

        Inicio:
            Console.WriteLine("ingrese el numero de la tabla \n \n \n");
            tabla = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {

                Console.WriteLine("El resultado de la tabla es: " + tabla + " x " + i + " = " + (tabla * i));

            }


            Console.ReadKey();
            Console.Clear();
            goto Inicio;



        }
    }
}
