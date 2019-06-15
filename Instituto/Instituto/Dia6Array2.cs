using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instituto
{
    class Dia6Array2
    {
        public void array2()
        {
            int[] prueba = new int[7];
         

            for (int i = 0; i <= 6; i++)
            {
                if (i % 2 == 0)
                    prueba[i] = 0;
                else
                    prueba[i] = 1;
            }

            for (int i = 0; i <= 6; i++)
            {
                Console.Write(prueba[i]);
            }
           
            Console.ReadKey();

            Console.ReadLine();

        }
    }
}
