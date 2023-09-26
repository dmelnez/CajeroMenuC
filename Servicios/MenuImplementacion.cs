using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroMenuC.Servicios
{

    /// <summary>
    /// Clase que Implementa la interfaz del Menu
    /// 25/09/2023 - DMN
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz /*Conectar la interfaz a la Implemtacion*/
    {
        public void monstrarMensajeBienvenida() 
        {
            string mensaje = "Banco CSI1";
            Console.WriteLine(mensaje);

        }
        public int mostrarMenuYSeleccion()
        {

            int opcionIntroducida;
            Console.WriteLine("#############################");
            Console.WriteLine("0. Cerrar Aplicacion");
            Console.WriteLine("1. Darse de alta");
            Console.WriteLine("2. Ingresar Dinero");
            Console.WriteLine("3. Sacar Dinero");
            Console.WriteLine("4. Transferir Dinero");
            Console.WriteLine("5. Historial de Operaciones");
            Console.WriteLine("#############################");
            Console.WriteLine("Seleccione una Nueva Opcion: ");

            opcionIntroducida = Console.ReadKey(true).KeyChar - ('0'); /*ReadKey: Solamente lee un caracter | El true, hace que no muestre el resultado en pantalla*/
            return opcionIntroducida;



        }

    }
}
