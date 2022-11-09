using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PantallasProyectoParte1
{
    public class EditorEquipos
    {
        private ConexionBaseDatos Conexion = new ConexionBaseDatos();
        private SqlCommand Comando = new SqlCommand();
        private SqlDataReader LeerFilas;
        private SqlDataReader LeerID;

        //Inserción de datos nuevos
        public void InsertarEspecificacionesPrincipales(Especificaciones_Principales insercion1)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "InsertarEspecificacionesPrincipales";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@procesador", insercion1.Procesador);
            Comando.Parameters.AddWithValue("@placa_madre", insercion1.PlacaMadre);
            Comando.Parameters.AddWithValue("@graficos", insercion1.Graficos);
            Comando.Parameters.AddWithValue("@memoria_ram", insercion1.MemoriaRAM);
            Comando.Parameters.AddWithValue("@n_ventiladores", insercion1.NVentiladores);
            Comando.Parameters.AddWithValue("@tipo_fuente_poder", insercion1.TipoFuentePoder);
            Comando.Parameters.AddWithValue("@potencia_fuente_poder", insercion1.PotenciaFuentePoder);
            Comando.Parameters.AddWithValue("@tipo_fuente_alimentacion", insercion1.TipoFuenteAlimentacion);
            Comando.Parameters.AddWithValue("@potencia_fuente_alimentacion", insercion1.PotenciaFuenteAlimentacion);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }

        public void InsertarAlmacenamiento(Almacenamiento insercion2)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "InsertarAlmacenamiento";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@tipo_almacenamiento", insercion2.TipoAlmacenamiento);
            Comando.Parameters.AddWithValue("@alm_total", insercion2.AlmacenamientoTotal);
            Comando.Parameters.AddWithValue("@alm_disponible", insercion2.AlmacenamientoDisponible);
            Comando.Parameters.AddWithValue("@prog_instalados", insercion2.ProgramasInstalados);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }

        public void InsertarCondicionesExternas(Condiciones_Externas insercion3)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "InsertarCondicionesExternas";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@cond_gabinete", insercion3.CondGabinete);
            Comando.Parameters.AddWithValue("@cond_teclado", insercion3.CondTeclado);
            Comando.Parameters.AddWithValue("@cond_mouse", insercion3.CondMouse);
            Comando.Parameters.AddWithValue("@cond_monitor", insercion3.CondMonitor);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }

        public void InsertarConclusiones(Conclusiones_Del_Equipo insercion4)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "InsertarConclusiones";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@ultimo_mantenimiento", insercion4.UltimoMantenimiento);
            Comando.Parameters.AddWithValue("@cond_generales", insercion4.CondicionesGenerales);
            Comando.Parameters.AddWithValue("@observaciones", insercion4.Observaciones);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }

        public void GuardarEquipo(NombreEquipos guardado)
        {
            //Seleccionar el maximo id de la tablas
            Comando.CommandText = "MaximoIDPrueba";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerID = Comando.ExecuteReader();
            while (LeerID.Read())
            {
                Comando.Connection = Conexion.AbrirConexion();
                int Ep = int.Parse(LeerID["ep"].ToString());
                int Alm = int.Parse(LeerID["al"].ToString());
                int Ce = int.Parse(LeerID["ce"].ToString());
                int Con = int.Parse(LeerID["con"].ToString());
                guardado.idEspecifPrinF = Ep;
                guardado.idCondExtF = Ce;
                guardado.idAlmacenamientoF = Alm;
                guardado.idConclusionesF = Con;
            }
            LeerID.Close();
            Comando.CommandText = "InsertarEquiposIDsPrueba";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@equipo", guardado.Equipos);
            Comando.Parameters.AddWithValue("@idEspecifPrinF", guardado.idEspecifPrinF);
            Comando.Parameters.AddWithValue("@idCondExtF", guardado.idCondExtF);
            Comando.Parameters.AddWithValue("@idAlmacenamiento", guardado.idAlmacenamientoF);
            Comando.Parameters.AddWithValue("@idConclusiones", guardado.idConclusionesF);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();
        }

        //Vista de tablas
        public DataTable VistaEquipos()
        {
            DataTable dt = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "MostrarEquiposPrueba";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas=Comando.ExecuteReader();
            dt.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return dt;
        }

        public DataTable VistaEspecificacionesPrincipales()
        {
            DataTable dt = new DataTable();
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "MostrarEquiposPrueba";
            Comando.CommandType = CommandType.StoredProcedure;
            LeerFilas = Comando.ExecuteReader();
            dt.Load(LeerFilas);
            LeerFilas.Close();
            Conexion.CerrarConexion();
            return dt;
        }

    }
}
