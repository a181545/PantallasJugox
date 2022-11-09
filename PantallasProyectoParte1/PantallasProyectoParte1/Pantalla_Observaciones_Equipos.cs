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
    public partial class Pantalla_Observaciones_Equipos : Form
    {
        public Pantalla_Observaciones_Equipos()
        {
            InitializeComponent();
        }

        private void Pantalla_Observaciones_Equipos_Load(object sender, EventArgs e)
        {
            VistaEquipos();
        }

        private void VistaEquipos()
        {
            EditorEquipos ee2 = new EditorEquipos();
            dgvEquipos.DataSource = ee2.VistaEquipos();
        }

    }
}
