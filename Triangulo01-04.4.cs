using System;

namespace Triangulo01_04._4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada w,t,c

            Console.Write("Ingrese w=");
            double w = double.Parse(Console.ReadLine());

            Console.Write("Ingrese t=");
            double t = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el angulo c (grados)=");
            double c = double.Parse(Console.ReadLine());

            //Proceso

            double cRad = c * (Math.PI / 180.0);

            double z = Math.Sin(cRad) * t;
            double y = Math.Sqrt(t * t - z * z);
            double x = Math.Sqrt(w * w - z * z) - y;

            x = Math.Round(x, 2);

            //Salida

            Console.WriteLine("x = " + x);
        }
    }
}
