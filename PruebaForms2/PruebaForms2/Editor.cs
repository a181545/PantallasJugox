using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PruebaForms2
{
    public class Editor
    {

        private ConexionBD Conexion = new ConexionBD();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader Leer;

        public void InsertarEspecificacionesPrimarias (Especificaciones_Edit insercion)
        {

            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "InsertarEspPrim";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@procesador", insercion.Procesador);
            Comando.Parameters.AddWithValue("@placa_madre", insercion.PlacaMadre);
            Comando.Parameters.AddWithValue("@graficos", insercion.Graficos);
            Comando.Parameters.AddWithValue("@memoria_ram", insercion.MemoriaRAM);
            Comando.Parameters.AddWithValue("@ventiladores", insercion.Ventiladores);
            Comando.Parameters.AddWithValue("@fuente_poder", insercion.Fuente_Poder);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }

    }
}
