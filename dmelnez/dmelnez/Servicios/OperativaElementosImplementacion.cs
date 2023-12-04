using dmelnez.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dmelnez.Servicios
{
    internal class OperativaElementosImplementacion : OperativaElementosInterfaz
    {

        public void darAltaElementos(List<Objetos> listaAntigua)
        {

           
            Objetos nuevoElemento = new Objetos();


            Console.WriteLine("AÑADIR UN NUEVO OBJETO");

            Console.WriteLine("ID Elemento: ");
            long idElemento = Convert.ToInt64(Console.ReadLine());
            nuevoElemento.IdElemento = idElemento;

            Console.WriteLine("Nombre: ");
            string nombreElemento = Console.ReadLine();
            nuevoElemento.NombreElemento = nombreElemento;


            Console.WriteLine("Descripcion: ");
            nuevoElemento.DescripcionElemento = Console.ReadLine();

            Console.WriteLine("Cantidad: ");
            nuevoElemento.CantidadElemento = Convert.ToInt32(Console.ReadLine());


           
            nuevoElemento.CodigoElemento = idElemento + nombreElemento;


            listaAntigua.Add(nuevoElemento);


            foreach (Objetos objetos in listaAntigua)
            {
                Console.WriteLine(objetos.ToString());
            }



        }


        public void eliminarStock(List<Objetos> listaAntigua)
        {



            MenuInterfaz menu = new MenuImplementacion();


           string CodigoElementoDado = menu.pedirIdObjeto();

           Objetos ElementoABucar = new Objetos();

            foreach (Objetos objetos in listaAntigua)
            {

                if (objetos.CodigoElemento.Equals(CodigoElementoDado))
                {

                    Console.WriteLine("Cantidad a Modificar: ");


                    int valorStock = objetos.CantidadElemento;
                   
                    int valorModificar = Convert.ToInt32(Console.ReadLine());

                    int valorModificado = valorStock - valorModificar;
                    

                    objetos.CantidadElemento = valorModificado;
                    
                    ElementoABucar = objetos;

                  

                }



            }

            foreach (Objetos objetos in listaAntigua)
            {
                Console.WriteLine(objetos.ToString());
            }
            


        }







    }
}
