using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3_DFDaCSharp
{
    class Program
    {
        /*3.	Realizar un C# con un menú utilizando la herramienta switch case.
         * Dentro del menú debe contener la opción para realizar una multiplicación, 
         * otra para realizar una multiplicación rusa y por ultimo para salir.

        Lo que debe realizar cada uno. 
        * Multiplicación: (mirar dfd.)
        * Multiplicación rusa: (Capturar 2 números y multiplique por el método de la multiplicación rusa, 
        * La multiplicación entre ellos positivo con positivo y positivo con negativo si se puede realizar. 
        * Pero, negativo con negativo y negativo con positivo no.)
        
       Solo se puede utilizar los comandos básicos y las decisiones (if, if else, if muchos else if), for, White y do WhiLe.
 */
        static void Main(string[] args)
        {
            Console.Title = "CALCULADORA DE MULTIPLICACIONES"; //lo que aparecerá en la barra superior de la ventana
            Console.SetWindowSize(75, 18); //establece columnas y filas

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            int opcion = 0, c=0, d=0, j=0, k=0;
            string n = "", n2="", n3="", n4="";
            bool esNumero = false, esNumero2=false, c1=false, c2=false;
            int nro1 = 0, nro2 = 0, i=0, m=0;
            long res = 0;

            while (opcion < 1 | opcion > 3)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" _________________________________________________________________________ ");
                Console.WriteLine("|                                                                         |");
                Console.WriteLine("|--------------------SELECCIONE UNA DE LAS OPCIONES-----------------------|");
                Console.WriteLine("|_________________________________________________________________________|");
                Console.WriteLine("|_________________________________________________________________________|");
                Console.WriteLine("|                                                                         |");
                Console.WriteLine("|                                                                         |");
                Console.WriteLine("|---------------- PRESIONE 1 PARA: MULTIPLICACIÓN NORMAL -----------------|");
                Console.WriteLine("|                                                                         |");
                Console.WriteLine("|---------------- PRESIONE 2 PARA: MULTIPLICACIÓN RUSA -------------------|");
                Console.WriteLine("|                                                                         |");
                Console.WriteLine("|---------------- PRESIONE 3 PARA: TERMINAR EL PROGRAMA ------------------|");
                Console.WriteLine("|                                                                         |");
                Console.WriteLine("|_________________________________________________________________________|");
                Console.WriteLine("                                                                           ");
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                n = Console.ReadLine();
                esNumero = int.TryParse(n, out opcion);
                if (opcion < 1 | opcion > 3)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" _________________________________________________________________________ ");
                    Console.WriteLine("|                                                                         |");
                    Console.WriteLine("|---------DATO INVÁLIDO. PRESIONE CUALQUIER TECLA PARA CONTINUAR----------|");
                    Console.WriteLine("|_________________________________________________________________________|");
                    Console.WriteLine("                                                                           ");

                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("                                                                           ");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    switch (opcion)
                    {
                        case 1:
                            //multiplicación "normal"
                            esNumero = false;
                            while (esNumero == false || esNumero2 == false || c1==false|| c2==false )
                            {
                                Console.WriteLine("                                                                           ");
                                Console.Write(" --------------- Establezca una tabla de multiplicar: ");
                                n = Console.ReadLine();
                                Console.WriteLine("                                                                           ");
                                Console.Write(" --------------- Establezca otra tabla de multiplicar: ");                                
                                n2 = Console.ReadLine();
                                Console.WriteLine("                                                                           ");
                                Console.Write(" --------------- Ingrese un indice de multiplicación: ");
                                n3 = Console.ReadLine();
                                Console.WriteLine("                                                                           ");
                                Console.Write(" --------------- Ingrese otro indice de multiplicación: ");
                                n4 = Console.ReadLine();
                                Console.WriteLine("                                                                           ");
                                esNumero = int.TryParse(n, out nro1);
                                esNumero2 = int.TryParse(n2, out nro2);
                                c1 = int.TryParse(n3, out c);
                                c2 = int.TryParse(n4, out d);
                            }

                            if (nro1 <= nro2)
                            {
                                i = nro1;
                                m = nro2;
                            }else
                            {
                                i = nro2;
                                m = nro1;
                            }

                            if(c <= d)
                            {
                                j = c;
                                k = d;
                            }else
                            {
                                j = d;
                                k = c;
                            }
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            Console.WriteLine(" _________________________________________________________________________ ");
                            Console.WriteLine("|                                                                         |");
                            Console.WriteLine("|                         MULTIPLICACION NORMAL                           |");
                            Console.WriteLine("|_________________________________________________________________________|");
                            Console.WriteLine("|                                                                         |");
                            int a2 = 0;
                            for (int x = i; x <= m; x++)
                            {
                                for (int z = j; z <= k; z++)
                                {
                                    a2 = x * z;
                            Console.WriteLine("|                             {0} x {1} = {2}", x, z, a2);
                                    
                                }
                            }
                            Console.WriteLine("|_________________________________________________________________________|");
                            Console.WriteLine("                                                                           ");
                            Console.ReadKey();
                            break;


                        case 2:
                            //Multiplicación rusa
                            esNumero = false;
                            while (esNumero == false || esNumero2==false )
                            {
                                Console.WriteLine("                                                                           ");
                                Console.Write(" --------------- Introduzca el primer número: ");
                                //nro1 = Convert.ToInt64(Console.ReadLine());
                                n = Console.ReadLine();
                                Console.WriteLine("                                                                           ");
                                Console.Write(" --------------- Introduzca el segundo número: ");
                                //nro2 = Convert.ToInt64(Console.ReadLine());
                                n2 = Console.ReadLine();
                                Console.WriteLine("                                                                           ");
                                esNumero = int.TryParse(n, out nro1);
                                esNumero2= int.TryParse(n2, out nro2);
                            }
                                                       
                            while (nro1 < 0)
                            {
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine(" _________________________________________________________________________ ");
                                Console.WriteLine("|                                                                         |");
                                Console.WriteLine("|------- EL 1ER NRO NO PUEDE SER NEGATIVO. PRESIONE PARA CONTINUAR -------|");
                                Console.WriteLine("|_________________________________________________________________________|");
                                Console.WriteLine("                                                                           ");

                                Console.BackgroundColor = ConsoleColor.Gray;
                                Console.ForegroundColor = ConsoleColor.Black;                               
                                Console.ReadKey();
                               
                                esNumero = false;
                                while (esNumero == false || esNumero2 == false)
                                {
                                    Console.WriteLine("                                                                           ");
                                    Console.Write(" ---------------Introduzca el primer número: ");
                                    //nro1 = Convert.ToInt64(Console.ReadLine());
                                    n = Console.ReadLine();
                                    Console.WriteLine("                                                                           ");
                                    Console.Write(" ---------------Introduzca el segundo número: ");
                                    //nro2 = Convert.ToInt64(Console.ReadLine());
                                    n2 = Console.ReadLine();
                                    Console.WriteLine("                                                                           ");
                                    esNumero = int.TryParse(n, out nro1);
                                    esNumero2 = int.TryParse(n2, out nro2);
                                }

                            }

                            if (nro1 != 0)
                            {
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine(" _________________________________________________________________________ ");
                                Console.WriteLine("|                                                                         |");
                                Console.WriteLine("|------------------------- MULTIPLICACIÓN RUSA ---------------------------|");
                                Console.WriteLine("|_________________________________________________________________________|");
                                Console.WriteLine("|            MULTIPLICA             ||               DIVIDE               |");
                                Console.WriteLine("|                                                                         |");


                                //mientras el número 1 sea diferente de 0:
                                while (nro1 != 0)
                                {
                                    
                                    //si tu multiplicado es impar:
                                    if (nro1 % 2 != 0)
                                    {
                                        //le sumas el valor del segundo número (multiplicando):
                                        res = res + nro2;
                                    }

                                    //divides al valor del multiplicador entre 2:
                                    nro1 = nro1 / 2;

                                    //multiplicas al valor del multiplicando por 2:
                                    nro2 = nro2 * 2;


                                    Console.Write("               {0}                       ", nro2);
                                Console.WriteLine("               {0}                       ", nro1);


                                }
                                    Console.WriteLine("|___________________________________||____________________________________|");
                            }



                            Console.WriteLine("|                                                                         |");
                            Console.WriteLine("|---- EL RESULTADO ES: {0} -------------------------------------------------|",res);
                            Console.WriteLine("|_________________________________________________________________________|");
                            Console.WriteLine("                                                                           ");
                            
                            Console.ReadKey();
                            
                            break;

                        case 3:
                            //salir
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(" _________________________________________________________________________ ");
                            Console.WriteLine("|                                                                         |");
                            Console.WriteLine("|----------------- PRESIONE CUALQUIER TECLA PARA SALIR -------------------|");
                            Console.WriteLine("|_________________________________________________________________________|");
                            Console.WriteLine("                                                                           ");
                            Console.ReadKey();
                            break;
                    }
                }
            }

        }
    }
}
