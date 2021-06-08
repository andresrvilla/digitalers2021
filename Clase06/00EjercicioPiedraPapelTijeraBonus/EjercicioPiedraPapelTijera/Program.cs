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
            const string OPCIONMENU_SALIR = "3";
            const string OPCIONMENU_JUGAR_DOS = "1";
            const string OPCIONMENU_JUGAR_SOLO = "2";
            

            //Uso un do-while porque tengo que mostrar el menu al menos una vez
            do
            {
                // Muestro el menu para que pueda elegir si juega o sale
                Console.Clear();
                Console.WriteLine("********************************");
                Console.WriteLine("*** PIEDRA PAPEL O TIJERA IT ***");
                Console.WriteLine("********************************");
                Console.WriteLine("Ingrese la opción deseada:");
                Console.WriteLine("1. Nueva Partida dos jugadores");
                Console.WriteLine("2. Nueva Partida un jugador");
                Console.WriteLine("3. Salir");
                opcionMenu = Console.ReadLine();

                // Si no eligio salir, va a jugar. Si cualquier otra cosa, no juega y vuelve al menu
                // Recordemos que la idea es ver logica simple, no complicarla. Aunque cada uno puede avanzar
                // en la medida que se sienta comodo
                if (opcionMenu == OPCIONMENU_JUGAR_DOS || opcionMenu== OPCIONMENU_JUGAR_SOLO)
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

                    // Este codigo oculta la entrada de texto. ¿Como lo hice? Busque en internet y terminé aca:
                    // https://social.msdn.microsoft.com/Forums/vstudio/en-US/6f8a90d9-be27-49de-84cb-b960985a0ef9/console-how-to-hide-received-input
                    // Algo importante en "aprender a programar" es aprender a encontrar soluciones.
                    // Se puede mejorar? Seguramente...

                    string opcionJugadorUno = "";
                    Boolean ingresar = true;
                    while (ingresar)
                    {
                        char s = Console.ReadKey(true).KeyChar;
                        if (s == '\r')
                        {
                            ingresar = false;
                        }
                        else
                        {
                            opcionJugadorUno += s.ToString();
                        }
                    }



                    string opcionJugadorDos = "";
                    if (opcionMenu == OPCIONMENU_JUGAR_DOS)
                    {

                        Console.Clear();
                        Console.WriteLine("********************************");
                        Console.WriteLine("*** PIEDRA PAPEL O TIJERA IT ***");
                        Console.WriteLine("********************************");
                        Console.WriteLine("JUGADOR DOS Ingrese la opción deseada:");
                        Console.WriteLine("1. Piedra");
                        Console.WriteLine("2. Papel");
                        Console.WriteLine("3. Tijera");


                        ingresar = true;
                        while (ingresar)
                        {
                            char s = Console.ReadKey(true).KeyChar;
                            if (s == '\r')
                            {
                                ingresar = false;
                            }
                            else
                            {
                                opcionJugadorDos += s.ToString();
                            }
                        }
                    }
                    else
                    {
                        // Si no juega de a dos, genero el numero aleatoriamente
                        Random random = new Random();
                        int opcionSeleccionadaAleatoriamente = random.Next(1, 3);
                        opcionJugadorDos = "" + opcionSeleccionadaAleatoriamente; //Necesito concatenarle vacio para poder convertir a string el numero
                    }

                    
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

                    switch (opcionJugadorUno)
                    {
                        case OPCION_PIEDRA:
                            Console.WriteLine("El jugador uno eligio Piedra");
                            break;
                        case OPCION_PAPEL:
                            Console.WriteLine("El jugador uno eligio Papel");
                            break;
                        case OPCION_TIJERA:
                            Console.WriteLine("El jugador uno eligio Tijera");
                            break;
                    }

                    string jugador = "robotito";
                    if(opcionMenu == OPCIONMENU_JUGAR_DOS)
                    {
                        jugador = "jugador dos";
                    }
                    switch (opcionJugadorDos)
                    {
                        case OPCION_PIEDRA:
                            Console.WriteLine("El "+jugador+" eligio Piedra");
                            break;
                        case OPCION_PAPEL:
                            Console.WriteLine("El " + jugador + " eligio Papel");
                            break;
                        case OPCION_TIJERA:
                            Console.WriteLine("El " + jugador + " eligio Tijera");
                            break;
                    }

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
