using System;
using System.Collections.Generic;

namespace Apptelink.Entities
{
    public partial class DetalleFactura
    {
        public int IdItem { get; set; }
        public int IdFactura { get; set; }
        public int IdProducto { get; set; }
        public decimal Precio { get; set; }
        public int? Cantidad { get; set; }
        public decimal? Subtotal { get; set; }

        public virtual Factura IdFacturaNavigation { get; set; } = null!;
        public virtual Producto IdProductoNavigation { get; set; } = null!;
    }
}
