Console.WriteLine("Ingrese una frase:");
String frase = Console.ReadLine();

if(frase != null && frase != "")
{
    int cant_char = frase.Length;//LARGO DE CADENA

    //OBTENER ALGUNAS LETRAS
    var rand = new Random();//creamos variable rand para obtener numeros aleatorios
    String subfrase1,subfrase2 = "";

    subfrase1 = frase.Substring(0,1);//primera
    if(cant_char > 1)
    {
        subfrase2 = frase.Substring(1,1);//segunda
    }

    //Unir dos cadenas
    Console.WriteLine("Ingrese una segunda frase para unir a la anterior:");
    String sec_frase = Console.ReadLine();
    String frase_concat = string.Concat(frase," ", sec_frase);

    //Obtener segunda palabra
    String seg_palabra = "";
    int firstblank = frase.IndexOf(" ");

    if(firstblank != null && firstblank > 0)
    {
        firstblank += 1;
        String obtain = frase.Substring(firstblank);
        if(obtain.IndexOf(" ") > 0)
        {
            seg_palabra = frase.Substring(firstblank,obtain.IndexOf(" "));//frase <= 2 palabras
        } else{
            seg_palabra = frase.Substring(firstblank,obtain.LastIndexOf(""));// frase > 2 palabras
        }
    }

    String mayusc = frase.ToUpper();
    String minusc = frase.ToLower();
    String[] spliter = frase.Split(" ");

    Console.WriteLine("La letra tomada es " + subfrase1 + " del primer caracter");
    if(cant_char > 1)
    {
        Console.WriteLine("La letra tomada es " + subfrase2 + " del segundo caracter");
    }
    Console.WriteLine("La longitud de la primera frase es de " + cant_char + " caracteres");
    Console.WriteLine("La frase concatenada quedaria: " + frase_concat);
    if (seg_palabra != "")
    {
        Console.WriteLine("La segunda palabra de la frase es: " + seg_palabra);
    }
    Console.WriteLine("La frase en mayusculas quedaria: " + mayusc);
    Console.WriteLine("La frase en minusculas quedaria: " + minusc);

    foreach(string split in spliter)
    {
        Console.WriteLine(split);
    }


    //CALCULADORA
        Console.WriteLine("Ingrese la operación a realizar entre dos numeros:");
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

        String num1 = Convert.ToString(PrimNum);
        String num2 = Convert.ToString(SegdoNum);
        double resultado;
        
        if (opcion == 1)
        {
            resultado = PrimNum + SegdoNum;
            String result = Convert.ToString(resultado);
            Console.WriteLine("La suma entre " + num1 + " y "+ num2 +" es: " + result);
        } else if (opcion == 2){
            resultado = PrimNum - SegdoNum;
            String result = Convert.ToString(resultado);
            Console.WriteLine("La resta entre " + num1 + " y "+ num2 +" es: " + result);
        } else if (opcion == 3){
            resultado = PrimNum * SegdoNum;
            String result = Convert.ToString(resultado);
            Console.WriteLine("La multiplicacion entre " + num1 + " y "+ num2 +" es: " + result);
        } else if (opcion == 4){
            if (SegdoNum != 0) {
                resultado = PrimNum / SegdoNum;
                String result = Convert.ToString(resultado);
                Console.WriteLine("La division entre " + PrimNum + " y "+ num2 +" es: " + result);
            } else {
                Console.WriteLine("El numero asignado debe ser distinto de cero");
            }
        } else {
            Console.WriteLine("Se ha elegido una opcion incorrecta");
        }
        //CALCULADORA

        foreach(char letra in frase) 
        {
            Console.WriteLine(letra);
        }

        //CALC por string
        Console.WriteLine("Ingrese una ecuacion");
        String ecuacion = Console.ReadLine();

        int final_value = 0, nums, not_final_value = 0;
        char[] delimitadores = {'+', '-', '*', '/'};
        char[] num_limits = {'1','2','3','4','5','6','7','8','9','0'};
        string[] ecuation = ecuacion.Split(num_limits);
        string[] numeros = ecuacion.Split(delimitadores);
        foreach(string num in numeros)
        {
            nums = Convert.ToInt32(num);
            if(final_value != 0)
            {
                foreach(string caracter in ecuation)
                {
                    if(caracter == "+")
                    {
                        final_value += nums;
                    } else if(caracter == "-"){
                        final_value -= nums;
                    } else if(caracter == "*"){
                        final_value *= nums;
                    } else if(caracter == "/"){
                        if(nums != 0){
                            final_value /= nums;
                        } else {
                            not_final_value = 1; //dividendo = 0
                        }
                    }
                }
            } else {
                final_value += nums;
            }
        }
        if(not_final_value == 0)
        {
            Console.WriteLine("resultado: " + final_value);
        } else {
            Console.WriteLine("Syntax error: no puede dividirse en cero");
        }
}else{
    Console.WriteLine("Debe ingresar una frase");
}