using System;
using System.Collections.Generic;
using System.IO.Pipelines;
using System.Reflection.Metadata.Ecma335;

public class Program
{
    //clave, y tipo
     static Dictionary<int, long> result= new Dictionary<int, long>();
    public static void Main()
    {
        
        int numero = 50; 

        while (numero >= 50)
        {
            Console.WriteLine("Que numero deseas ingresar: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero >= 50)
            {
                Console.WriteLine("Ups. . . intenta con numero mas chico");
            }
        }

        //llamas a la funcion
        Console.WriteLine("Calculando el Fibonacci de " + numero);
        long resultado = Fibonacci(numero);
        
        
        Console.WriteLine($"El resultado es:{resultado} ");
    }

    
    public static long Fibonacci(int numero)
    {
        if (numero == 0) return 0;
        if (numero == 1) return 1;
        if (result.ContainsKey(numero))
        {
            //checa primero por un if si el valor ya se habia calculado antes para nomas regresarlo
          return result[numero];  
        }
        long Value= Fibonacci(numero - 1) + Fibonacci(numero - 2);
        //si no, entonces se guarda el valor en el diccionario
        result[numero]=Value;
        return Value;
    }
}