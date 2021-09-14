using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02EntityFrameworkDatabaseFirst
{
    class RegionConsola
    {
        RegionDataAccess dataAccess = new RegionDataAccess();

        public void MostrarRegiones()
        {
            List<Region> regiones = dataAccess.ObtenerTodasLasRegiones();
            Console.WriteLine();
            foreach (var region in regiones)
            {
                Console.WriteLine($"{region.RegionID}-{region.RegionDescription}");
            }
            Console.WriteLine();

            Console.WriteLine("Indique la opción deseada:");
            Console.WriteLine("1-Crear nueva Región");
            Console.WriteLine("2-Actualizar una Región");
            Console.WriteLine("3-Borrar una Región");
            Console.WriteLine("4-Mostrar los territorios de una Región");
            Console.WriteLine();
            Console.Write("Ingrese la opción seleccionada: ");
            string opcion = Console.ReadLine();
            switch (opcion.ToUpper().Trim())
            {
                case "1":
                    CrearNuevaRegion();
                    break;
                case "2":
                    ActualizarRegion();
                    break;
                case "3":
                    BorrarRegion();
                    break;
                case "4":
                    ListarTerritorios();
                    break;
            }

        }

        private void ListarTerritorios()
        {
            Console.WriteLine();
            Console.WriteLine("Ingrese el identificador de la región: ");
            string idIngresado = Console.ReadLine();
            int id = Convert.ToInt32(idIngresado);
            Region region = dataAccess.ObtenerRegion(id);
            if (region == null)
            {
                Console.WriteLine("No ingresó el ID de una región existente");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"Territorios de {region.RegionID}-{region.RegionDescription}");
                List<Territory> territorios = region.Territories.ToList();
                foreach (var territorio in territorios)
                {
                    Console.WriteLine($"Territorio: {territorio.TerritoryID}-{territorio.TerritoryDescription}");
                }
            }

        }

        private void BorrarRegion()
        {
            Console.WriteLine();
            Console.WriteLine("Ingrese el identificador de la región que desea borrar: ");
            string idIngresado = Console.ReadLine();
            int id = Convert.ToInt32(idIngresado);
            Region regionAActualizar = dataAccess.ObtenerRegion(id);
            if (regionAActualizar == null)
            {
                Console.WriteLine("No ingresó el ID de una región existente");
            }
            else
            {
                dataAccess.BorrarRegion(id);
            }

        }

        private void ActualizarRegion()
        {
            Console.WriteLine();
            Console.WriteLine("Ingrese el identificador de la región que desea actualizar: ");
            string idIngresado = Console.ReadLine();
            int id = Convert.ToInt32(idIngresado);
            Region regionAActualizar = dataAccess.ObtenerRegion(id);
            if (regionAActualizar == null)
            {
                Console.WriteLine("No ingresó el ID de una región existente");
            }
            else
            {
                Console.WriteLine($"La región a actualizar es: {regionAActualizar.RegionID}-{regionAActualizar.RegionDescription}");
                Console.WriteLine();
                Console.WriteLine("Ingrese el nuevo nombre de la región: ");
                string nombre = Console.ReadLine();
                dataAccess.ActualizarRegion(id, nombre);

            }


        }

        private void CrearNuevaRegion()
        {
            Console.WriteLine();
            Console.WriteLine("Ingrese el nombre de la nueva región: ");
            string nombre = Console.ReadLine();
            dataAccess.CrearNuevaRegion(nombre.Trim());
        }
    }
}
