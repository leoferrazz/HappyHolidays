using HappyHolidays_Leo.Models;
using HappyHolidays_Leo.Models.Queries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyHolidays_Leo
{
    public partial class HotelAddMod : Form
    {
        private string nombre;
        private int categoria;
        private string direccion;
        private string telefono;
        private string tipo;
        private cadenas cadena;
        private ciudades ciudad;
        private hoteles hotelModify;
        private bool modify;

        public HotelAddMod()
        {
            InitializeComponent();
        }

        public HotelAddMod(hoteles hotelModify, bool modify)
        {
            this.hotelModify = hotelModify;
            this.modify = modify;
            InitializeComponent();
        }

        private void HotelAddMod_Load(object sender, EventArgs e)
        {
            bindingSourceHotelChains.DataSource = HotelChainOrm.Select();
            bindingSourceCities.DataSource = CitiesOrm.Select();
            comboBoxCategoria.SelectedIndex = 0;
            comboBoxTipo.SelectedIndex = 0;

            if (modify)
            {
                textBoxNombre.Text = hotelModify.nombre;
                textBoxNombre.Enabled = false;
                comboBoxCategoria.SelectedItem = hotelModify.categoria.ToString();
                textBoxDireccion.Text = hotelModify.direccion;
                textBoxTelefono.Text = hotelModify.telefono.ToString();
                comboBoxTipo.SelectedItem = hotelModify.tipo;
                comboBoxCadenaHotel.SelectedItem = hotelModify.cadenas;
                comboBoxCiudades.SelectedItem = hotelModify.ciudades;
                comboBoxCiudades.Enabled = false;
                buttonAction.Text = "Modificar";
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAction_Click(object sender, EventArgs e)
        {
            if (checkTextBox())
            {
                string msg;
                if (modify)
                {
                    hotelModify.nombre = nombre;
                    hotelModify.categoria = categoria;
                    hotelModify.direccion = direccion;
                    hotelModify.telefono = Convert.ToInt32(telefono);
                    hotelModify.tipo = tipo;
                    hotelModify.cadenas = cadena;
                    hotelModify.ciudades = ciudad;

                    msg = Orm.Update();
                    if (msg != "")
                    {
                        MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Hotel modificado con éxito.", "¡Maravilloso!");

                    }
                }
                else
                {
                    hoteles hotel = new hoteles();
                    hotel.nombre = nombre;
                    hotel.categoria = categoria;
                    hotel.direccion = direccion;
                    hotel.telefono = Convert.ToInt32(telefono);
                    hotel.tipo = tipo;
                    hotel.cadenas = cadena;
                    hotel.ciudades = ciudad;

                    msg = HotelOrm.Insert(hotel);
                    if (msg != "")
                    {
                        MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Hotel añadido con éxito.", "¡Maravilloso!");
                        textBoxNombre.Text = "";
                        textBoxDireccion.Text = "";
                        textBoxTelefono.Text = "";
                        comboBoxCategoria.SelectedIndex = 0;
                        comboBoxTipo.SelectedIndex = 0;
                    }
                }
            }
        }

        private bool checkTextBox()
        {
            nombre = textBoxNombre.Text.Trim();
            categoria = Convert.ToInt32(comboBoxCategoria.SelectedItem);
            direccion = textBoxDireccion.Text.Trim();
            telefono = textBoxTelefono.Text.Trim();
            tipo = comboBoxTipo.SelectedItem?.ToString(); // Aquí usamos el operador de navegación segura (?)
            cadena = (cadenas)comboBoxCadenaHotel.SelectedItem;
            ciudad = (ciudades)comboBoxCiudades.SelectedItem;

            if (!checkNombre())
            {
                return false;
            }

            if (!checkCategoria())
            {
                return false;
            }

            if (!checkDireccion())
            {
                return false;
            }

            if (!checkTelefono())
            {
                return false;
            }

            if (!checkTipo())
            {
                return false;
            }

            return true;
        }


        private Boolean checkTipo() 
        {
            if (tipo != "")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Seleccione el tipo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private Boolean checkTelefono()
        {
            string pattern = @"^\d{9}$";
            Regex regex = new Regex(pattern);

            if (telefono != "")
            {
                if (regex.IsMatch(telefono.ToString()))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("El campo Teléfono no cumple con el patrón (123456789)", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("El campo Teléfono no puede estar vacío", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private Boolean checkDireccion()
        {
            if (direccion != "")
            {
                if (direccion.Length < 50)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("El campo Nombre no puede superar los 50 carácteres", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("El campo Nombre no puede estar vacío", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private Boolean checkCategoria()
        {
            if (categoria > 0 )
            {
                return true;
            }
            else
            {
                MessageBox.Show("Seleccione la categoria", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private Boolean checkNombre()
        {
            if (nombre != "")
            {
                if (nombre.Length < 30)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("El campo Nombre no puede superar los 30 carácteres", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("El campo Nombre no puede estar vacío", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

    }
}
