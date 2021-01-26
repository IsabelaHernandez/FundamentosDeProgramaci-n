using System;

namespace Triangulos_02_01
{
    class Program
    {
        static void Main(string[] args)
        {

            //Entrada y,z

            Console.Write("Ingrese el lado Y:");
            double y = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el lado Z:");
            double z = double.Parse(Console.ReadLine());

            // Proceso

            double c = Math.Atan(z / y);
            double a = Math.Atan(y / z);
            double t = (z / Math.Sin(c));

            double cgrados = c * 180 / Math.PI;
            double agrados = a * 180 / Math.PI;

            // Salida

            Console.WriteLine("El valor del ángulo c=" + cgrados);
            Console.WriteLine("El valor del ángulo a=" + agrados);
            Console.WriteLine("El valor de t=" + t);



        }
    }
}

//https://youtu.be/_8VOBVsfWs4