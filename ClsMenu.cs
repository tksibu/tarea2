using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    internal class ClsMenu
    {
        public static int opcion;
        
        public static void menu()
        {
            ClsProducto articulo = new ClsProducto();

            try
            {
                do
                {
                    Console.WriteLine("1-Agregar Producto");
                    Console.WriteLine("2-Venta de un Producto");
                    Console.WriteLine("3-Actualizar un Producto");
                    Console.WriteLine("4-Consulta");
                    Console.WriteLine("5-Borrar Producto");
                    Console.WriteLine("6-Reporte");
                    Console.WriteLine("7-Salir");
                    Console.WriteLine("Digite una Opción...");
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1: articulo.Agregar(); break;
                        case 2: Console.WriteLine("Opción 2"); break;
                        case 3: ClsProducto.Actualizar(); break;
                        case 4: ClsProducto.Consulta(); break;
                        case 5: ClsProducto.Eliminar(); break;
                        case 6: ClsProducto.Reporte(); break;
                        default:Console.WriteLine("Opción Incorrecta");break;
                    }
                } while (opcion != 7); //VARIABLE DE CONTROL
            }
            catch (Exception ex)
            {
                Console.WriteLine("Se ingresó un valor incorrecto. Vuelva a intentar... " + ex.Message);
            }
        }

    }
    }
}
