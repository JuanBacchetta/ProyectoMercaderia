namespace Mercaderia.Conexion
{
    public class Conexionbd
    {
        private string connectionString = string.Empty;
        public Conexionbd()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            connectionString = builder.GetSection("ConnectionStrings:ConexionMaestra").Value;
        }
        public string cadenaSQL()
        {
            return connectionString;
        }

        
    }
}
