using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaForms2
{
    public class Equipos
    {
        public int IdEquipo { get; set; }
        public string Equipo { get; set; }

        public Equipos(int id_Equipo, string equipo)
        {
            this.IdEquipo = id_Equipo;
            this.Equipo = equipo;
        }

        

    }
}
