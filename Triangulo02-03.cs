using System;

namespace Triangulos_02_03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entrada c,z

            Console.Write("Ingrese el angulo c (grados)=");
            double c = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el lado z=");
            double z = double.Parse(Console.ReadLine());

            // Proceso

            double cRad = c * Math.PI/180;

            double t = z/Math.Sin(cRad);
            double y = t * Math.Cos(cRad);
            double a = Math.Atan(y/z);

            double agrados = a* 180 / Math.PI;
            y = Math.Round(y, 2);
                
                // Salida

            Console.WriteLine("El valor de t=" + t);
            Console.WriteLine("El valor de y=" + y);
            Console.WriteLine("El valor del ángulo a=" + agrados);
        }
    }
}
