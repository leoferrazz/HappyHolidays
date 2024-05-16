using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyHolidays_Leo.Models.Queries
{
    public static class ActivityOrm
    {
        public static List<actividades> Select()
        {
            List<actividades> actividades = Orm.db.actividades.ToList();

            return actividades;
        }

        public static actividades Select(int id)
        {
            // Aquí se realiza la consulta usando LINQ
            actividades actividad = Orm.db.actividades
                                    .FirstOrDefault(a => a.id_act == id);

            // Se devuelve la actividad encontrada, o null si no se encuentra ninguna
            return actividad;
        }

        public static String Delete(actividades actividad)
        {
            Orm.db.actividades.Remove(actividad);
            return Orm.MySaveChanges();
        }

        public static String Insert(actividades actividad)
        {
            Orm.db.actividades.Add(actividad);
            return Orm.MySaveChanges();
        }
    }
}
