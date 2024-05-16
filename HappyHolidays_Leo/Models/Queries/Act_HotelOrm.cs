using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyHolidays_Leo.Models.Queries
{
    public static class Act_HotelOrm
    {
        public static List<act_hotel> Select()
        {
            List<act_hotel> actividadesHotel = Orm.db.act_hotel.ToList();

            return actividadesHotel;
        }

        public static String Delete(act_hotel actividadesHotel)
        {
            Orm.db.act_hotel.Remove(actividadesHotel);
            return Orm.MySaveChanges();
        }

        public static String Insert(act_hotel actividadesHotel)
        {
            Orm.db.act_hotel.Add(actividadesHotel);
            return Orm.MySaveChanges();
        }
    }
}
