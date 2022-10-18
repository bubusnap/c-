// See https://aka.ms/new-console-template for more information
// ejercicio n1 de c

using System;

//namespace Ejercicio
//{
//    class Mensaje
//    {
//        static void Main(String[] args)
//        {
//            Console.WriteLine("Plan dentaaal");
//            Console.WriteLine("Lisa necesita frenos");
//        }
//    }
//}

//namespace PuntoDos
//{
//    class Sumar
//    {
//        static void Main()

//        {
//            int primerNumero = 5;
//            int total=0;

//            for (int i = 0; i != 3; i++) { Console.WriteLine(total=total+primerNumero);  ; }

//        }
//    }
//}

//namespace PuntoTres
//{
//    class Muestra
//    {
//        static void Main()
//        {
//            for (int i = 0; i < 15; i++) { Console.WriteLine(i); }
//        }
//    }
//}

//namespace PuntoCuatro
//{
//    class SumaCadena
//    {
//        static void Main()
//        {
//            int n = 0;
//            int num = 1;
//            int total = 0;
//            do
//            {
//                Console.WriteLine(total = num + total ); 
//                n++;
//                num++;
//            } while (n < 35);
//        }
//    }
//}

//namespace PuntoCinco
//{
//    class Promedio
//    {
//        static void Main()
//        {
//            int x = 25;
//            int y = 26;
//            int z = 35;
//            double avg;

//            Console.WriteLine(avg=(x+y+z)/3);
//        }
//    }
//}

//namespace PuntoSiete
//{
//    class Lectura
//    {
//        static void Main(string[]args)
//        {
//            Console.WriteLine("Introduzca una palabra u oracion y luego presione enter...");
//            String Texto;
//            Texto=Console.ReadLine();
//            Console.WriteLine("Usted puso: "+Texto);
//        }
//    }
//}

namespace PuntoOcho
{
    class Impares
    {
        static void Main()
        {
            int num = 1;
            int total = 1;
            while (num < 70)
            {
                total = total * num ;
                num=num+2;
                Console.WriteLine (total);
              
                
            }
        }
    }

}