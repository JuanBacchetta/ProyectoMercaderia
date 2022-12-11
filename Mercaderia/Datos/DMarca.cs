
using Mercaderia.Conexion;
using Mercaderia.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Mercaderia.Datos
{
    public class DMarca
    {
        Conexionbd cn = new Conexionbd();


        public async Task AltaMarca(Marca parametros)
        {
            using (var sql = new SqlConnection(cn.cadenaSQL()))
            {
                using (var cmd = new SqlCommand("AltaMarca", sql))
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


        public async Task ModificacionMarca(Marca parametros)
        {
            using (var sql = new SqlConnection(cn.cadenaSQL()))
            {
                using (var cmd = new SqlCommand("ModificacionMarca", sql))
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


        public async Task BajaMarca(Marca parametros)
        {
            using (var sql = new SqlConnection(cn.cadenaSQL()))
            {
                using (var cmd = new SqlCommand("BajaMarca", sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idmarca", parametros.Id);
                    cmd.Parameters.AddWithValue("@baja", parametros.Baja);
                    cmd.Parameters.AddWithValue("@fechabaja", parametros.FechaBaja);
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }

            }
        }
    }
}
