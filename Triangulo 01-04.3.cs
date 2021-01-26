using System;

namespace Trienagulo01_04._3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entradas w,d,x

            Console.Write("Ingrese w= ");
            double w = double.Parse(Console.ReadLine());

            Console.Write("Ingrese el angulo d (grados)= ");
            double d = double.Parse(Console.ReadLine());

            Console.Write("Ingrese x= ");
            double x = double.Parse(Console.ReadLine());

            //Proceso

            double drad = d * (Math.PI / 180.0);

            double F = (Math.PI) - (Math.PI / 2) - drad;
            double y = Math.Sin(F) * w - x;

            y = Math.Round(y, 2);

            //Salida 

            Console.WriteLine("y=" + y);
        }
    }
}
//https://youtu.be/UKVNSqTTJyE
