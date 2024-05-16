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
    public partial class HotelChains : Form
    {
        ControlPanel controlPanel;
        public HotelChains(ControlPanel controlPanel)
        {
            this.controlPanel = controlPanel;
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
            controlPanel.Show();
        }

        private void añadirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HotelChainsAddMod hotelChainsAddMod = new HotelChainsAddMod();
            hotelChainsAddMod.ShowDialog();
            bindingSourceHotelChains.DataSource = HotelChainOrm.Select();
        }

        private void HotelChains_FormClosed(object sender, FormClosedEventArgs e)
        {
            controlPanel.Show();
        }

        private void HotelChains_Load(object sender, EventArgs e)
        {
            bindingSourceHotelChains.DataSource = HotelChainOrm.Select();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (dataGridViewHotelChains.SelectedRows.Count > 0)
            {
                // Obtener la cadena hotelera seleccionada
                cadenas cadena = (cadenas)dataGridViewHotelChains.SelectedRows[0].DataBoundItem;

                // Mostrar cuadro de diálogo de confirmación
                DialogResult result = MessageBox.Show($"¿Estás seguro de que quieres eliminar la cadena {cadena.nombre}?",
                                                        "Confirmación de eliminación",
                                                        MessageBoxButtons.YesNo,
                                                        MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // El usuario ha confirmado la eliminación
                    string msg = HotelChainOrm.Delete(cadena);
                    if (msg != "")
                    {
                        if (msg == "El registro tiene datos relacionados.")
                        {
                            MessageBox.Show($"{msg} \nBorra primero todos los hoteles relacionados con esta cadena", "", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                        {
                            MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cadena hotelera eliminada con éxito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bindingSourceHotelChains.DataSource = HotelChainOrm.Select();
                    }
                }
            }
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {
            cadenas cadena = (cadenas)dataGridViewHotelChains.SelectedRows[0].DataBoundItem;
            HotelChainsAddMod hotelChainsAddMod = new HotelChainsAddMod(cadena, true);
            hotelChainsAddMod.ShowDialog();
            bindingSourceHotelChains.DataSource = HotelChainOrm.Select();
        }
    }
}
