using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaForms1
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Edad { get; set; }
        public int Ciudad_Id { get; set; }

        public Cliente(){ }


        public Cliente(int pId, string pNombre, string pApellido, string pEdad, int pCiudad)
        {
            this.Id = pId;
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.Edad = pEdad;
            this.Ciudad_Id = pCiudad;

        }

        
    }
}
