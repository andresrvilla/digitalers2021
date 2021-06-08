using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPiedraPapelTijera
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcionMenu = ""; // Inicio la opción de menu fuera de do-while porque lo voy a usar para controlar la condición
            
            //Voy a usar constantes para que quede mas claro en el codigo que significan los numeros que el jugador elije
            const string OPCIONMENU_SALIR = "2";
            const string OPCIONMENU_JUGAR = "1";

            //Uso un do-while porque tengo que mostrar el menu al menos una vez
            do
            {
                // Muestro el menu para que pueda elegir si juega o sale
                Console.Clear();
                Console.WriteLine("********************************");
                Console.WriteLine("*** PIEDRA PAPEL O TIJERA IT ***");
                Console.WriteLine("********************************");
                Console.WriteLine("Ingrese la opción deseada:");
                Console.WriteLine("1. Nueva Partida");
                Console.WriteLine("2. Salir");
                opcionMenu = Console.ReadLine();

                // Si no eligio salir, va a jugar. Si cualquier otra cosa, no juega y vuelve al menu
                // Recordemos que la idea es ver logica simple, no complicarla. Aunque cada uno puede avanzar
                // en la medida que se sienta comodo
                if (opcionMenu == OPCIONMENU_JUGAR)
                {
                    const string OPCION_PIEDRA = "1";
                    const string OPCION_PAPEL = "2";
                    const string OPCION_TIJERA = "3";

                    //Pido los datos del jugador uno
                    Console.Clear();
                    Console.WriteLine("********************************");
                    Console.WriteLine("*** PIEDRA PAPEL O TIJERA IT ***");
                    Console.WriteLine("********************************");
                    Console.WriteLine("JUGADOR UNO Ingrese la opción deseada:");
                    Console.WriteLine("1. Piedra");
                    Console.WriteLine("2. Papel");
                    Console.WriteLine("3. Tijera");
                    string opcionJugadorUno = Console.ReadLine();

                    Console.Clear();
                    Console.WriteLine("********************************");
                    Console.WriteLine("*** PIEDRA PAPEL O TIJERA IT ***");
                    Console.WriteLine("********************************");
                    Console.WriteLine("JUGADOR DOS Ingrese la opción deseada:");
                    Console.WriteLine("1. Piedra");
                    Console.WriteLine("2. Papel");
                    Console.WriteLine("3. Tijera");
                    string opcionJugadorDos = Console.ReadLine();
                    
                    //Uso estas constantes para poder comparar despues si hubo empate, si gano, y para que quede mas limpio el codigo
                    const string EMPATE = "EMPATE";
                    const string JUGADOR_UNO = "UNO";
                    const string JUGADOR_DOS = "DOS";

                    string jugadorGanador = EMPATE; //Por defecto es Empate. Asi que cuando eligen la misma opcion no tengo que hacer nada

                    /*
                     * Aca voy a usar switch pero tranquilamente podría usar if en el caso interno
                     * porque son solo dos opciones.
                     * Uso if con el fin de que quede en el ejemplo esta estructura, aunque recordemos
                     * que es optimo cuando hay mas de dos casos.
                     */
                    switch (opcionJugadorUno) {
                        case OPCION_PIEDRA:
                            switch (opcionJugadorDos)
                            {
                                case OPCION_PAPEL:
                                    jugadorGanador = JUGADOR_DOS;
                                    break;
                                case OPCION_TIJERA:
                                    jugadorGanador = JUGADOR_UNO;
                                    break;
                            }
                            break;
                        case OPCION_PAPEL:
                            switch (opcionJugadorDos)
                            {
                                case OPCION_PIEDRA:
                                    jugadorGanador = JUGADOR_UNO;
                                    break;
                                case OPCION_TIJERA:
                                    jugadorGanador = JUGADOR_DOS;
                                    break;
                            }
                            break;
                        case OPCION_TIJERA:
                            switch (opcionJugadorDos)
                            {
                                case OPCION_PIEDRA:
                                    jugadorGanador = JUGADOR_DOS;
                                    break;
                                case OPCION_PAPEL:
                                    jugadorGanador = JUGADOR_UNO;
                                    break;
                            }
                            break;
                    }

                    //Aviso como resulto la partida

                    Console.Clear();
                    Console.WriteLine("********************************");
                    Console.WriteLine("*** PIEDRA PAPEL O TIJERA IT ***");
                    Console.WriteLine("********************************");
                    if (jugadorGanador == EMPATE)
                    {
                        Console.WriteLine("EMPATARON LA PARTIDA");
                    }
                    else
                    {
                        Console.WriteLine("EL JUGADOR " + jugadorGanador + " HA GANADO LA PARTIDA");
                    }

                    Console.WriteLine("Presione una tecla para continuar");
                    Console.ReadKey();
                } //FIN DEL ELSE CUANDO NO QUIERE SALIR (ES DECIR, CUANDO JUEGA)

                // Despues de que jugo no muestro nada, porque la logica de "Jugar" o "Salir" esta al principio

            } while (opcionMenu != OPCIONMENU_SALIR);


            Console.WriteLine("********************************");
            Console.WriteLine("*** PIEDRA PAPEL O TIJERA IT ***");
            Console.WriteLine("********************************");
            Console.WriteLine("Gracias por haber Jugado!!!");
        }
    }
}
