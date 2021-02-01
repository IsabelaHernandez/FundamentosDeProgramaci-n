using System;

namespace DeduccionesSalariales
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entradas

            Console.WriteLine("Ingrese su salario mensual");
            int salario = int.Parse(Console.ReadLine());

            Console.WriteLine("Si su contrato es de tipo independiente escriba 1, si es dependiente escriba 2");
            int contrato = int.Parse(Console.ReadLine());

            int smmv = 908526;
            double cot = salario * 0.4;

            //Condiciones

            if (cot < smmv) cot = smmv;
            
              if (contrato ==1)
               {
                Console.WriteLine("Ingrese un número del 1 al 5 según su clase de riesgo");
                int riesgo = int.Parse(Console.ReadLine());

                if (riesgo == 1)
                {
                    double pension = cot * 0.16;
                    double eps = cot * 0.125;
                    double arl = cot * 0.00522;
                    double totaldeducciones = pension + eps + arl;

                    double salarioreal = salario - (pension + eps + arl);
                    double salarioanual = salarioreal * 12;

                    Console.WriteLine("Sus deducciones son: pension=" + pension + "eps=" + eps + "arl=" + arl);
                    Console.WriteLine("Total deducciones=" + totaldeducciones);
                    Console.WriteLine("Su salario mensual con deducciones es igual a:" + salarioreal);
                    Console.WriteLine("Su salario anual es igual a:" + salarioanual);
                }
                else if (riesgo == 2)
                {
                    double pension = cot * 0.16;
                    double eps = cot * 0.125;
                    double arl = cot * 0.01044;
                    double totaldeducciones = pension + eps + arl;

                    double salarioreal = salario - (pension + eps + arl);
                    double salarioanual = salarioreal * 12;

                    Console.WriteLine("Sus deducciones son: pension=" + pension + "eps=" + eps + "arl=" + arl);
                    Console.WriteLine("Total deducciones=" + totaldeducciones);
                    Console.WriteLine("Su salario mensual con deducciones es igual a:" + salarioreal);
                    Console.WriteLine("Su salario anual es igual a:" + salarioanual);
                }
                else if (riesgo == 3)
                {
                    double pension = cot * 0.16;
                    double eps = cot * 0.125;
                    double arl = cot * 0.02436;
                    double totaldeducciones = pension + eps + arl;

                    double salarioreal = salario - (pension + eps + arl);
                    double salarioanual = salarioreal * 12;

                    Console.WriteLine("Sus deducciones son: pension=" + pension + "eps=" + eps + "arl=" + arl);
                    Console.WriteLine("Total deducciones=" + totaldeducciones);
                    Console.WriteLine("Su salario mensual con deducciones es igual a:" + salarioreal);
                    Console.WriteLine("Su salario anual es igual a:" + salarioanual);
                }
                else if (riesgo == 4)
                {
                    double pension = cot * 0.16;
                    double eps = cot * 0.125;
                    double arl = cot * 0.04350;
                    double totaldeducciones = pension + eps + arl;

                    double salarioreal = salario - (pension + eps + arl);
                    double salarioanual = salarioreal * 12;

                    Console.WriteLine("Sus deducciones son: pension=" + pension + "eps=" + eps + "arl=" + arl);
                    Console.WriteLine("Total deducciones=" + totaldeducciones);
                    Console.WriteLine("Su salario mensual con deducciones es igual a:" + salarioreal);
                    Console.WriteLine("Su salario anual es igual a:" + salarioanual);
                }
                else if (riesgo == 5)
                {
                    double pension = cot * 0.16;
                    double eps = cot * 0.125;
                    double arl = cot * 0.06960;
                    double totaldeducciones = pension + eps + arl;

                    double salarioreal = salario - (pension + eps + arl);
                    double salarioanual = salarioreal * 12;

                    Console.WriteLine("Sus deducciones son: pension=" + pension + "eps=" + eps + "arl=" + arl);
                    Console.WriteLine("Total deducciones=" + totaldeducciones);
                    Console.WriteLine("Su salario mensual con deducciones es igual a:" + salarioreal);
                    Console.WriteLine("Su salario anual es igual a:" + salarioanual);
                }
            }
           
              else if (contrato ==2)
               {
                double pension = cot * 0.4;
                double eps = cot * 0.4;
                double totaldeducciones = pension + eps;

                int prima = smmv;

                double salarioreal = salario - (pension + eps);
                double salarioanual = (salarioreal*12) + prima;

                Console.WriteLine("Sus deducciones son: pension=" + pension + "eps=" + eps);
                Console.WriteLine("Total deducciones=" + totaldeducciones);
                Console.WriteLine("Su salario mensual con deducciones es igual a:" + salarioreal);
                Console.WriteLine("Su salario anual con deducciones y bonificación es igual a:" + salarioanual);
                Console.WriteLine("Su bonificación es:" + prima);

            }
            
        }
    }
}

//https://youtu.be/qo7F2x6w5CM