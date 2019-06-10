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
          
            int dia;
            Inicio:
            Console.WriteLine("Seleccione un dia tecleando un numero del 2 al 4 \n \n mas adelante se agregara un menu");
            dia = Convert.ToInt32(Console.ReadLine());

            switch (dia)
            {
                case 2:
                    Dia2CalculadoraMat dia2 = new Dia2CalculadoraMat();
                    dia2.cuenta();
                    break;
                case 3:
                    Dia3calculadoraDeEdad dia3 = new Dia3calculadoraDeEdad();
                    dia3.edad();
                    break;
                case 4:
                    Dia4TablaMat dia4 = new Dia4TablaMat();
                    dia4.tablass();
                    break;
                default:
                    Console.WriteLine("ERROR ERROR ERROR ERROR ERROR ERROR \n  SELECCIONE UNA DE LAS OPCIONES \n\n\n");
                    
                    break;

            }
            goto Inicio;
                    Console.ReadKey();
        }
    }
}
