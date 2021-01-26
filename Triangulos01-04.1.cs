using System;

namespace Triangulos_01__04._1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Entrada b,z,y

            Console.Write("Ingrese el angulo b(grados)=");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Ingrese z=");
            double z = double.Parse(Console.ReadLine());

            Console.Write("Ingrese y=");
            double y = double.Parse(Console.ReadLine());

            //Proceso

            double a = Math.Atan(y/z);
            double aGrados = a * (180.0 / Math.PI);

            double f = aGrados + b;
            double fRad = f * (Math.PI / 180.0);

            double x = (Math.Tan(fRad) * z) - y;


            x = Math.Round(x, 2);

            //Salida 
                
            Console.WriteLine("x =" + x);
        }
    }
}
