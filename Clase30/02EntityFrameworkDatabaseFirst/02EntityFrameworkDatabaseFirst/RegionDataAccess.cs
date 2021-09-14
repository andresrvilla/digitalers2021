using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02EntityFrameworkDatabaseFirst
{
    class RegionDataAccess
    {
        NorthwindEntities entidades = new NorthwindEntities();

        public List<Region> ObtenerTodasLasRegiones()
        {
            //var query = from e in entidades.Regions
            //            select e;

            var query = entidades.Regions;

            return query.ToList();
        }

        internal void CrearNuevaRegion(string descripcion)
        {
            int id = IdMaximo();
            id++;
            Region region = new Region()
            {
                RegionID = id,
                RegionDescription = descripcion
            };

            entidades.Regions.Add(region);
            entidades.SaveChanges();
        }

        private int IdMaximo()
        {
            int id = entidades.Regions.Max(r => r.RegionID);
            return id;
        }

        internal Region ObtenerRegion(int id)
        {
            /*var query = from r in entidades.Regions
                        where r.RegionID == id
                        select r;*/
            var query = entidades.Regions.Where(r => r.RegionID == id);

            return query.FirstOrDefault();
        }

        internal void ActualizarRegion(int id, string nombre)
        {
            Region region = ObtenerRegion(id);
            if (region != null)
            {
                region.RegionDescription = nombre;
                entidades.SaveChanges();
            }
            
        }

        internal void BorrarRegion(int id)
        {
            Region region = ObtenerRegion(id);
            if (region != null)
            {
                entidades.Regions.Remove(region);
                entidades.SaveChanges();
            }
            
        }
    }
}
