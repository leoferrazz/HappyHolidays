using HappyHolidays_Leo.Models;
using HappyHolidays_Leo.Models.Queries;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HappyHolidays_Leo
{
    public partial class HotelChainsAddMod : Form
    {
        private string cif;
        private string nombre;
        private string dirFis;
        private cadenas cadenaModify;
        private bool modify = false;
        public HotelChainsAddMod()
        {
            InitializeComponent();
        }

        public HotelChainsAddMod(cadenas cadenaModify, bool modify)
        {
            this.cadenaModify = cadenaModify;
            this.modify = modify;
            InitializeComponent();
        }

        private void buttonAction_Click(object sender, EventArgs e)
        {
            if (checkTextBox())
            {
                string msg;
                if (modify)
                {
                    cadenaModify.cif = cif;
                    cadenaModify.nombre = nombre;
                    cadenaModify.dir_fis = dirFis;
                    msg = Orm.Update();
                    if (msg != "")
                    {
                        MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Cadena hotelera modificada con éxito.", "¡Maravilloso!");

                    }

                }
                else
                {
                    cadenas cadena = new cadenas();
                    cadena.cif = cif;
                    cadena.nombre = nombre;
                    cadena.dir_fis = dirFis;

                    msg = HotelChainOrm.Insert(cadena);
                if (msg != "")
                {
                    MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Cadena hotelera añadida con éxito.", "¡Maravilloso!");
                    textBoxCIF.Text = "";
                    textBoxNombre.Text = "";
                    textBoxDirFis.Text = "";

                }
                }
                
            }
        }

        private bool checkTextBox()
        {
            cif = textBoxCIF.Text.Trim();
            nombre = textBoxNombre.Text.Trim();
            dirFis = textBoxDirFis.Text.Trim();

            if (cif == "")
            {
                MessageBox.Show("El campo CIF no puede estar vacío", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string pattern = @"^A\d{8}$"; // Patrón: A seguido de 8 dígitos
            Regex regex = new Regex(pattern);
            if (!regex.IsMatch(cif))
            {
                MessageBox.Show("El campo CIF no cumple con el patrón: A12345678", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (nombre == "")
            {
                MessageBox.Show("El campo Nombre no puede estar vacío", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (nombre.Length >= 50)
            {
                MessageBox.Show("El campo Nombre no puede superar los 50 caracteres", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dirFis == "")
            {
                MessageBox.Show("El campo Dirección Fiscal no puede estar vacío", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (dirFis.Length >= 50)
            {
                MessageBox.Show("El campo Dirección Fiscal no puede superar los 50 caracteres", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HotelChainsAddMod_Load(object sender, EventArgs e)
        {
            if (modify)
            {
                textBoxCIF.Text = cadenaModify.cif;
                textBoxCIF.Enabled = false;
                textBoxNombre.Text = cadenaModify.nombre;
                textBoxDirFis.Text = cadenaModify.dir_fis;
                buttonAction.Text = "Modificar";
            }
        }
    }
}
