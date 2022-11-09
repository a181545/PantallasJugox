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
    public partial class Pantalla_Agregar_Equipo : Form
    {
        EditorEquipos ee = new EditorEquipos();
        public Pantalla_Agregar_Equipo()
        {
            InitializeComponent();
        }

        private void Pantalla_Agregar_Equipo_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardarCambiosNuevo_Click(object sender, EventArgs e)
        {
            Especificaciones_Principales EP = new Especificaciones_Principales(txtProcNuevo.Text, txtPMNuevo.Text, txtGraficosNuevo.Text, 
                int.Parse(txtRAMNuevo.Text), int.Parse(txtVentNuevo.Text), cboFuentePoderNuevo.Text, int.Parse(txtPotFuenteNuevo.Text), 
                cboFuenteAlimNuevo.Text, int.Parse(txtPotAlimNuevo.Text));
            ee.InsertarEspecificacionesPrincipales(EP);

            Almacenamiento alm = new Almacenamiento(cboTipoAlmNuevo.Text, int.Parse(txtAlmTotNuevo.Text),
                int.Parse(txtAlmDispNuevo.Text), int.Parse(txtProgInstNuevo.Text));
            ee.InsertarAlmacenamiento(alm);

            Condiciones_Externas ce = new Condiciones_Externas(cboGabineteNuevo.Text, cboTecladoNuevo.Text, cboMouseNuevo.Text, cboMonitorNuevo.Text);
            ee.InsertarCondicionesExternas(ce);

            Conclusiones_Del_Equipo cde = new Conclusiones_Del_Equipo(dtpUltMantNuevo.Value, cboCondGenNuevo.Text, txtObservacionesNuevo.Text);
            ee.InsertarConclusiones(cde);

            MessageBox.Show("Los datos se han introducido correctamente, necesita agregar el nombre a su nuevo equipo");

            btnGuardarEquipo.Enabled = true;
            txtEquipoNuevo.Enabled = true;
        }

        private void btnGuardarEquipo_Click(object sender, EventArgs e)
        {
            
            NombreEquipos ne = new NombreEquipos(txtEquipoNuevo.Text);
            ee.GuardarEquipo(ne);
            MessageBox.Show("Equipo nuevo guardado satisfactoriamente");
            Close();
        }
    }
}
