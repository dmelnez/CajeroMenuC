using CajeroMenuC.Servicios;

namespace CajeroMenuC.Controladores

{
    
        /// <summary>
        /// Clase Principal de la Aplicacion
        /// 25/09/2023 - DMN
        /// </summary>
    class Program

    {

        /// <summary>
        /// Metodo de entrada de la Aplicacion
        /// 25/09/2023 - DMN
        /// </summary>
        /// <param name="args"></param>
        

        static void Main(String[]args)
        {

            MenuInterfaz menuInterfaz = new MenuImplementacion(); /*Creacion de un nuevo Objeto llamado "MenuImplementacion"*/
            menuInterfaz.monstrarMensajeBienvenida();
            bool cerrarMenu = false; /*Variable que controla la entrada y salida del menu*/
            int opcionSeleccionada; /*Contiene el valor que introduce el usuario*/


            //Desde la Primera iteracon o entrada, debe decumplirse la condicion
            while (!cerrarMenu) /*Bucle del menu, se inicia con valor contrario al preestablecido. En este caso es positivo*/
            {
           
                opcionSeleccionada = menuInterfaz.mostrarMenuYSeleccion();
                Console.WriteLine(opcionSeleccionada);

                switch (opcionSeleccionada)  /*Switch: Compara con el int*/
                {
                    

                    case 0:
                        Console.WriteLine("[INFO - Se Ejecuta caso 0]");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("[INFO - Se Ejecuta caso 1]");
                        break;
                    case 2:
                        Console.WriteLine("[INFO - Se Ejecuta caso 2]");
                        break;
                    case 3:
                        Console.WriteLine("[INFO - Se Ejecuta caso 3]");
                        break;
                    case 4:
                        Console.WriteLine("[INFO - Se Ejecuta caso 4]");
                        break;
                    case 5:
                        Console.WriteLine("[INFO - Se Ejecuta caso 5]");
                        break;
                    default: /*Default: Es lo que se lanza cuando el valor introducido no coincide con ningun valor*/
                        Console.WriteLine("[INFO] - El valor Seleccionado no coincide con ninguna Opcion.");
                        break;
                }

            }


        }

    }
}