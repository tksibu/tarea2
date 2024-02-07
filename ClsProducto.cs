using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class ClsProducto
    {
        public int codigo;
        public string descripcion;
        public int existencia;
        public int minimo;
        public float precio;
        public static List<ClsProducto> producto = new List<ClsProducto>();

        public ClsProducto(int codigo, string descripcion, int existencia, int minimo, float precio)
        {
            this.codigo = codigo;
            this.descripcion = descripcion;
            this.existencia = existencia;
            this.minimo = minimo;
            this.precio = precio;
        }

        public ClsProducto() { }

        public static void Actualizar() // ACTUALIZA UN PRODUCTO
        {
            int cod = 0;

            Console.WriteLine("Digite el Codigo del Producto");
            cod = Convert.ToInt32(Console.ReadLine());

            bool existe = false;

            for (int i = 0; i < producto.Count; i++)
            {
                if (cod == producto[i].codigo)
                {
                    Console.WriteLine("Digite la Nueva Descripcion");
                    string desc = Console.ReadLine();
                    Console.WriteLine("Digite las Nuevas Existencias");
                    int existen = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite el Nuevo Minimo");
                    int min = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite el Nuevo Precio");
                    float prec = float.Parse(Console.ReadLine());

                    // Actualizar los valores del producto
                    producto[i].descripcion = desc;
                    producto[i].existencia = existen;
                    producto[i].minimo = min;
                    producto[i].precio = prec;

                    existe = true;
                    break;
                }
            }

            if (existe)
            {
                Console.Clear();
                Console.WriteLine("Producto actualizado correctamente.");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("El producto no existe.");
            }

            Console.Read();
        }
        public static void Reporte()// GENERA UN REPORTE
        {
            Console.WriteLine("Reporte de Productos: ");
            foreach (var item in producto)
            {
                Console.Clear();
                Console.WriteLine($"Codigo: {item.codigo} Descripcion: {item.descripcion} Existencias {item.existencia} Minimo {item.minimo} Precio: {item.precio}");
                
            }
        }

        public static void Consulta()// CONSULTA UN PRODUCTO
        {
            int cod = 0;

            Boolean existe = false;

            Console.WriteLine("Digite el Codigo del Producto");
            cod = Convert.ToInt32(Console.ReadLine());

            foreach (var item in producto)
            {
                if (item.codigo.Equals(cod))
                {
                    
                    Console.WriteLine($"Codigo: {item.codigo} Descripcion: {item.descripcion} Existencias {item.existencia} Minimo {item.minimo} Precio: {item.precio}");
                    existe = true;
                    break;
                    
                }
            }
            if (!existe)
            {
                Console.Clear();
                Console.WriteLine("El articulo no existe");
            }
            Console.Read();
            
        }

        public void Agregar()//AGREGA UN PRODUCTO
        {
            Boolean fin = true;
            do
            {
                Console.WriteLine("Digite el Codigo");
                int cod = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite la Descripcion");
                String desc = Console.ReadLine();
                Console.WriteLine("Digite las existencias");
                int existen = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite el minimo");
                int min = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite el precio");
                float prec = float.Parse(Console.ReadLine());
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Producto Ingresado!");
                Console.ReadKey();
                Console.ForegroundColor= ConsoleColor.White;
                Console.Write("Desea ingresar otro producto:");
                String n = Console.ReadLine();

               
                producto.Add(new ClsProducto(cod, desc, existen, min, prec));
                if (n.Equals("n")) fin = false;

            } while (fin);


            Console.WriteLine("Elementos de la Lista: ");
            foreach (var item in producto)
            {
                Console.WriteLine($"Codigo: {item.codigo} Descripcion: {item.descripcion} Existencias {item.existencia} Minimo {item.minimo} Precio: {item.precio}");
            }
            Console.ReadLine(); 
        }
    
        public static void Eliminar() //ELIMINA ARTICULOS
        {

            int cod = 0;
            Boolean existe = false;
            Console.WriteLine("Digite el Codigo del Producto");
            cod = Convert.ToInt32(Console.ReadLine());

            foreach (var item in producto)
            {
                if (item.codigo.Equals(cod))
                {

                    Console.WriteLine($"Datos a Eliminar Codigo: {item.codigo} Descripcion: {item.descripcion} Existencias {item.existencia} Minimo {item.minimo} Precio: {item.precio}");

                    existe = true;
                    break;

                }
            }
            if (!existe)
            {
                Console.Clear();
                Console.WriteLine("El articulo no existe");
            }
            Console.Read();
        }
        public static void Venta(int codigo, int cantidad) //VENTA DE UN PRODUCTO
        {
            int cod = 0;
            int cant =0;
            Boolean existe = false;
            Console.WriteLine("Digite el Codigo del Producto a vender");
            cod = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite la cantidad del Producto a vender");
            cant = Convert.ToInt32(Console.ReadLine());
            ClsProducto productoAVender = producto.Find(item => item.codigo == cod);

            if (productoAVender != null)
            {
                if (productoAVender.existencia >= cantidad)
                {
                    Console.WriteLine($"Venta realizada correctamente. Existencia actualizada: {productoAVender.existencia}");

                }
                else
                {
                    Console.WriteLine("No hay suficiente existencia para realizar la venta.");
                }
            }
            else
            {
                Console.WriteLine("No se encontró un producto con ese código.");
            }
        }
    }
}
