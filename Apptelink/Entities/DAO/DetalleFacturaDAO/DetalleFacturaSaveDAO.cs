namespace Apptelink.Entities.DAO.DetalleFacturaDAO
{
    public class DetalleFacturaSaveDAO
    {
        public int IdItem { get; set; }
        public int IdFactura { get; set; }
        public int IdProducto { get; set; }
        public decimal Precio { get; set; }
        public int? Cantidad { get; set; }
        public decimal? Subtotal { get; set; }
    }
}
