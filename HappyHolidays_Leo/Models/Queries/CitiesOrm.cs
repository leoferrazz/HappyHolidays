using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyHolidays_Leo.Models.Queries
{
    public static class CitiesOrm
    {
        public static List<ciudades> Select()
        {
            List<ciudades> ciudades = Orm.db.ciudades.ToList();

            return ciudades;
        }
    }
}
