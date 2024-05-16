using HappyHolidays_Leo.Models;
using HappyHolidays_Leo.Models.Queries;
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
    public partial class Hotels : Form
    {
        ControlPanel controlPanel;
        public Hotels(ControlPanel controlPanel)
        {
            this.controlPanel = controlPanel;
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
            controlPanel.Show();
        }

        private void Hotels_FormClosed(object sender, FormClosedEventArgs e)
        {
            controlPanel.Show();
        }

        private void añadirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HotelAddMod hotelAddMod = new HotelAddMod();
            hotelAddMod.ShowDialog();
            bindingSourceHotels.DataSource = HotelOrm.Select();
        }

        private void Hotels_Load(object sender, EventArgs e)
        {
            bindingSourceHotels.DataSource = HotelOrm.Select();
        }

        private void dataGridViewHotelChains_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                hoteles hotel = (hoteles)dataGridViewHotels.Rows[e.RowIndex].DataBoundItem;
                e.Value = hotel.ciudades.nombre;
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {

            if (dataGridViewHotels.SelectedRows.Count > 0)
            {
                // Obtener la cadena hotelera seleccionada
                hoteles hotel = (hoteles)dataGridViewHotels.SelectedRows[0].DataBoundItem;

                // Mostrar cuadro de diálogo de confirmación
                DialogResult result = MessageBox.Show($"¿Estás seguro de que quieres eliminar el hotel {hotel.nombre}?",
                                                        "Confirmación de eliminación",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // El usuario ha confirmado la eliminación
                    string msg = HotelOrm.Delete(hotel);
                    if (msg != "")
                    {
                        MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Hotel eliminado con éxito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bindingSourceHotels.DataSource = HotelOrm.Select();
                    }
                }
            }
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {
            hoteles hotel = (hoteles)dataGridViewHotels.SelectedRows[0].DataBoundItem;
            HotelAddMod hotelAddMod = new HotelAddMod(hotel, true);
            hotelAddMod.ShowDialog();
            bindingSourceHotels.DataSource = HotelOrm.Select();
        }
    }
}
