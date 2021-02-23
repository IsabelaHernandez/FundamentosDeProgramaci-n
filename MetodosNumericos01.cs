using System;

namespace MetodosNumericos01
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                Console.WriteLine("Ingrese x: ");

                double x = double.Parse(Console.ReadLine());

                int n = 100;

                double total = 0;

                for (int i = 0; i < n; i++)
                {
                    total += (Math.Pow(x, i) / Factorial(i));
                }
                Console.WriteLine("Valor de 'e' : " + total);
            }
            static double Factorial(double valor)
            {
                if (valor <= 1) return 1;
                return valor * Factorial(valor - 1);
               
            }
        }
    }
}

//https://youtu.be/tcjG32-spH0