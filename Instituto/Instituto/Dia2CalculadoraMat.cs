using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Instituto
{
    class Dia2CalculadoraMat
    {
        public void cuenta()
        {
            int calc, seguir;
            double valor1, valor2;

            seguir = 3;
            Inicio:
            try { 
            while (seguir > 2)
            {
                Console.WriteLine("		----------------------------");
                Console.WriteLine("		-Calcualadora de dos cifras-");
                Console.WriteLine("		----------------------------");



                Console.WriteLine("Ingrese la primer cifra, acto seguido presione enter");
                valor1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Ingrese la segunda cifra, acto seguido presione enter");
                valor2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Seleccione el calculo que desea realizar presionando la TECLA con el numero seguido de ENTER");
                Console.WriteLine();
                Console.WriteLine("     -------------- --------------- --------------------- -----------------");
                Console.WriteLine("     -   1 SUMA   - -   2 RESTA   - -   3 MULTIPLICAR   - -   4 DIVIDIR   -");
                Console.WriteLine("     -------------- --------------- --------------------- -----------------");
                calc = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();



                if (calc == 1)
                {
                    Console.WriteLine("El resultado de la suma es:  " + (valor1 + valor2));
                }
                else if (calc == 2)
                {
                    Console.WriteLine("El resultado de la resta es:  " + (valor1 - valor2));
                }
                else if (calc == 3)
                {
                    Console.WriteLine("El resultado de la multiplicacion es:  " + (valor1 * valor2));
                }
                else if (calc == 4)
                {

                    if (valor2 != 0)
                    {
                        Console.WriteLine("El resultado de la divicion es:  " + (valor1 / valor2));
                    }
                    else
                    {
                        Console.WriteLine("ERROR... Verifica no poner 0 como valor a calcular");
                    }

                }
                else
                {
                    Console.WriteLine("Presionaste " + calc + " NO corresponde a un calculo");
                }



                Console.WriteLine("Si sted dsea salir presione (1) de lo contrario presione (2)");
                seguir = Convert.ToInt32(Console.ReadLine());


                seguir++;
            }
            //Console.ReadKey();
            Console.WriteLine("Gracias Por usar la calculadora... NOS VEMOS");
            Thread.Sleep(2000);





            }
            catch (Exception error)
            {
                Console.Clear();
                Console.WriteLine(error.Message + "\n Inicie debuelta y asegurece de insertar bien el numero \n\n\n");
                
                goto Inicio;
            }

        }
    }
}
