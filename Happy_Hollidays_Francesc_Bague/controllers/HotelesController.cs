using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Happy_Hollidays_Francesc_Bague.models;

namespace Happy_Hollidays_Francesc_Bague.controllers
{
    class HotelesController
    {
        public static List<hoteles> Select(ciudades c)
        {
            return Orm.bd.hoteles
                .Where(h => h.ciudades.id_ciudad == c.id_ciudad)
                .OrderBy(h => h.nombre)
                .ToList();
        }
        public static List<hoteles> Select(int _id_ciudad)
        {
            return Orm.bd.hoteles
                .Where(h => h.id_ciudad == _id_ciudad)
                .OrderBy(h => h.nombre)
                .ToList();
        }
        public static String Insert(hoteles _hotel)
        {
            Orm.bd.hoteles.Add(_hotel);
            return Orm.MySaveChanges();
        }
        public static String Delete(int _id)
        {
            hoteles hotel = Orm.bd.hoteles
                .Where(h => h.id == _id)
                .FirstOrDefault();
            Orm.bd.hoteles.Remove(hotel);
            return Orm.MySaveChanges();
        }
        public static String Update(hoteles _hotel)
        {
            hoteles hotel =Orm.bd.hoteles
                .Where(h => h.id == _hotel.id)
                .FirstOrDefault();
            hotel = _hotel;
            return Orm.MySaveChanges();
        }
    }
}
