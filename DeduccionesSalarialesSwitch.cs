using System;

namespace DeduccionesSwitch
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese su salario mensual: ");
            double salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Si su contrato es de tipo independiente escriba 1, si es dependiente escriba 2");
            int tipoContrato = int.Parse(Console.ReadLine());

            double cot = salario * 0.4;
            double arl = 0;
            double smmlv = 877802;

            if (cot < smmlv)
            {
                cot = smmlv;
            }

            switch (tipoContrato)
            {

                case 1:
                    Console.WriteLine("Número de riesgo laboral (1-5)");
                    int riesgo = int.Parse(Console.ReadLine());
                    double pensión = cot * 0.16;
                    double epss = cot * 0.125;


                    switch (riesgo)
                    {
                        case 1: arl = 0.00522; break;

                        case 2: arl = 0.01044; break;

                        case 3: arl = 0.02436; break;

                        case 4: arl = 0.04350; break;

                        case 5: arl = 0.0696; break;
                    }

                    arl *= cot;
                    double realsalario = salario - (pensión + epss + arl);
                    double anualsalario = realsalario * 12;
                    Console.WriteLine("Su salario real es" + realsalario);
                    Console.WriteLine("Su salario anual es" + anualsalario); break;


                case 2:

                    double pension = cot * 0.04;
                    double eps = cot * 0.04;
                    double salarioreal = salario - (pension + eps);
                    double bonificacion = salario;
                    double salarioanual = (salarioreal * 12) + bonificacion;

                    Console.WriteLine("Su salario real es" + salarioreal);
                    Console.WriteLine("Su salario anual es" + salarioanual); break;
            }
        }
    }
}
//https://youtu.be/Kuag1tlgQQg

