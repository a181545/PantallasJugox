using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PantallasProyectoParte1
{
    public class Condiciones_Externas
    {
        public int idCondExt { get; set; }
        public string CondGabinete { get; set; }
        public string CondTeclado { get; set; }
        public string CondMouse { get; set; }
        public string CondMonitor { get; set; }

        public Condiciones_Externas(string condGabinete, string condTeclado, string condMouse, string condMonitor)
        {
            this.CondGabinete = condGabinete;
            this.CondTeclado = condTeclado;
            this.CondMouse = condMouse;
            this.CondMonitor = condMonitor;
        }
    }
}
