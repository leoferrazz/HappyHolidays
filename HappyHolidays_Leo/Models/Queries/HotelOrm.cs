using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyHolidays_Leo.Models.Queries
{
    public static class HotelOrm
    {
        public static List<hoteles> Select()
        {
            List<hoteles> hoteles = Orm.db.hoteles.ToList();

            return hoteles;
        }

        public static String Delete(hoteles hotel)
        {
            Orm.db.hoteles.Remove(hotel);
            return Orm.MySaveChanges();
        }

        public static String Insert(hoteles hotel)
        {
            Orm.db.hoteles.Add(hotel);
            return Orm.MySaveChanges();
        }
    }
}
