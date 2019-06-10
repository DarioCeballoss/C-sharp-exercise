using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instituto
{
    class Dia1
    {
        static void Main(string[] args)
        {
            Dia3calculadoraDeEdad dia3 = new Dia3calculadoraDeEdad();
            dia3.edad();
            Console.ReadKey();
        }
    }
}
