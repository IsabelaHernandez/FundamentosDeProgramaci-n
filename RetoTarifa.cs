using System;

namespace RetoTarifa1._0
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
			}
			else if (2 <= SM && SM <= 4)
			{
				Console.WriteLine(" TARIFA B");
			}
			else if (SM > 4)
			{
				Console.WriteLine("TARIFA C");
			}

		}
	}
    
}
//https://youtu.be/qo7F2x6w5CM