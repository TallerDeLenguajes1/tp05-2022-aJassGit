using System;

namespace TP05
{
    class CalculadoraV1
    {
        static void Main(string[] args)
        {
            int new_calc;
            do
            {
                Console.WriteLine("Ingrese la operación a realizar entre ellos:");
                Console.WriteLine("[1]-Sumar");
                Console.WriteLine("[2]-Restar");
                Console.WriteLine("[3]-Multiplicar");
                Console.WriteLine("[4]-Dividir");
                String option = Console.ReadLine();
                int opcion = Convert.ToInt32(option);


                Console.WriteLine("Ingrese el primer número a operar");
                String FirstNum = Console.ReadLine();
                double PrimNum = Convert.ToDouble(FirstNum);

                Console.WriteLine("Ingrese el segundo número a operar");
                String SecNum = Console.ReadLine();
                double SegdoNum = Convert.ToDouble(SecNum);

                Console.WriteLine("¿Desea obtener calculos matematicos?");
                Console.WriteLine("Si = 1, No = 2");
                String math_calc = Console.ReadLine();
                int opcional = Convert.ToInt32(math_calc);
                if(opcional == 1)
                {
                    double valor_absoluto = Math.Abs(PrimNum);
                    Console.WriteLine("Valor absoluto de " + PrimNum + ": " + valor_absoluto);

                    double cuadrado = Math.Exp(PrimNum);
                    Console.WriteLine("Cuadrado de " + PrimNum + ": " + cuadrado);

                    double raiz_cuadrada = Math.Sqrt(PrimNum);
                    Console.WriteLine("Raiz Cuadrada " + PrimNum + ": " + raiz_cuadrada);

                    double sen = Math.Sin(PrimNum);
                    Console.WriteLine("Seno " + PrimNum + ": " + sen);
                    
                    double cos = Math.Cos(PrimNum);
                    Console.WriteLine("Coseno " + PrimNum + ": " + cos);

                    int entero = (int)Math.Round(PrimNum);
                    Console.WriteLine("Redondeado a entero " + PrimNum + ": " + entero);

                    double minor = Math.Min(PrimNum, SegdoNum);
                    Console.WriteLine("El numero " + minor + " es el menor de los dos");

                    double maxim = Math.Max(PrimNum, SegdoNum);
                    Console.WriteLine("El numero " + maxim + " es el mayor de los dos");
                }

                double resultado;
                if (opcion == 1)
                {
                    resultado = PrimNum + SegdoNum;
                    Console.WriteLine("El numero resultante es " + resultado);
                } else if (opcion == 2){
                    resultado = PrimNum - SegdoNum;
                    Console.WriteLine("El numero resultante es " + resultado);
                } else if (opcion == 3){
                    resultado = PrimNum * SegdoNum;
                    Console.WriteLine("El numero resultante es " + resultado);
                } else if (opcion == 4){
                    if (SegdoNum != 0) {
                        resultado = PrimNum / SegdoNum;
                        Console.WriteLine("El numero resultante es " + resultado);
                    } else {
                        Console.WriteLine("El numero asignado debe ser distinto de cero");
                    }
                } else {
                    Console.WriteLine("Se ha elegido una opcion incorrecta");
                }
                Console.WriteLine("¿Desea realizar un nuevo calculo?");
                Console.WriteLine("Si = 1, No = 2");
                String nuevo_calc = Console.ReadLine();
                new_calc = Convert.ToInt32(nuevo_calc);
                if(new_calc == 2 || new_calc == 2)
                {
                    Console.WriteLine("A continuación se cerrara el programa");
                }
            }while(new_calc == 1 || new_calc == 1);
        }
    }
}