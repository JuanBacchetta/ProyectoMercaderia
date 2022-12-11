namespace Mercaderia.Entities
{
    public class Familia
    {
        //Propiedades en las tablas de SQL SERVER
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaModificacion { get; set; }
        public bool Baja { get; set; }
        public DateTime? FechaBaja { get; set; }
    }
}
