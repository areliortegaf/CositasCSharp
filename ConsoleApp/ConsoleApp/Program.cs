using System;

namespace ConsoleApp
{
    class Program {


        public static string borrarCaracter(string cadena, int posicion)
        {
            return cadena.Remove(posicion, 1);//a la cadena quitale en tal pocicion un caracter
        }

        static void Main(string[] args)
        {
            //Ej.1
            Console.WriteLine("Hola");
            Console.WriteLine("ARELI");
            //Ej.2
            double numero1 = 10;
            double numero2 = 20;

            double sumarotiaInt = numero1 + numero2;
            Console.WriteLine(sumarotiaInt);

            //EJERCIOCIO 3
            double divicion = numero2 / numero1;
            Console.WriteLine(divicion);

            //EJECRCIOCIO 4
            double operacion1 = -1 + 4 * 6;
            double operacion2 = (35 + 5) % 7;
            double operacion3 = 14 + -4 * 6 / 11;
            double operacion4 = 2 + 15 / 6 * 1 - 7 % 2;

            Console.WriteLine(operacion1);
            Console.WriteLine(operacion2);
            Console.WriteLine(operacion3);
            Console.WriteLine(operacion4);

            //EJERCICIO 5
            //intercambiar valores
            int valorUno = 6;
            int valorDos = 5;

            int temp;

            temp = valorUno;
            valorUno = valorDos;
            valorDos = temp;
            Console.WriteLine("valor uno: " + valorUno);
            Console.WriteLine("valor dos: " + valorDos);

            //EJ.6
            //LEER NUMEROS DESDE EL USUARIO Y MULTIPLICARLOS
            int leerValor1, leerValor2;
            Console.WriteLine("Ingrese el valor 1");
            leerValor1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el valor 2");
            leerValor2 = Convert.ToInt32(Console.ReadLine());

            int result = leerValor1 * leerValor2;

            Console.WriteLine("Resultado: " + result);

            //EJ7
            Console.WriteLine(borrarCaracter("Hola",2));

            //DE LEY
            Console.Read();

        }
    }
}
