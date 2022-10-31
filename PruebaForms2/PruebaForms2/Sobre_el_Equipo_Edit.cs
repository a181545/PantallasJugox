using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaForms2
{
    public class Sobre_el_Equipo_Edit
    {
        public int IdSE { get; set; }
        public DateTime UltimoMantenimiento { get; set; }
        public string CondGenerales { get; set; }
        public string CondGabinete { get; set; }
        public string CondTeclado { get; set; }
        public string CondMouse { get; set; }
        public string CondMonitor { get; set; }
        public string TipoAlimentacion { get; set; }
        public int Potencia_Alm { get; set; }
        public string Observaciones { get; set; }
        public int Id_Equipo { get; set; }

        public Sobre_el_Equipo_Edit(int idSE, DateTime ultimoMantenimiento, string condGenerales, string condGabinete, string condTeclado, string condMouse, string condMonitor, string tipoAlimentacion, int potencia_Alm, string observaciones, int id_Equipo)
        {
            this.IdSE = idSE;
            this.UltimoMantenimiento = ultimoMantenimiento;
            this.CondGenerales = condGenerales;
            this.CondGabinete = condGabinete;
            this.CondTeclado = condTeclado;
            this.CondMouse = condMouse;
            this.CondMonitor = condMonitor;
            this.TipoAlimentacion = tipoAlimentacion;
            this.Potencia_Alm = potencia_Alm;
            this.Observaciones = observaciones;
            this.Id_Equipo = id_Equipo;
        }
    }
}
