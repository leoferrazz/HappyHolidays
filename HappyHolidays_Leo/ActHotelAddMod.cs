using HappyHolidays_Leo.Models;
using HappyHolidays_Leo.Models.Queries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyHolidays_Leo
{
    public partial class ActHotelAddMod : Form
    {
        private List<hoteles> hoteles = new List<hoteles>();
        bool modify;
        act_hotel actividadHotel;
        public ActHotelAddMod(act_hotel actividadHotel, bool modify)
        {
            this.modify = modify;
            this.actividadHotel = actividadHotel;
            InitializeComponent();
        }
        public ActHotelAddMod()
        {
            InitializeComponent();
        }

        private void trackBarGrado_Scroll(object sender, EventArgs e)
        {
            labelGradoValue.Text = trackBarGrado.Value.ToString();
        }

        private void ActHotelAddMod_Load(object sender, EventArgs e)
        {
            hoteles = HotelOrm.Select();
            bindingSourceHotels.DataSource = hoteles;
            bindingSourceActivities.DataSource = ActivityOrm.Select();
            if (modify)
            {
                comboBoxActivities.Enabled = false;
                comboBoxHotels.Enabled = false;
                textBoxBuscarHotel.Enabled = false;
                comboBoxActivities.SelectedItem = actividadHotel.actividades;
                comboBoxHotels.SelectedItem = actividadHotel.hoteles;
                trackBarGrado.Value = actividadHotel.grado;
                labelGradoValue.Text = actividadHotel.grado.ToString();
                buttonAction.Text = "Modificar";
            }
        }

        private void textBoxBuscarHotel_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxBuscarHotel.Text.ToLower(); // Obtener el texto de búsqueda en minúsculas

            // Verificar si el cuadro de búsqueda está vacío
            if (string.IsNullOrWhiteSpace(searchText))
            {
                // Si está vacío, mostrar todas las historias originales
                bindingSourceHotels.DataSource = null;
                bindingSourceHotels.DataSource = hoteles;
            }
            else
            {
                // Si no está vacío, realizar el filtrado
                List<hoteles> filteredHotels = new List<hoteles>();
                foreach (hoteles hotelItem in hoteles)
                {
                    if (hotelItem.nombre.ToLower().Contains(searchText))
                    {
                        filteredHotels.Add(hotelItem);
                    }
                }

                bindingSourceHotels.DataSource = null;
                bindingSourceHotels.DataSource = filteredHotels;
            }
        }

        private void buttonAction_Click(object sender, EventArgs e)
        {
            if (labelGradoValue.Text.Trim() != "")
            {
                string msg;
                if (modify)
                {
                    actividadHotel.actividades = (actividades)comboBoxActivities.SelectedItem;
                    actividadHotel.hoteles = (hoteles)comboBoxHotels.SelectedItem;
                    actividadHotel.grado = trackBarGrado.Value;

                    msg = Orm.Update();
                    if (msg != "")
                    {
                        MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Actividad asignada modificada con éxito.", "¡Maravilloso!");
                    }
                }
                else
                {
                    act_hotel actividadHotel = new act_hotel();
                    actividadHotel.actividades = (actividades)comboBoxActivities.SelectedItem;
                    actividadHotel.hoteles = (hoteles)comboBoxHotels.SelectedItem;
                    actividadHotel.grado = trackBarGrado.Value;

                    msg = Act_HotelOrm.Insert(actividadHotel);
                    if (msg != "")
                    {
                        MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Actividad asignada con éxito.", "¡Maravilloso!");
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Falta asignar un grado.", "Aviso!",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
