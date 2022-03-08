using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Happy_Hollidays_Francesc_Bague.models;

namespace Happy_Hollidays_Francesc_Bague.controllers
{
    public static class CadenasController
    {
        public static List<cadenas> selectAll()
        {
            return Orm.bd.cadenas.ToList();
        }
        public static String Insert(cadenas cadena)
        {
            String message = "";

            Orm.bd.cadenas.Add(cadena);
            message = Orm.MySaveChanges();

            return message;
        }
        public static String Delete(string cif)
        {
            String message = "";

            List<cadenas> cadena = Orm.bd.cadenas.
                Where(c => c.cif == cif).ToList();

            Orm.bd.cadenas.RemoveRange(cadena);

            message = Orm.MySaveChanges();

            return message;
        }
    }
}
