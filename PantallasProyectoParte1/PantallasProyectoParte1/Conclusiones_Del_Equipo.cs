using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PantallasProyectoParte1
{
    public class Conclusiones_Del_Equipo
    {
        public int idConclusiones { get; set; }
        public DateTime UltimoMantenimiento { get; set; }
        public string CondicionesGenerales { get; set; }
        public string Observaciones { get; set; }

        public Conclusiones_Del_Equipo(DateTime ultimoMantenimiento, string condicionesGenerales, string observaciones)
        {
            this.UltimoMantenimiento = ultimoMantenimiento;
            this.CondicionesGenerales = condicionesGenerales;
            this.Observaciones = observaciones;
        }
    }
}
