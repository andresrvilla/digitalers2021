using System;

namespace EjercicioTaTeTi
{
    class Program
    {
        private const string OPCION_ELEGIDA_JUGADOR_UNO = "X";
        private const string SIN_SELECCION = "-";

        static void Main(string[] args)
        {
            string[] opciones = new string[]
            {
                "Nuevo Juego",
                "Salir del Juego"
            };


            int seleccionado = 0;
            do
            {
                encabezado();
                seleccionado = menu(opciones);
                switch (seleccionado)
                {
                    case 1:
                        juegoUnaPersona();
                        break;
                    case 2:
                        Console.WriteLine("Pulse cualquier tecla para terminar...");
                        Console.ReadKey();
                        break;
                }
            } while (seleccionado != 2);
        }

        static void juegoUnaPersona()
        {
            string[,] tablero = new string[,]
            {
                {SIN_SELECCION,SIN_SELECCION,SIN_SELECCION },
                {SIN_SELECCION,SIN_SELECCION,SIN_SELECCION },
                {SIN_SELECCION,SIN_SELECCION,SIN_SELECCION }
            };
            int jugadorActual = 1;

            int jugadorGanador = 0;
            bool tableroLleno = false;
            while (jugadorGanador == 0 && tableroLleno == false)
            {
                encabezado();
                dibujarTablero(tablero);
                jugar(ref tablero, jugadorActual);
                jugadorGanador = analizarJugadorGanador(tablero);
                tableroLleno = verificarTableroLleno(tablero);
                //Cambio el jugador actual para que la siguiente vuelta del while juegue ese
                if (jugadorActual == 1)
                {
                    jugadorActual = 2;
                }
                else
                {
                    jugadorActual = 1;
                }
            }

            encabezado();
            switch (jugadorGanador)
            {
                case 0:
                    Console.WriteLine(" EL JUEGO HA RESULTADO EN UN EMPATE");
                    break;
                case 1:
                case 2:
                    Console.WriteLine(" HA GANADO EL JUGADOR " + jugadorGanador + ". FELICIDADES!!!");
                    break;
            }
            Console.WriteLine("**********************************************");
            Console.WriteLine("Pulse una tecla para continuar");
            Console.ReadKey();
        }

        static bool verificarTableroLleno(string[,] tablero)
        {
            bool estaLleno = true;
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    if (tablero[i, j] == SIN_SELECCION)
                    {
                        estaLleno = false;
                    }
                }
            }
            return estaLleno;
        }

        static int analizarJugadorGanador(string[,] tablero)
        {
            int ganador = 0;
            ganador = verificarGanadorFilas(tablero);
            if (ganador == 0)
            {
                ganador = verificarGanadorColumnas(tablero);
            }
            if (ganador == 0)
            {
                ganador = verificarGanadorDiagonales(tablero);
            }
            return ganador;
        }

        static int verificarGanadorDiagonales(string[,] tablero)
        {
            int ganador = 0;


            if (
                //Chequeo primer diagonal
                (tablero[0, 0] != SIN_SELECCION && tablero[0, 0] == tablero[1, 1] && tablero[1, 1] == tablero[2, 2])
                ||
                //Chequeo segunda diagonal
                (tablero[0, 2] != SIN_SELECCION && tablero[0, 2] == tablero[1, 1] && tablero[1, 1] == tablero[2, 0])
                )
            {
                // En ambos casos coinciden que la opcion del ganador es la del medio, asi que simplifico chequeando esa
                if (tablero[1, 1] == OPCION_ELEGIDA_JUGADOR_UNO)
                {
                    ganador = 1;
                }
                else
                {
                    ganador = 2;
                }
            }

            return ganador;
        }

        static int verificarGanadorColumnas(string[,] tablero)
        {
            int ganador = 0;
            for (int i = 0; i < tablero.GetLength(1); i++)
            {
                if (tablero[0, i] != SIN_SELECCION && tablero[0, i] == tablero[1, i] && tablero[1, i] == tablero[2, i]) //Hay ganador
                {
                    if (tablero[0, i] == OPCION_ELEGIDA_JUGADOR_UNO)
                    {
                        ganador = 1;
                    }
                    else
                    {
                        ganador = 2;
                    }
                }
            }
            return ganador;
        }

        static int verificarGanadorFilas(string[,] tablero)
        {
            int ganador = 0;
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                if (tablero[i, 0] != SIN_SELECCION && tablero[i, 0] == tablero[i, 1] && tablero[i, 1] == tablero[i, 2]) //Hay ganador
                {
                    if (tablero[i, 0] == OPCION_ELEGIDA_JUGADOR_UNO)
                    {
                        ganador = 1;
                    }
                    else
                    {
                        ganador = 2;
                    }
                }
            }
            return ganador;
        }

        static void jugar(ref string[,] tablero, int jugadorActual)
        {
            Console.WriteLine("Jugador " + jugadorActual + ". Por favor ingrese su jugada:");
            int opcionFila = 0;
            int opcionColumna = 0;

            do
            {
                //Si vuelve con la opcion de la fila y columna distintas de cero, es que eligio una opcion que ya antes se habia elegido
                if (opcionFila > 0 || opcionColumna > 0)
                {
                    Console.WriteLine("**********************************************");
                    Console.WriteLine("Ha seleccionado una opción previamente elegida");
                    Console.WriteLine("**********************************************");
                    opcionFila = 0;
                    opcionColumna = 0;
                }

                string[] opcionesFila = new string[]
                {
                    "Seleccionar la fila 1",
                    "Seleccionar la fila 2",
                    "Seleccionar la fila 3"
                };
                opcionFila = menu(opcionesFila);

                string[] opcionesColumna = new string[]
                {
                    "Seleccionar la columna 1",
                    "Seleccionar la columna 2",
                    "Seleccionar la columna 3"
                };
                opcionColumna = menu(opcionesColumna);

                //Solo voy a chequear que la opcion elegida sea valida, porque el menu ya chequea que este dentro de las opciones
            } while (tablero[opcionFila - 1, opcionColumna - 1] != SIN_SELECCION);

            if (jugadorActual == 1)
            {
                tablero[opcionFila - 1, opcionColumna - 1] = OPCION_ELEGIDA_JUGADOR_UNO;
            }
            else
            {
                tablero[opcionFila - 1, opcionColumna - 1] = "O";
            }
        }

        static void dibujarTablero(string[,] tablero)
        {
            Console.WriteLine("╔═══╦═══╦═══╗");
            for (int i = 0; i < tablero.GetLength(0); i++)
            {
                for (int j = 0; j < tablero.GetLength(1); j++)
                {
                    Console.Write("║ " + tablero[i, j] + " ");
                }
                Console.WriteLine("║");
                if (i < tablero.GetLength(0) - 1)
                {
                    Console.WriteLine("╠═══╬═══╬═══╣");
                }
            }
            Console.WriteLine("╚═══╩═══╩═══╝");
        }

        static int menu(string[] opciones)
        {
            for (int i = 0; i < opciones.Length; i++)
            {
                Console.WriteLine((i + 1) + " - " + opciones[i]);
            }

            int resultado;
            do
            {
                Console.WriteLine();
                Console.Write("Por favor seleccione una opción válida: ");
                string dato = Console.ReadLine();
                resultado = Convert.ToInt32(dato);
            } while (resultado <= 0 || resultado > opciones.Length);

            return resultado;
        }

        static void encabezado()
        {
            Console.Clear();
            Console.WriteLine("******************************************");
            Console.WriteLine("******************************************");
            Console.WriteLine("*****          TA - TE - TI          *****");
            Console.WriteLine("******************************************");
            Console.WriteLine("******************************************");
        }
    }
}
