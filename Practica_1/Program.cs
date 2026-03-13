using System;
using System.Collections.Generic;

public class Program
{
    /*Description: Students will solve a practical case study where they implement
     a C# program to manage a product inventory in a store.
    */
    public static void Main()
    {
       
        LinkedList<Producto> Carrito= new LinkedList<Producto>();
        int precio= 0;
        string compras= "";
        bool ciclo= true;
        while(ciclo==true)
        {
            Console.WriteLine("Agrega articulo: (teclea 'salir' para terminar el regristro de articulos)");
                Console.WriteLine("Nombre:");
                compras=Console.ReadLine() ?? ""; // con el ?? y "" hace que quite la adevrtencia del readline
                if (compras == "salir")
            {
                break;
            }
                Console.WriteLine("introduce precio:");
                precio=Convert.ToInt32(Console.ReadLine());
                Carrito.AddFirst(new Producto{Nombre=compras,Precio=precio});
            
        }
        
        Console.WriteLine("Deseas buscar un articulo en el carrito?:(y/n)");
        string d=Console.ReadLine() ?? "";
        while (d != "n")
        {
            
            // Cambiamos la lógica de búsqueda
Console.WriteLine("buscar articulo: ");
string busqueda = Console.ReadLine() ?? "";

// Buscamos el nodo manualmente comparando el nombre
LinkedListNode<Producto> nodoEncontrado = null;
var actual = Carrito.First;

while (actual != null)
{
    if (actual.Value.Nombre.Equals(busqueda, StringComparison.OrdinalIgnoreCase))
    {
        nodoEncontrado = actual;
        break;
    }
    actual = actual.Next;
}

if (nodoEncontrado != null)
{
    Console.WriteLine($"Articulo encontrado: {nodoEncontrado.Value.Nombre} - Precio: {nodoEncontrado.Value.Precio}");
}
else
{
    Console.WriteLine("No se encontró el artículo.");
}
        
        }
        MostrarCarrito(Carrito);

    }
    static void MostrarCarrito(LinkedList<Producto> lista)
    {
        Console.WriteLine("\n--- Resumen de tu compra ---");
        if (lista.Count == 0)
        {
            Console.WriteLine("El carrito está vacío.");
        }
        else
        {
            int i=1;
            foreach (var Producto in lista)
            {
                Console.WriteLine();
                Console.WriteLine($" Articulo {i}: - {Producto.Nombre }");
                Console.WriteLine($" Precio: - {Producto.Precio }");
                Console.WriteLine("");
                i++;
            }
            Console.WriteLine($"Total de artículos: {lista.Count}");
        }
    }
    public class Producto
    {
        public string Nombre{get; set;}
        public double Precio{get;set;}
    }

}
