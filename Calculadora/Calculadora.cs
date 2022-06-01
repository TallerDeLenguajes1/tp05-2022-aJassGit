using System;

namespace TP05
{
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