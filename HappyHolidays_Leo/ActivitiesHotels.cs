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
    public partial class ActivitiesHotels : Form
    {
        ControlPanel controlPanel;
        public ActivitiesHotels(ControlPanel controlPanel)
        {
            this.controlPanel = controlPanel;
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
            controlPanel.Show();
        }

        private void ActivitiesHotels_FormClosed(object sender, FormClosedEventArgs e)
        {
            controlPanel.Show();
        }

        private void ActivitiesHotels_Load(object sender, EventArgs e)
        {
            bindingSourceActHotels.DataSource = Act_HotelOrm.Select();
        }

        private void dataGridViewHotelChains_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 0 )
            {
                act_hotel actividadHotel = (act_hotel)dataGridViewActHotels.Rows[e.RowIndex].DataBoundItem;
                e.Value = actividadHotel.hoteles.ciudades.nombre;
            }
            if (e.ColumnIndex == 1)
            {
                act_hotel actividadHotel = (act_hotel)dataGridViewActHotels.Rows[e.RowIndex].DataBoundItem;
                e.Value = actividadHotel.hoteles.nombre;
            }
            if (e.ColumnIndex == 2)
            {
                act_hotel actividadHotel = (act_hotel)dataGridViewActHotels.Rows[e.RowIndex].DataBoundItem;
                e.Value = actividadHotel.actividades.descripcion;
            }
        }

        private void buttonActHotelAsignar_Click(object sender, EventArgs e)
        {
            ActHotelAddMod hotelAddMod = new ActHotelAddMod();
            hotelAddMod.ShowDialog();
            bindingSourceActHotels.DataSource = Act_HotelOrm.Select();
        }

        private void crearActividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivityAddMod activityAddMod = new ActivityAddMod();
            activityAddMod.ShowDialog();
        }

        private void modificarActividadToolStripMenuItem_Click(object sender, EventArgs e)

        {   ActivityAddMod activityAddMod = new ActivityAddMod(1);
            activityAddMod.ShowDialog();
            bindingSourceActHotels.DataSource = Act_HotelOrm.Select();
        }

        private void borrarActividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ActivityAddMod activityAddMod = new ActivityAddMod(2);
            activityAddMod.ShowDialog();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {

            if (dataGridViewActHotels.SelectedRows.Count > 0)
            {
                // Obtener la cadena hotelera seleccionada
                act_hotel actividadHotel = (act_hotel)dataGridViewActHotels.SelectedRows[0].DataBoundItem;

                // Mostrar cuadro de diálogo de confirmación
                DialogResult result = MessageBox.Show($"¿Estás seguro de que quieres eliminar?",
                                                        "Confirmación de eliminación",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // El usuario ha confirmado la eliminación
                    string msg = Act_HotelOrm.Delete(actividadHotel);
                    if (msg != "")
                    {
                            MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Relación eliminada con éxito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bindingSourceActHotels.DataSource = Act_HotelOrm.Select();
                    }
                }
            }
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {
            act_hotel actividadHotel = (act_hotel)dataGridViewActHotels.SelectedRows[0].DataBoundItem;

            ActHotelAddMod hotelAddMod = new ActHotelAddMod(actividadHotel, true);
            hotelAddMod.ShowDialog();
            bindingSourceActHotels.DataSource = Act_HotelOrm.Select();
        }
    }
}
