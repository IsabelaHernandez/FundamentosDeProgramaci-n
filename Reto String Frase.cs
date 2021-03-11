using System;

namespace Reto_Frases
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = "", palabra = "";
            int contador = 0;

            Console.WriteLine("Ingrese la frase");
            frase = Console.ReadLine().ToUpper();

            Console.WriteLine("Ingrese la palabra en cuestión");
            palabra = Console.ReadLine().ToUpper();

            string[] palabras = frase.Split(" ");

          
            for (int i = 0; i < palabras.Length; i++)
            {
                if (palabras[i] == palabra)
                {

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Palabra en posición: " + i);
                    Console.ForegroundColor = ConsoleColor.White;

                    contador++;
                }
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Total de veces que apareció la palabra: " + contador );
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
//https://youtu.be/ApyF4rIoyCQ