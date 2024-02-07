// See https://aka.ms/new-console-template for more information
using System.Buffers;
namespace ejercicio1
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            //ClsProducto Articulo = new ClsProducto(1,"Mesa de Oficina",25,5,5000);
            //Console.WriteLine(Articulo.codigo+" "+Articulo.descripcion+" "+Articulo.existencia+" "+Articulo.minimo+" "+Articulo.precio);
            ClsMenu.menu();
            Console.Read();
        
        }
    }



}