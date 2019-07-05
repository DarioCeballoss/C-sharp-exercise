using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instituto
{
    class Dia8Array4
    {
        public void array3()
        {

            Console.WriteLine("inserte la longitud del Array");
            int longitud = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[longitud];

            Console.Write("Caso1:\n \t");
            for (int i = 0; i < longitud; i++)
            {

                if (i == 0)
                    array[i] = 0;
                else
                    array[i] = (i - 1) + i;
                Console.Write("  " + array[i]);
            }

            Console.Write("\n Caso2:\n \t");
            for (int i = 0; i < longitud; i++)
            {
                array[i] = (i - longitud + 1);
                Console.Write("  " + array[i]);
            }

            Console.Write("\n Caso3:\n \t");
            for (int i = 0; i < longitud; i++)
            {
                array[i] = (i - 2);
                Console.Write("  " + array[i]);
            }


            Console.ReadKey();
        }
    }
}
