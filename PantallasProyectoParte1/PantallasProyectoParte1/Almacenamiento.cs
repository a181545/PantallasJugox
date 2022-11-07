using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PantallasProyectoParte1
{
    public class Almacenamiento
    {
        public int idAlmacenamiento { get; set; }
        public string TipoAlmacenamiento { get; set; }
        public int AlmacenamientoTotal { get; set; }
        public int AlmacenamientoDisponible { get; set; }
        public int ProgramasInstalados { get; set; }

        public Almacenamiento(string tipoAlmacenamiento, int almacenamientoTotal, int almacenamientoDisponible, int programasInstalados)
        {
            this.TipoAlmacenamiento = tipoAlmacenamiento;
            this.AlmacenamientoTotal = almacenamientoTotal;
            this.AlmacenamientoDisponible = almacenamientoDisponible;
            this.ProgramasInstalados = programasInstalados;
        }
    }
}
