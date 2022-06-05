using System;
namespace TP05
{
    class TakeString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una frase:");
            String frase = Console.ReadLine();

            if(frase != null)
            {
                int cant_char = frase.Length;//LARGO DE CADENA

                //OBTENER ALGUNAS LETRAS
                var rand = new Random();//creamos variable rand para obtener numeros aleatorios
                String subfrase1,subfrase2;
            
                subfrase1 = frase.Substring(0,1);
                subfrase2 = frase.Substring(1,1);

                //Unir dos cadenas
                Console.WriteLine("Ingrese una segunda frase para unir a la anterior:");
                String sec_frase = Console.ReadLine();
                String[] concat_phrase = {frase, sec_frase};
                String frase_concat = string.Concat(concat_phrase);

                //Obtener segunda palabra
                int firstblank = frase.IndexOf(" ");
                firstblank += 1;
                String seg_palabra = frase.Substring(firstblank,frase.IndexOf(" "));

                
                                
                Console.WriteLine("La letra tomada es " + subfrase1 + " del primer caracter");
                if(cant_char > 1)
                {
                    Console.WriteLine("La letra tomada son " + subfrase2 + " del segundo caracter");
                }
                Console.WriteLine("La longitud de la primera frase es de " + cant_char + " caracteres");
                Console.WriteLine("La frase concatenada quedaria: " + frase_concat);
                Console.WriteLine("La segunda palabra es: " + seg_palabra);


            }else{
                Console.WriteLine("Debe ingresar una frase");
            }
        }
    }
}