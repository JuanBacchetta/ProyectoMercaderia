namespace Mercaderia.Entities
{
    public class Producto
    {

        //Propiedades en las tablas de SQL SERVER
        public string CodigoProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public decimal PrecioCosto { get; set; }
        public decimal PrecioVenta { get; set; }
        public int IdMarca { get; set; }
        public int IdFamilia { get; set; }
        public DateTime FechaModificacion { get; set; }
        public bool Baja { get; set; }
        public DateTime? FechaBaja { get; set; }
    }
}
