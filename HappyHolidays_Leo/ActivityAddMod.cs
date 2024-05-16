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

    public partial class ActivityAddMod : Form
    {
        int type;
        actividades actividadModify;
        List<actividades> listaActividades = ActivityOrm.Select();

        public ActivityAddMod(int type)
        {
            this.type = type;
            InitializeComponent();
        }
        public ActivityAddMod()
        {
            InitializeComponent();
        }

        private void buttonAction_Click(object sender, EventArgs e)
        {
            if (textBoxDesc.Text.Trim() != "")
            {
                if (type == 1) // MODIFICAR
                {
                    modifyActivity();
                }
                else if (type == 2) // BORRAR
                {
                    deleteActivity();
                }
                else // CREAR
                {
                    createActivity();
                }
            }
        }

        private void modifyActivity()
        {
            actividadModify.descripcion = textBoxDesc.Text;
            string msg = Orm.Update();
            if (msg != "")
            {
                MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Actividad modificada con éxito", "¡Maravilloso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bindingSourceActivities.DataSource = ActivityOrm.Select();
            }
        }

        private void createActivity()
        {
            actividades actividad = new actividades();
            actividad.descripcion = textBoxDesc.Text;
            actividad.id_act = getNextId();
            string msg = ActivityOrm.Insert(actividad);
            if (msg != "")
            {
                MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Actividad creada con éxito.", "¡Maravilloso!");
                textBoxDesc.Text = "";
            }
        }
        public int getNextId()
        {
            // Verificar si hay actividades en la lista
            if (listaActividades.Any())
            {
                // Encontrar el ID más alto
                int ultimoId = listaActividades.Max(a => a.id_act);

                // Devolver el siguiente ID disponible (ID más alto + 1)
                return ultimoId + 1;
            }else { return 0; }
        }

        private void deleteActivity()
        {

                DialogResult result = MessageBox.Show($"¿Estás seguro de que quieres eliminar esta actividad?",
                                                   "Confirmación de eliminación",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question);
                string msg;
                if (result == DialogResult.Yes)
                {
                // El usuario ha confirmado la eliminación
                if (!verifyRelation())
                {
                    msg = ActivityOrm.Delete(actividadModify);
                    if (msg != "")
                    {
                        MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Actividad eliminada con éxito", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        bindingSourceActivities.DataSource = ActivityOrm.Select();
                    }
                }
                else
                {
                    MessageBox.Show("Hay un hotel con esta actividad asignada. \nElimina primero la relación para poder eliminar la actividad.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }

            }

        private bool verifyRelation()
        {
            List<act_hotel> listaActHoteles = Act_HotelOrm.Select();

            // Verificar si hay alguna relación entre id_act de actividades y act_hotel
            bool existeRelacion = listaActHoteles.Any(actividad => actividad.id_act == actividadModify.id_act);

            // Devolver el resultado
            return existeRelacion;
        }
        private void ActivityAddMod_Load(object sender, EventArgs e)
        {
            if (type == 1) // MODIFICAR
            {
                bindingSourceActivities.DataSource = listaActividades;
                buttonAction.Text = "Modificar";
                comboBoxActivities.Visible = true;
                labelAct.Visible = true;
            }
            else if (type == 2) // BORRAR
            {
                bindingSourceActivities.DataSource = listaActividades;
                buttonAction.Text = "Borrar";
                comboBoxActivities.Visible = true;
                labelAct.Visible = true;
                textBoxDesc.Enabled = false;
            }
        }

        private void comboBoxActivities_SelectedIndexChanged(object sender, EventArgs e)
        {
            actividadModify = (actividades)comboBoxActivities.SelectedItem;
            textBoxDesc.Text = actividadModify.descripcion;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
