using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PantallasProyectoParte1
{
    public class Especificaciones_Principales
    {
        public int idEspecifPrin { get; set; }
        public string Procesador { get; set; }
        public string PlacaMadre { get; set; }
        public string Graficos { get; set; }
        public int MemoriaRAM { get; set; }
        public int NVentiladores { get; set; }
        public string TipoFuentePoder { get; set; }
        public int PotenciaFuentePoder { get; set; }
        public string TipoFuenteAlimentacion { get; set; }
        public int PotenciaFuenteAlimentacion { get; set; }

        public Especificaciones_Principales(string procesador, string placaMadre, string graficos, int memoriaRAM, int nVentiladores, string tipoFuentePoder, int potenciaFuentePoder, string tipoFuenteAlimentacion, int potenciaFuenteAlimentacion)
        {
            this.Procesador = procesador;
            this.PlacaMadre = placaMadre;
            this.Graficos = graficos;
            this.MemoriaRAM = memoriaRAM;
            this.NVentiladores = nVentiladores;
            this.TipoFuentePoder = tipoFuentePoder;
            this.PotenciaFuentePoder = potenciaFuentePoder;
            this.TipoFuenteAlimentacion = tipoFuenteAlimentacion;
            this.PotenciaFuenteAlimentacion = potenciaFuenteAlimentacion;
        }
    }
}
