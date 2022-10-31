using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaForms2
{
    public partial class Pantalla_Edicion : Form
    {
        public Pantalla_Edicion()
        {
            InitializeComponent();
        }

        
        private void Pantalla_Edicion_Load(object sender, EventArgs e)
        {

        }

        private void gpbEspecifEdit_Enter(object sender, EventArgs e)
        {

        }

        private void gpbAlmEdit_Enter(object sender, EventArgs e)
        {

        }

        private void gpbAlimEqEdit_Enter(object sender, EventArgs e)
        {

        }

        private void gpbDiscoEdit_Enter(object sender, EventArgs e)
        {

        }

        private void gpbCondGenEdit_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            Editor editor = new Editor();
            editor.InsertarEspecificacionesPrimarias();
        }
    }
}
