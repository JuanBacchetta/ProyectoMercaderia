using Mercaderia.Conexion;
using Mercaderia.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Mercaderia.Datos
{
    public class DFamilia
    {

        Conexionbd cn = new Conexionbd();

        public async Task AltaFamilia(Familia parametros)
        {
            using (var sql = new SqlConnection(cn.cadenaSQL()))
            {
                using (var cmd = new SqlCommand("AltaFamilia", sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@idmarca", parametros.Id);
                    cmd.Parameters.AddWithValue("@descripcionproducto", parametros.Descripcion);
                    cmd.Parameters.AddWithValue("@fechamodificacion", parametros.FechaModificacion);
                    cmd.Parameters.AddWithValue("@baja", parametros.Baja);
                    cmd.Parameters.AddWithValue("@fechabaja", parametros.FechaBaja);
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }

            }
        }


        public async Task ModificacionFamilia(Familia parametros)
        {
            using (var sql = new SqlConnection(cn.cadenaSQL()))
            {
                using (var cmd = new SqlCommand("ModificacionFamilia", sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@idmarca", parametros.Id);
                    cmd.Parameters.AddWithValue("@descripcionproducto", parametros.Descripcion);
                    cmd.Parameters.AddWithValue("@fechamodificacion", parametros.FechaModificacion);
                    cmd.Parameters.AddWithValue("@baja", parametros.Baja);
                    cmd.Parameters.AddWithValue("@fechabaja", parametros.FechaBaja);
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }

            }
        }


        public async Task BajaFamilia(Familia parametros)
        {
            using (var sql = new SqlConnection(cn.cadenaSQL()))
            {
                using (var cmd = new SqlCommand("BajaFamilia", sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idfamilia", parametros.Id);
                    cmd.Parameters.AddWithValue("@baja", parametros.Baja);
                    cmd.Parameters.AddWithValue("@fechabaja", parametros.FechaBaja);
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }
    }
}
