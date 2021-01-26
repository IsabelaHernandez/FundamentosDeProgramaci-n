using System;

namespace Triangulos_02_02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entrada t,a

            Console.Write("Ingrese el lado t:");
            double t = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el angulo a (grados):");
            double a = double.Parse(Console.ReadLine());

            // Proceso

            double aRad = a * Math.PI / 180;

            double z = t*Math.Cos(aRad);
            double y = t*Math.Sin(aRad);
            double c = Math.Atan(z/y);

            double cgrados = c * 180 / Math.PI;

            // Salida

            Console.WriteLine("El valor de z=" + z);
            Console.WriteLine("El valor de y=" + y);
            Console.WriteLine("El valor del ángulo c=" + cgrados);
           

        }
    }
}
