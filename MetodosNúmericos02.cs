using System;

namespace MetodosNúmericos02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese x");
           
            double x = double.Parse(Console.ReadLine());

            Sin(x);
        }
        
        static void Sin(double x)
        {
            double resultado = 0;

            int n = 100;
           
            for (int i = 0; i < n; i++)
            {
                resultado += ((Math.Pow(-1, i)) / Factorial((2 * i) + 1)) * (Math.Pow(x, (2 * i) + 1)); 
            }

            Console.WriteLine("El resultado es: " + resultado);

        }

        static double Factorial(double valor)
        {
            if (valor <= 1) return 1;
            return valor * Factorial(valor - 1);
        }
        

}
}

//https://youtu.be/tcjG32-spH0