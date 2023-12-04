using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmelnez.Servicios
{
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Metodo encargado de mostrar al usuario el menu principal.
        /// Reogera el valor introducido por el usuario, y lo devolvera al metodo main.
        /// DMN - 04/12/2023
        /// </summary>
        /// <returns>int seleccionMenu</returns>
        public int menuPrincipal();


        /// <summary>
        /// Metodo encargado de solicitar al usuario el ID del objeto y almacenarlo en long
        /// DMN - 04/12/2023
        /// </summary>
        /// <returns>string CodigoElementoDado</returns>
        public string pedirIdObjeto();

    }
}
