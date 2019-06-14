using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instituto
{
    class Dia5Array
    {
        public void Array() {
            int[] edades = new int[5];
            string[] nombres = new string[5];

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Ingrese el nombre " + i + ": ");
                nombres[i] = Console.ReadLine();

                Console.WriteLine("Ingrese una edad " + i + ": ");
                edades[i] = Convert.ToInt32(Console.ReadLine());
            }



            Console.WriteLine("Los nombres ingresados son:  \n \n ");

            for (int i = 0; i <= 4; i++)
            {

                Console.WriteLine("\t" + nombres[i] + " con " + edades[i] + " años");

            }

            Console.ReadKey();
        }
    }
}
