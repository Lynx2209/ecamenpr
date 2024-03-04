using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csi_23jconazoexamenpr.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int menuPrincipal()
        {
            Console.WriteLine("A que menú deseea acceder");
            Console.WriteLine("Cerrar Menu");
            Console.WriteLine("Menu empleado");
            Console.WriteLine("Menu gerencia");

        }

        public static int MenuEmpleado()
        {
            Console.WriteLine("Que desea hacer ?");
            Console.WriteLine("Calculo total de ventas diario");
            Console.WriteLine("Mostrar ventas del dia");
            Console.WriteLine(" Cerrar menu");
           
        }

        public static int menuGerencia()
        {
            Console.WriteLine("Añadir venta");
            Console.WriteLine("Crear pedido para proveedores");
            Console.WriteLine("Cerrar Menu");
          
        }
    }

}
