create procedure InsertarDatosSobreElEquipo2
@cond_generales nvarchar(15),
@cond_gabinete nvarchar(15),
@cond_teclado nvarchar(15),
@cond_mouse nvarchar(15),
@cond_monitor nvarchar(15),
@tipo_alim nvarchar(30),
@potencia_alm int,
@observaciones text
as
insert into Sobre_el_Equipo values (@cond_generales, @cond_gabinete, @cond_teclado, @cond_mouse, @cond_monitor, @tipo_alim, @potencia_alm, @observaciones)
go

exec InsertarDatosSobreElEquipo2 'Buena','Buena','Buena','Buena','Buena','Regulador',600,'Ninguna'

select * from Sobre_el_Equipo

/*
public void InsertarSeE (Sobre_el_Equipo_Edit insercion2)
        {
            Comando.Connection = Conexion.AbrirConexion();
            Comando.CommandText = "InsertarDatosSobreElEquipo";
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@ultimo_mant", insercion2.UltimoMantenimiento);
            Comando.Parameters.AddWithValue("@cond_generales", insercion2.CondGenerales);
            Comando.Parameters.AddWithValue("@cond_gabinete", insercion2.CondGabinete);
            Comando.Parameters.AddWithValue("@cond_teclado", insercion2.CondTeclado);
            Comando.Parameters.AddWithValue("@cond_mouse", insercion2.CondMouse);
            Comando.Parameters.AddWithValue("@cond_monitor", insercion2.CondMonitor);
            Comando.Parameters.AddWithValue("@tipo_alim", insercion2.TipoAlimentacion);
            Comando.Parameters.AddWithValue("@potencia_alm", insercion2.Potencia_Alm);
            Comando.Parameters.AddWithValue("@observaciones", insercion2.Observaciones);
            Comando.ExecuteNonQuery();
            Comando.Parameters.Clear();

        }
*/