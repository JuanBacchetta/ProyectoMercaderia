using Mercaderia.Conexion;
using Mercaderia.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Mercaderia.Datos
{
    public class DProducto
    {

        Conexionbd cn = new Conexionbd();
        public async Task<List<Producto>> ListadoProductos(Producto parametros)
        {
            var lista = new List<Producto>();
            using (var sql = new SqlConnection(cn.cadenaSQL()))
            {
                using (var cmd = new SqlCommand("ListadoProductos", sql))
                {
                    
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@codigoproducto", parametros.CodigoProducto); 
                    cmd.Parameters.AddWithValue("@idmarca",parametros.IdMarca);
                    cmd.Parameters.AddWithValue("@idfamilia", parametros.IdFamilia);
                    await sql.OpenAsync();
                    using (var item = await cmd.ExecuteReaderAsync())
                    {
                        while (await item.ReadAsync())
                        {
                            var producto = new Producto();
                            producto.CodigoProducto = (string)item["CodigoProducto"];
                            producto.DescripcionProducto = (string)item["DescripcionProducto"];
                            producto.PrecioCosto = (decimal)item["PrecioCosto"];
                            producto.PrecioVenta = (decimal)item["PrecioVenta"];
                            producto.IdMarca = (int)item["IdMarca"];
                            producto.IdFamilia = (int)item["IdFamilia"];
                            producto.FechaModificacion = (DateTime)item["FechaModificacion"];
                            producto.Baja = (bool)item["Baja"];
                            producto.FechaBaja = (DateTime)item["FechaBaja"];
                            lista.Add(producto);



                        }
                    }
                }
            }
            return lista;
        }
        
        
        public async Task AltaProducto(Producto parametros)
        {
            using (var sql = new SqlConnection(cn.cadenaSQL()))
            {
                using (var cmd = new SqlCommand("AltaProducto",sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoproducto", parametros.CodigoProducto);
                    cmd.Parameters.AddWithValue("@descripcionproducto", parametros.DescripcionProducto);
                    cmd.Parameters.AddWithValue("@preciocosto", parametros.PrecioCosto);
                    cmd.Parameters.AddWithValue("@precioventa", parametros.PrecioVenta);
                    cmd.Parameters.AddWithValue("@idmarca", parametros.IdMarca);
                    cmd.Parameters.AddWithValue("@idfamilia", parametros.IdFamilia);
                    cmd.Parameters.AddWithValue("@fechamodificacion", parametros.FechaModificacion);
                    cmd.Parameters.AddWithValue("@baja", parametros.Baja);
                    cmd.Parameters.AddWithValue("@fechabaja", parametros.FechaBaja);
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }

            }
        }


        public async Task ModificacionProducto(Producto parametros)
        {
            using (var sql = new SqlConnection(cn.cadenaSQL()))
            {
                using (var cmd = new SqlCommand("ModificacionProducto", sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoproducto", parametros.CodigoProducto);
                    cmd.Parameters.AddWithValue("@descripcionproducto", parametros.DescripcionProducto);
                    cmd.Parameters.AddWithValue("@preciocosto", parametros.PrecioCosto);
                    cmd.Parameters.AddWithValue("@precioventa", parametros.PrecioVenta);
                    cmd.Parameters.AddWithValue("@idmarca", parametros.IdMarca);
                    cmd.Parameters.AddWithValue("@idfamilia", parametros.IdFamilia);
                    cmd.Parameters.AddWithValue("@fechamodificacion", parametros.FechaModificacion);
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }

            }
        }

        public async Task BajaProducto(Producto parametros)
        {
            using (var sql = new SqlConnection(cn.cadenaSQL()))
            {
                using (var cmd = new SqlCommand("BajaProducto", sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@codigoproducto", parametros.CodigoProducto);
                    cmd.Parameters.AddWithValue("@baja", parametros.Baja);
                    cmd.Parameters.AddWithValue("@fechabaja", parametros.FechaBaja);
                    await sql.OpenAsync();
                    await cmd.ExecuteNonQueryAsync();
                }

            }
        }


    }
}
