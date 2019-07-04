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
            Console.Clear();

            try
            {
                Console.WriteLine("[][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][]");
                Console.WriteLine("[][]  I.F.S. nº 93                           Dario Ceballos [][]");
                Console.WriteLine("[][]                                                        [][]");
                Console.WriteLine("[][]                    *** MENU ***                        [][]");
                Console.WriteLine("[][]                                                        [][]");
                Console.WriteLine("[][]	     Calculadora                       2            [][]");
                Console.WriteLine("[][]	     Calculadora de edad               3            [][]");
                Console.WriteLine("[][]	     Tablas de MULTIPLICAR             4            [][]");
                Console.WriteLine("[][]	     Array 1                           5            [][]");
                Console.WriteLine("[][]	     Array 2                           6            [][]");
                Console.WriteLine("[][]	     Array 3                           7            [][]");
                Console.WriteLine("[][]	     Dia2 Calculadora                  8            [][]");
                Console.WriteLine("[][]                                                        [][]");
                Console.WriteLine("[][]	     Salir                             1            [][]");
                Console.WriteLine("[][]                                                        [][]");
                Console.WriteLine("[][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][]");

                //Console.WriteLine("Seleccione un dia tecleando un numero del 2 al 7 \n \n mas adelante se agregara un menu");
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
                    case 5:
                        Dia5Array dia5 = new Dia5Array();
                        dia5.Array();
                        break;
                    case 6:
                        Dia6Array2 dia6 = new Dia6Array2();
                        dia6.array2();
                        break;
                    case 7:
                        Dia7Array3 dia7 = new Dia7Array3();
                        dia7.array3();
                        break;
                    default:
                        Console.WriteLine("ERROR ERROR ERROR ERROR ERROR ERROR \n  SELECCIONE UNA DE LAS OPCIONES \n\n\n");

                        break;
                }
            }catch (Exception error){
                Console.WriteLine(error.Message + "\n Por favor inserta un numero");
                Console.ReadKey();

            }

            goto Inicio;
            
        }
    }
}
