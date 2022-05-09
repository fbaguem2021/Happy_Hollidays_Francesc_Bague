using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Happy_Hollidays_Francesc_Bague.models;

namespace Happy_Hollidays_Francesc_Bague.controllers
{
    class ActividadesController
    {
        public static List<actividades> Select()
        {
            return Orm.bd.actividades
                .OrderBy(a => a.id_act)
                .ToList().Distinct().ToList();
        }
        public static actividades SelectById(int _id_act)
        {
            return Orm.bd.actividades.Where(a => a.id_act == _id_act).FirstOrDefault();
        }
        public static List<actividades> SelectByHotel(hoteles h)
        {
            List<actividades> actividades = Select();
            List<act_hotel> act_hoteles = get_act_hotels(h);
            foreach (act_hotel ah in act_hoteles)
            {
                int i = 0;
                bool found = false;
                while (i < actividades.Count && found == false){
                    if (ah.actividades.id_act == actividades[i].id_act)
                    {
                        actividades.RemoveAt(i);
                        found = true;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            return actividades;
        }
        private static List<act_hotel> get_act_hotels(hoteles h)
        {
            return Orm.bd.act_hotel
                .Where(a => a.hoteles.id == h.id)
                .OrderBy(a => a.actividades.id_act)
                .ToList();
        }
    }
}
