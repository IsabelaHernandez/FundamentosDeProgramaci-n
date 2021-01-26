using System;

namespace Triangulo_01_04._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entradas d,b,y 

            Console.Write("Ingrese el angulo d (grados)= ");
            double d = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el angulo b (grados) =: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Ingrese y=");
            double y = double.Parse(Console.ReadLine());

            //proceso

            double dRad = d * (Math.PI / 180.0);
            double bRad = b * (Math.PI / 180.0);

            double e = (Math.PI) - (dRad) - (bRad);
            double c = (Math.PI) - (e);
            double z = Math.Tan(c) * y;

            z = Math.Round(z, 3);

            //Salida

            Console.WriteLine("z = " + z);
        }
    }
}
