using csi_23jconazoexamenpr.Servicios;
using System.Runtime.InteropServices.ObjectiveC;

namespace csi_23jconazoexamenpr.Controladores
{
    class Program
    {
        private static int seleccionEmpleado;
        private static int seleccionGerencia;

        static void Main(string[] args)
        {
            MenuInterfaz mi : new MenuImplementacion();
            bool cerrarMenu = false; ;
            while(!cerrarMenu)
            {
                int selecccion = mi.menuPrincipal();
                switch (selecccion)
                {
                    case 0:
                        cerrarMenu = true;
                        break;
                        case 1:
                         object cerrarMenuEmpleado = mi.MenuEmpleado();
                        switch (seleccionEmpleado)
                        {
                            case 0:
                                cerrarMenu = true;
                                break;
                                case 1:
                                break;
                                case 2:
                                break;
                                case 3:
                                break;
                        }
                        break;

                      
                }
                int seleccion = mi.menuGerencia();
                switch (seleccion)
                {
                    case 0:
                        cerrarMenu = true;
                        break;
                    case 1:
                        object cerrarmenuGerencia = mi.menuGerencia();
                        switch (seleccionGerencia)
                        {
                            case 0:
                                cerrarMenu = true;
                                break;
                                case 1:
                                break;
                                case 2:
                                break;
                                case 3:
                                break;

                        }
                } 

            }

        }
    }
}

0