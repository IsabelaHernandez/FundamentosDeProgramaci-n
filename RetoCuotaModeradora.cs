using System;

namespace Reto2Cuota
{
    class Program
    {
        static void Main(string[] args)
        {
			// Entrada 

			Console.WriteLine("Ingrese la cantidad de salarios minimos mensuales vijentes que recibe (en número): ");
			double SM = double.Parse(Console.ReadLine());

			//Condiciones 

			if (SM < 2)
			{
				Console.WriteLine("TARIFA A");
				Console.WriteLine("Cuota moderadora: $3.500");
			}
			else if (2 <= SM && SM <= 5)
			{
				Console.WriteLine(" TARIFA B");
				Console.WriteLine("Cuota moderadora: $14.000");
			}
			else if (SM > 5)
			{
				Console.WriteLine("TARIFA C");
				Console.WriteLine("Cuota moderadora: $36.800");
			}

		}
	
    }
}
//https://youtu.be/qo7F2x6w5CM