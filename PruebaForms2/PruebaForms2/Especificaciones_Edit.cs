using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaForms2
{
    public class Especificaciones_Edit
    {
        public int IdEspecif { get; set; }
        public string Procesador { get; set; }
        public string PlacaMadre { get; set; }
        public string Graficos { get; set; }
        public int MemoriaRAM { get; set; }
        public int Ventiladores { get; set; }
        public string Fuente_Poder { get; set; }
        public int IdEquipo { get; set; }

        public Especificaciones_Edit(int idEspecif, string procesador, string placaMadre, string graficos, int memoriaRAM, int ventiladores, string fuente_poder, string tipoFuente, int idEquipo)
        {
            this.IdEspecif = idEspecif;
            this.Procesador = procesador;
            this.PlacaMadre = placaMadre;
            this.Graficos = graficos;
            this.MemoriaRAM = memoriaRAM;
            this.Ventiladores = ventiladores;
            this.Fuente_Poder = fuente_poder;
            this.IdEquipo = idEquipo;
        }
    }
}
