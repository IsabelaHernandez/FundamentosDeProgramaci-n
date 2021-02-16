using System;

namespace ValoresExtremos
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int i = 0; //Contador
            int max = 0, min = 200;
            string nombremin = "", nombremax = "";
           

            Console.WriteLine("Ingrese el número de datos (n)");
            int n = int.Parse(Console.ReadLine());


            while (i < n)
            {
                Console.Write("Edad: ");
                int edad = int.Parse(Console.ReadLine());

                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();

                if (edad < min)
                {
                    min = edad;
                    nombremin = nombre;
                }
                if (edad > max)
                {
                    max = edad;
                    nombremax = nombre;
                }

                total += edad;
                i++;             
                
            }

            double promedio = total / n;
            Console.WriteLine("Promedio =" + promedio);
            Console.WriteLine("Mayor =" + nombremax + " Edad=" + max );
            Console.WriteLine("Menor =" + nombremin + " Edad=" + min);
        } 
    }
}

//https://youtu.be/ZYZwHCmkyuk
