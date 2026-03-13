using System;
using System.Collections;   
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Runtime.InteropServices.Marshalling;

public class Program
{
    //encapsulamiento es para que el usuario no sepa como el programa funciona
    public static void Main()
    {
         BankAccount cuenta=new BankAccount();
        string entrada="";
        while(entrada !="salir" )
        {
         
        Console.WriteLine("Que tipo de movimiento deseas reaclizar: ");
        Console.WriteLine("consultar saldo: (A) ");
        Console.WriteLine("Depositar: (b) ");
        Console.WriteLine("Retirar: (C) ");
        Console.WriteLine("Mostrar Historial: (D) ");
        string decision= Console.ReadLine()!;
        if (decision == "a" || decision=="A")
        {
        Console.WriteLine("saldo actual: " + cuenta.ConsultarSaldo());  
        } else if(decision=="b"|| decision == "B")
        {
        Console.WriteLine("¿cuanto desea depositar?: ");    
        int deposito= Convert.ToInt32(Console.ReadLine());
       
        cuenta.Depositar(deposito);
         Console.WriteLine("Balance after deposit:" + cuenta.ConsultarSaldo());
        }else if (decision == "c" || decision == "C")
        {
            Console.WriteLine("¿Cuanto deseas retirar?");
           int retiro= Convert.ToInt32(Console.ReadLine());
           cuenta.Retirar(retiro);
            Console.WriteLine("Balance after withdraw:" + cuenta.ConsultarSaldo());
        }else if (decision == "d" || decision == "D")
        {
            cuenta.MostrarHistorial();
        }
        else
        {
           Console.WriteLine("Error"); 
        }  
        Console.WriteLine("deseas salir?: ");
        entrada = Console.ReadLine()!;
        }
        
        
    }
}
public class BankAccount{
    private  double saldo=0;
    private List <string> historial = new List<string>();
    public double ConsultarSaldo()
    {
        return saldo;
    }
    public void Depositar(double cantidad)
    {
        Console.WriteLine("¿Cuanto deseas depositar?: ");
        
        saldo+= cantidad;
        historial.Add($"deposito: {cantidad} ");
    }
    public void Retirar(double cantidad)
    {
        saldo-= cantidad;
        historial.Add($"deposito: {cantidad} ");
    }

    public void MostrarHistorial()
    {
        Console.WriteLine("Transaction history: ");
        foreach(var entry in historial)
        {
            Console.WriteLine(entry);
        }
    }
}