using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmelnez.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {

        public int menuPrincipal()
        {
            Console.WriteLine("#######################################");
            Console.WriteLine("######## Seleccione una opcion ########");
            Console.WriteLine("#######################################");
            Console.WriteLine("# 0 -> Cerrar la Aplicacion           #");
            Console.WriteLine("# 1 -> Añadir un nuevo Elemento       #");
            Console.WriteLine("# 2 -> Modificar stock de Elemento    #");
            Console.WriteLine("#######################################");
          

            int seleccionMenu = Convert.ToInt32(Console.ReadLine());
            return seleccionMenu;

        }


        public string pedirIdObjeto()
        {
            Console.WriteLine("Codigo del Elemento a Modificar");
            string CodigoElementoDado = Console.ReadLine();
            return CodigoElementoDado;

        }

    }
}
