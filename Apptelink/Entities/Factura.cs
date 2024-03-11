using System;
using System.Collections.Generic;

namespace Apptelink.Entities
{
    public partial class Factura
    {
        public Factura()
        {
            DetalleFacturas = new HashSet<DetalleFactura>();
        }

        public int IdFactura { get; set; }
        public int NumeroFactura { get; set; }
        public int IdCliente { get; set; }
        public decimal? Subtotal { get; set; }
        public decimal? PorcentajeIgv { get; set; }
        public decimal? Igv { get; set; }
        public decimal? Total { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; } = null!;
        public virtual ICollection<DetalleFactura> DetalleFacturas { get; set; }
    }
}
