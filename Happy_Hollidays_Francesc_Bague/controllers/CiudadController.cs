using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Happy_Hollidays_Francesc_Bague.models;

namespace Happy_Hollidays_Francesc_Bague.controllers
{
    class CiudadController
    {
        public static List<ciudades> SelectAll()
        {
            return Orm.bd.ciudades.ToList();
        }
    }
}
