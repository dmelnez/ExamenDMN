using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmelnez.Dtos
{
    /// <summary>
    /// Clase encargada de la definicion de los campos que construiran a un elemento
    /// DMN - 04/12/2023
    /// </summary>
    internal class Objetos
    {
        long idElemento = 0;

        string codigoElemento = "aaaaa";

        string nombreElemento = "aaaaa";

        string descripcionElemento = "aaaaa";

        int cantidadElemento = 0;


        public long IdElemento { get => idElemento; set => idElemento = value; }
        public string CodigoElemento { get => codigoElemento; set => codigoElemento = value; }
        public string NombreElemento { get => nombreElemento; set => nombreElemento = value; }
        public string DescripcionElemento { get => descripcionElemento; set => descripcionElemento = value; }
        public int CantidadElemento { get => cantidadElemento; set => cantidadElemento = value; }


        public Objetos(long idElemento, string codigoElemento, string nombreElemento, string descripcionElemento, int cantidadElemento)
        {
            this.idElemento = idElemento;
            this.codigoElemento = codigoElemento;
            this.nombreElemento = nombreElemento;
            this.descripcionElemento = descripcionElemento;
            this.cantidadElemento = cantidadElemento;
        }



        public Objetos () { }


        override 

        public string ToString()
        {

            string datosObjetos =

              this.cantidadElemento + "" + this.nombreElemento;


             

            return datosObjetos;


        }


    }
}
