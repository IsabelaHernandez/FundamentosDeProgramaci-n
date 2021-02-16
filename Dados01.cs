using System;

namespace Dados01
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            string respuesta = "s";
            int total = 0;
            int dadoa = 0, dadob = 0;
            int par = 0, totaltiros = 0;
            double contador1 = 0, contador2 = 0; //Contador1 : total, Contador2: dadoa+dadob<6
            

            //Inicio

            Console.WriteLine("Desea jugar? (s/n)");
            respuesta = Console.ReadLine();


            while (respuesta == "s")
            {
                contador1 += 1;

                dadoa = aleatorio.Next(1, 7);
                Console.Write("Dado a:" + dadoa);

                dadob = aleatorio.Next(1, 7);
                Console.WriteLine(" Dado b:" + dadob);

                total = dadoa + dadob;
                Console.Write("Total dados:" + total);

                totaltiros += total;
                Console.WriteLine(" Total tiros:" + totaltiros);

                if (total > 6) contador2 += 1;
                
                if (dadoa == dadob) par += 1;
                Console.WriteLine("Total de pares:" + par);

                if ((dadoa == 1) && (dadob == 1))
                {
                    
                    Console.WriteLine("Has perdido");
                    respuesta = "n";

                    double porcentaje = (contador2 / contador1) * 100;
                    Console.WriteLine("Porcentaje de tiros mayores a 6:" + porcentaje);

                }

                if ((totaltiros > 99) || (par == 3))
                {
                    Console.WriteLine("Felicidades, has ganado.");
                    respuesta = "n";

                    double porcentaje = (contador2 / contador1) * 100;
                    Console.WriteLine("Porcentaje de tiros mayores a 6:" + porcentaje);
                }

                if ((totaltiros <100) && (respuesta== "s"))
                {
                    Console.WriteLine("Desea continuar? (s/n)");
                    respuesta = Console.ReadLine(); 
                }
                    

                
            }

        }
    } 
}
//https://youtu.be/ZYZwHCmkyuk
