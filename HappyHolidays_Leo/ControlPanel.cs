using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyHolidays_Leo
{
    public partial class ControlPanel : Form
    {
        public ControlPanel()
        {
            InitializeComponent();
        }

        private void buttonCadenas_Click(object sender, EventArgs e)
        {
            HotelChains hotelChains = new HotelChains(this);
            hotelChains.Show();
            Hide();
        }

        private void buttonHotels_Click(object sender, EventArgs e)
        {
            Hotels hotels = new Hotels(this);
            hotels.Show();
            Hide();
        }

        private void buttonActHotels_Click(object sender, EventArgs e)
        {
            ActivitiesHotels actHotels = new ActivitiesHotels(this);
            actHotels.Show();
            Hide();
        }
    }
}
