using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instituto
{
    class Dia7Array3
    {
        public void array3()
        {


            Console.WriteLine("inserte la longitud del Array");
            int longitud = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[longitud];

            for (int i = 0; i < longitud; i++)
            {
                array[i] = 0;
            }


            if (longitud % 2 != 0)
            {
                array[(longitud / 2) - (1 / 2)] = 1;
            }else{
                array[(longitud / 2)] = 1;
                array[(longitud / 2) - 1] = 1;
            }

                       
            for (int i = 0; i < longitud; i++)
            {
                Console.Write(array[i]);
            }


            Console.ReadKey();


        }
    }
}
