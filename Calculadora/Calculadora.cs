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
    class CalculadoraV2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero: ");
            String num = Console.ReadLine();
            double numero = Convert.ToDouble(num);

            double valor_absoluto = Math.Abs(numero);
            Console.WriteLine("Valor absoluto: " + valor_absoluto);

            double cuadrado = Math.Exp(numero);
            Console.WriteLine("Cuadrado: " + cuadrado);

            double raiz_cuadrada = Math.Sqrt(numero);
            Console.WriteLine("Raiz Cuadrada: " + raiz_cuadrada);

            double sen = Math.Sin(numero);
            Console.WriteLine("Seno: " + sen);
            
            double cos = Math.Cos(numero);
            Console.WriteLine("Coseno: " + cos);

            int entero = (int)Math.Round(numero);
            Console.WriteLine("Redondeado a entero: " + entero);

            Console.WriteLine("Ingrese dos numeros para determinar el mayor de ellos:");
            Console.WriteLine("Primer numero: ");
            String PrimNum = Console.ReadLine();
            double num1 = Convert.ToDouble(PrimNum);

            Console.WriteLine("Segundo numero: ");
            String SecNum = Console.ReadLine();
            double num2 = Convert.ToDouble(SecNum);

            double minor = Math.Min(num1, num2);
            Console.WriteLine("El numero " + minor + " es el menor de los dos");

            double maxim = Math.Max(num1, num2);
            Console.WriteLine("El numero " + maxim + " es el mayor de los dos");
        }
    }
}