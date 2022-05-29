Console.WriteLine("Ingrese un numero: ");
String num = Console.ReadLine();
int numero = Convert.ToInt32(num);

if (numero > 0)
{
    int dividendo = numero;
    int num_invertido = 0, resto = dividendo % 10;
    while(dividendo != 0)
    {   
        resto = dividendo % 10;
        dividendo /= 10;
        num_invertido = (num_invertido + resto) * 10;
    }
    num_invertido /=10;
    Console.WriteLine ("El número ingresado es: " + numero + " y, el numero al reves es: " + num_invertido);
} else
{
    Console.WriteLine ("El número ingresado debe ser mayor que cero");
}