using System;

namespace TP05
{
    class CalculadoraV1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer número a operar");
            String FirstNum = Console.ReadLine();
            int PrimNum = Convert.ToInt32(FirstNum);

            Console.WriteLine("Ingrese el segundo número a operar");
            String SecNum = Console.ReadLine();
            int SegdoNum = Convert.ToInt32(SecNum);

            Console.WriteLine("Ingrese la operación a realizar entre ellos:");
            Console.WriteLine("[1]-Sumar");
            Console.WriteLine("[2]-Restar");
            Console.WriteLine("[3]-Multiplicar");
            Console.WriteLine("[4]-Dividir");
            String option = Console.ReadLine();
            int opcion = Convert.ToInt32(option);

            int resultado;
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
        }
    }
}