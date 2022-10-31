using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaForms1
{
    public partial class PruebaTextCB : Form
    {
        public PruebaTextCB()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente pCliente = new Cliente();
            pCliente.Nombre = txtNombre.Text;
            pCliente.Apellido = txtApellido.Text;
            pCliente.Edad = txtEdad.Text;
            pCliente.Ciudad_Id = Convert.ToInt32(cboCiudad.SelectedValue);

            if (ClientesDAL.Agregar(pCliente) > 0)
            {
                MessageBox.Show("Cliente Agregado Con Exito", "Cliente Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al guardar cliente", "Error Critico", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void PruebaTextCB_Load(object sender, EventArgs e)
        {
            cboCiudad.DataSource = ClientesDAL.ObtenerCiudades();
            cboCiudad.DisplayMember = "Nombre";
            cboCiudad.ValueMember = "Id";
        }
    }
}
