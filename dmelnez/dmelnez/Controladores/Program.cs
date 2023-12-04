using dmelnez.Dtos;
using dmelnez.Servicios;

namespace dmelnez;


/// <summary>
/// Clase principal por la cual se lanza la aplicacion
/// DMN - 04/12/2023
/// </summary>
class Program
{

    /// <summary>
    /// Metodo principal, por el cual se inicializa la aplicacion
    /// DMN - 04/12/2023
    /// </summary>

    static void Main(string[] args)
    {

        List<Objetos>listaElementos = new List<Objetos>();


        MenuInterfaz menu = new MenuImplementacion();
       
        OperativaElementosInterfaz elementos = new OperativaElementosImplementacion();

        bool cerraMenu = false;

        while(!cerraMenu)
        {
            int seleccionMenu = menu.menuPrincipal();
            switch (seleccionMenu)
            {


                case 0:
                    Console.WriteLine("########################################");
                    Console.WriteLine("[INFO] - Se cerrara el Menu");
                    Console.WriteLine("########################################");
                    cerraMenu = true;
                break;

                case 1:
                    Console.WriteLine("########################################");
                    Console.WriteLine("[INFO] - Añadir un nuevo Elemento");
                    Console.WriteLine("########################################");
                    elementos.darAltaElementos(listaElementos);
                    break;
                 

                case 2:
                    Console.WriteLine("########################################");
                    Console.WriteLine("[INFO] - Modificar cantidad de Elemento");
                    Console.WriteLine("########################################");
                    elementos.eliminarStock(listaElementos);
                    break;

                default: 
                    Console.WriteLine("Seleccion no valida");
                    break;



            }




        }


    }



}




