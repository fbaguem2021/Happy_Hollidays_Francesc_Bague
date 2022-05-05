using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Happy_Hollidays_Francesc_Bague.models;

namespace Happy_Hollidays_Francesc_Bague.controllers
{
    class ActHotelController
    {
        public static List<act_hotel> Select(hoteles h)
        {
            return Orm.bd.act_hotel
                .Where(ah => ah.id_ciudad == h.id_ciudad && ah.nombre != h.nombre)
                .OrderBy(ah => ah.id_act)
                .ToList();
        }
        public static String Insert(act_hotel ah)
        {
            Orm.bd.act_hotel.Add(ah);
            return Orm.MySaveChanges();
        }
    }
}
