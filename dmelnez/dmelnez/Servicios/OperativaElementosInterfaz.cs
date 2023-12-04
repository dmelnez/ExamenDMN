using dmelnez.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmelnez.Servicios
{
    internal interface OperativaElementosInterfaz
    {
        /// <summary>
        /// Metodo encargado de ir solicitando al usuario todos los atributos, 
        /// y añadirlos en la lista de objetos
        /// DMN - 04/12/2023
        /// <param>listaAntigua</param>
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void darAltaElementos(List<Objetos> listaAntigua);

        /// <summary>
        /// Metodo encargado de la eliminacion de stock.
        /// Solicitara al usuario, el id del elemento a identificar. Y modificara el stock existente
        /// DMN - 04/12/2023
        /// <param>listaAntigua</param>
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void eliminarStock(List<Objetos> listaAntigua);

    }
}
