using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroMenuC.Servicios
{

    /// <summary>
    /// Interfaz con la relacion de metodos de la funcionalidad del menu
    /// 25/09/2023 - DMN
    /// </summary>
    internal interface MenuInterfaz
    {

        /// <summary>
        /// Metodo que muestra mensaje de Bienvenida al Cajero
        /// 25/09/2023 - DMN
        /// </summary>

        void monstrarMensajeBienvenida();

        /// <summary>
        /// Metodo que Muestra el Menu y Recoge el valor introducido por el usuario
        /// 25/09/2023
        /// </summary>
        /// <returns>Entero con la Opcion Seleecionada</returns>


        public int mostrarMenuYSeleccion();




    }
}
