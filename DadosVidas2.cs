using System;

namespace DadosVidas2
{
    class Program
    {
        static void Main(string[] args)
        {

            Random aleatorio = new Random();
            string respuesta = "s";

            int dado = 0, totaltiros = 0;
            double contador1 = 3, contador2 = 0, contador3 = 3;
            //Contador1 : Turnos totales, Contador2: Perder vida, Contador3: Vidas.


            Console.WriteLine("Desea jugar? (s/n)");
            respuesta = Console.ReadLine();


            if (respuesta == "s")
            {
                Console.WriteLine("Usted inicia con 3 vidas, cada 2 turnos puede perder una vida");
                Console.WriteLine("Cada 3 turnos tira 2 dados, si estos salen iguales usted obtiene una vida");

                while (totaltiros < 100 && contador3 > 0)
                {

                    Console.WriteLine("Desea continuar? (s/n)");
                    respuesta = Console.ReadLine();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Vidas:" + contador3);
                    Console.ForegroundColor = ConsoleColor.White;

                    
                    if (respuesta == "s" )
                    {
                        contador1++;
                        contador2++;

                        dado = aleatorio.Next(1, 7);
                        Console.Write("Dado: " + dado);

                        totaltiros += dado;
                        Console.WriteLine(" Total tiros: " + totaltiros);
                        
                    }

                    if (contador1 % 3 == 0)
                    {
                        contador1 = 0;

                        int dadon = aleatorio.Next(1, 7);

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("Dado2 : " + dadon);
                        Console.ForegroundColor = ConsoleColor.White;


                        totaltiros += dado + dadon;
                        Console.WriteLine(" Total tiros: " + totaltiros);

                        if (dado == dadon)
                        {
                            contador3++;

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Ha obtenido una vida");
                            Console.ForegroundColor = ConsoleColor.White;
                           
                        }
                    }


                    if (contador2 % 2 == 0)
                    {
                        contador3--;
                    }

                    if (contador3 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Has perdido");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
  

                    if (totaltiros > 99)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Felicidades, has ganado.");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }

                    while (respuesta != "s" && respuesta != "n")
                    {
                        Console.WriteLine("Entrada no valida");
                        break;
                    }
                }       
               
            }
        }
    }
}
//https://youtu.be/8eQaZgWGj04