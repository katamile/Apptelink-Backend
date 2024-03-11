namespace Apptelink.Entities.DAO.FacturaDAO
{
    public class FacturaSaveDAO
    {
        public int IdFactura { get; set; }
        public string NumeroFactura { get; set; } = null!;
        public int IdCliente { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? PorcentajeIgv { get; set; }
        public decimal? Igv { get; set; }
        public decimal? Total { get; set; }
    }
}
