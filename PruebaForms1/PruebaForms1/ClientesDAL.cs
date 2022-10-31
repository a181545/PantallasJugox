using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace PruebaForms1
{
    public class ClientesDAL
    {
        public static int Agregar(Cliente pCliente)
        {
            int retorno;
            SqlConnection Conexion = ConexionBD.Conectar();

            SqlCommand _comando = new SqlCommand("INSERT INTO Clientes(Nombre, Apellido, Edad, Cuidad_Id) VALUES('"+pCliente.Nombre + "','"+ pCliente.Apellido + "',"+pCliente.Edad+","+ pCliente.Ciudad_Id +")", Conexion);
            retorno = _comando.ExecuteNonQuery();
            Conexion.Close();

            return retorno;
        }


        public static List<Ciudad> ObtenerCiudades()
        {
            List<Ciudad> _lista = new List<Ciudad>();

            SqlConnection Conexion = ConexionBD.Conectar();

            SqlCommand _comando = new SqlCommand("select IdCiudad, Nombre from Ciudades", Conexion);
            SqlDataReader _reader = _comando.ExecuteReader(); //error
            while (_reader.Read())
            {
                Ciudad pCiudad = new Ciudad();

                pCiudad.Id = _reader.GetInt32(0);
                pCiudad.Nombre = _reader.GetString(1);

                _lista.Add(pCiudad);
            }

            return _lista;
        }
    }
}
