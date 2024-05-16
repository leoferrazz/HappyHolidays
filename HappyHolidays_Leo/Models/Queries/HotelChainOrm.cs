using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyHolidays_Leo.Models.Queries
{
    public static class HotelChainOrm
    {
        public static List<cadenas> Select()
        {
            List<cadenas> cadenas = Orm.db.cadenas.ToList();

            return cadenas;
        }

        public static String Insert(cadenas cadena)
        {
            Orm.db.cadenas.Add(cadena);
            return Orm.MySaveChanges();
        }

        public static String Delete(cadenas cadena)
        {
            Orm.db.cadenas.Remove(cadena);
            return Orm.MySaveChanges();
        }
    }
}
