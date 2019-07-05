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



            int dia,salir = 0;
        
            Console.Clear();
            while (salir != 1)
            {


                try
                {
                    Console.WriteLine("\n\t[][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][]");
                    Console.WriteLine("\t[][]  I.F.S. nº 93                           Dario Ceballos [][]");
                    Console.WriteLine("\t[][]                                                        [][]");
                    Console.WriteLine("\t[][]                    *** MENU ***                        [][]");
                    Console.WriteLine("\t[][]                                                        [][]");
                    Console.WriteLine("\t[][]	     Calculadora                       2            [][]");
                    Console.WriteLine("\t[][]	     Calculadora de edad               3            [][]");
                    Console.WriteLine("\t[][]	     Tablas de MULTIPLICAR             4            [][]");
                    Console.WriteLine("\t[][]	     Array 1                           5            [][]");
                    Console.WriteLine("\t[][]	     Array 2                           6            [][]");
                    Console.WriteLine("\t[][]	     Array 3                           7            [][]");
                    Console.WriteLine("\t[][]	     Array 4                           8            [][]");
                    Console.WriteLine("\t[][]                                                        [][]");
                    Console.WriteLine("\t[][]	     Salir                             1            [][]");
                    Console.WriteLine("\t[][]                                                        [][]");
                    Console.WriteLine("\t[][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][][]");

                    //Console.WriteLine("Seleccione un dia tecleando un numero del 2 al 7 \n \n mas adelante se agregara un menu");
                    dia = Convert.ToInt32(Console.ReadLine());

                    switch (dia)
                    {
                        case 1:
                            salir=1;
                            break;

                        case 2:
                            Console.Clear();
                            Dia2CalculadoraMat dia2 = new Dia2CalculadoraMat();
                            dia2.cuenta();
                            break;
                        case 3:
                            Console.Clear();
                            Dia3calculadoraDeEdad dia3 = new Dia3calculadoraDeEdad();
                            dia3.edad();
                            break;
                        case 4:
                            Console.Clear();
                            Dia4TablaMat dia4 = new Dia4TablaMat();
                            dia4.tablass();
                            break;
                        case 5:
                            Console.Clear();
                            Dia5Array dia5 = new Dia5Array();
                            dia5.Array();
                            break;
                        case 6:
                            Console.Clear();
                            Dia6Array2 dia6 = new Dia6Array2();
                            dia6.array2();
                            break;
                        case 7:
                            Console.Clear();
                            Dia7Array3 dia7 = new Dia7Array3();
                            dia7.array3();
                            break;
                        case 8:
                            Console.Clear();
                            Dia8Array4 dia8 = new Dia8Array4();
                            dia8.array3();
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("\n\n \t\t\t ERROR ERROR ERROR ERROR ERROR ERROR \n \t\t\t   SELECCIONE UNA DE LAS OPCIONES \n\n");
                            
                            break;
                    }
                    
                }
                catch (Exception error)
                {
                    Console.Clear();
                    Console.WriteLine("\n\n \t\t" + error.Message + "\n \t\t\t POR FAVOR INGRESA UN NUMERO \n\n ");
                    
                   
                }

            }
            
        }
    }
}
