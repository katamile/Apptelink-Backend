namespace Apptelink.Entities.DAO.ProductoDAO
{
    public class ProductoDAO
    {
        public int IdProducto { get; set; }

        public string Codigo { get; set; } = null!;

        public string Nombre { get; set; } = null!;

        public decimal Precio { get; set; }

        public int Stock { get; set; }

        public string? Estado { get; set; }

        public DateTime? FechaCreacion { get; set; }
    }
}
