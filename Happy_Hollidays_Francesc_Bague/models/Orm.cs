using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Happy_Hollidays_Francesc_Bague.views;
using Happy_Hollidays_Francesc_Bague.controllers;
using Happy_Hollidays_Francesc_Bague.models;

namespace Happy_Hollidays_Francesc_Bague.models
{
    public static class Orm
    {
        public static hoteles_efEntities bd = new hoteles_efEntities();

        public static String MySaveChanges()
        {
            String message = "";

            try
            {
                Orm.bd.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                SqlException sqlException = (SqlException)ex.InnerException.InnerException;
                message = ErrorMessage(sqlException);
                RejectChanges();
            }

            return message;
        }

        public static String ErrorMessage(SqlException sqlException)
        {
            String message = "";

            switch (sqlException.Number)
            {
                case 2:
                    message = "El servidor no esta operativo";
                    break;
                case 547:
                    message = "El registro tiene datos relacionados";
                    break;
                case 2601:
                    message = "Registro duplicado";
                    break;
                case 2627:
                    message = "Registro duplicado";
                    break;
                case 4060:
                    message = "No se puede abrir la base de datos";
                    break;
                case 18456:
                    message = "Error al iniciar sesion";
                    break;
                default:
                    message = sqlException.Number + " - " + sqlException.Message;
                    break;
            }

            return message;
        }

        public static void RejectChanges()
        {
            foreach (DbEntityEntry item in bd.ChangeTracker.Entries())
            {
                switch (item.State)
                {
                    case System.Data.Entity.EntityState.Detached:
                        break;
                    case System.Data.Entity.EntityState.Unchanged:
                        break;
                    case System.Data.Entity.EntityState.Added:
                        item.State = System.Data.Entity.EntityState.Detached;
                        break;
                    case System.Data.Entity.EntityState.Deleted:
                        item.Reload();
                        break;
                    case System.Data.Entity.EntityState.Modified:
                        item.State = System.Data.Entity.EntityState.Unchanged;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
