using System;

namespace alex
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * int numero = 0;

             //declaro string donde imprimire el mensaje 
             string mensaje = "";
             */

            /* Console.WriteLine("Ingrese numero entero");
             //int. parse - readline lee un string o letra y con eso se convierte
             numero = int.Parse(Console.ReadLine()); */

            /* if (numero % 2 == 0)
             {
                 // +numero+ se hace una concatenacion
                 Console.WriteLine("el numero " + numero + " es par");
             }
             else
             {
                 Console.WriteLine("el numero" + numero + " es impar");
             }
             //me da la pausa en la consola 
             Console.ReadKey();*/


            /* //operador ternario
            mensaje = (numero % 2 == 0) ? "el numero " + numero + " es par" : " el numero es impar";
            Console.WriteLine(mensaje);
            Console.ReadKey();*/



            //declaramos la variable del menu
            /* char menu = 'a';
             //declaramos la string para menu
             string mensajemenu = "";
             string mensajesalida = "";

             //"+" en string lo cancatena
             //creamos el menu para imprimir
             mensajemenu = "Bienvenidos, este es el nuevo banco\n" +
                 "a. revisar cuenta\n" +
                 "b. depositar dinero\n" +
                 "c. retirar dinero\n\n" +
                 "ingrese la opcion que desea realizar";
             Console.WriteLine(mensajemenu);

             //IF
             //leemos la opcion solicitada          
             menu = char.Parse(Console.ReadLine());
            */
            /*
            if (menu == 'A')
            {
                mensajesalida = "revisar cuenta";
            }
            else if (menu == 'B')
            {
                mensajesalida = "depositar dinero";

            }
            else if (menu == 'C')
            {
                mensajesalida = "retirar dinero";
            }
            else
            {
                mensajesalida = "opcion nooooooooooooo valida";

            }

            Console.WriteLine(mensajesalida);
            
            */

            //SWITCH
            /*
            switch (menu)
            {
                case 'A':
                    mensajesalida = "revisar cuenta";
                    break;
                case 'B':
                    mensajesalida = "depositar dinero";
                    break;
                case 'C':
                    mensajesalida = "retirar dinero";
                    break;
                default:
                    mensajesalida = "opcion nooooooooooooo valida";
                    break;

            }
            Console.WriteLine(mensajesalida);


            */
            /*
            //BUCLE WHILE

            //variable a solicitar
            int numero = 0;
            int i = 0;

            //bandera para que no me pase en el bucle
            //solicitamos munero al usuario

            Console.WriteLine("ingrese un numero de veces del bucle\n");
           
            numero = int.Parse(Console.ReadLine());
            while (i < numero)
            {
                Console.WriteLine(i);
                i++;
        
            }
            Console.WriteLine("acciones finalizadas");
            Console.ReadKey();
            */


            /*
              //BUCLE DO WHILE
            //variable a solicitar
            int numero = 0;
            int i = 0;

            //bandera para que no me pase en el bucle
            //solicitamos munero al usuario

            Console.WriteLine("ingrese un numero de veces del bucle\n");
            //CAMBIO EL NUMERO QUE SE INGLESE POR UN ENTERO
            numero = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine(i);
                i++;
            }

            while (i < numero);
            {
                

            }
            Console.WriteLine("acciones finalizadas");
            */


            /*
            //BUCLE FOR
            int numero = 7;
            for (int i = 0; i < numero; i++)
            {
                Console.WriteLine(i+"\n");
            }

            Console.WriteLine("acciones finalizadas");
            Console.ReadKey();*/
            //BUCLE FOREACH
            int [,]oso = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 0 } };
            
            //de todos los numeros enteros que me encuentre guardalos
            foreach (int n in oso)
            {
                Console.WriteLine(n + "\n");
            }

            for(int i =0; i<2; i++)
            {
                for(int h =0;h<5; h++ )
                    Console.WriteLine(oso[i,h]+"\n");

              
            }
            
            Console.ReadKey();
        }
    }
}
