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
        //Declarar un array
        String[] nombres;

        //instanciar un array
        nombres = new string[4];

            // cargar un array de forma directa/ asignacion simpe

            nombres[0] = "Pepe";
            nombres[1] = "Pepa";
            nombres[2] = "Pepo";
            nombres[3] = "Pepi";

            Console.WriteLine("Ingrese un nombre");
            nombres[1] = Console.ReadLine();

            Console.WriteLine("Ingrese un nombre");
            nombres[2] = Console.ReadLine();

            Console.WriteLine("Los nombres ingresados son: "+ nombres[0] + " , " + nombres[1] + ", " + nombres[2] + " y " + nombres[3]);

            Console.ReadKey();
            Console.Clear();


            // array con bucle for

            int[] edades = new int[4];

            for(int i = 0; i <=3; i++)
            {
                Console.WriteLine("Ingrese la edad de "+i+":");
                edades[i] = Convert.ToInt32(Console.ReadLine());
                
            }


            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine("La edad de " + i + " es: \t" + edades[i]);
              

            }

            Console.ReadKey();
        }
    }
}
