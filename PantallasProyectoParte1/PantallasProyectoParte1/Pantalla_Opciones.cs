using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PantallasProyectoParte1
{
    public partial class Pantalla_Opciones : Form
    {
        private ConexionBaseDatos Conects = new ConexionBaseDatos();
        public Pantalla_Opciones()
        {
            InitializeComponent();
        }

        private void dgvEquipos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Pantalla_Equipos_Load(object sender, EventArgs e)
        {

        }

        

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("¿Está seguro de que quiere salir del programa?","Salir",MessageBoxButtons.YesNo);

            if(dg == DialogResult.Yes)
            {
                Close();
                Conects.CerrarConexion();
            }
            
        }
    }
}
