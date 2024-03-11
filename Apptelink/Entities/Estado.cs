using System;
using System.Collections.Generic;

namespace Apptelink.Entities
{
    public partial class Estado
    {
        public int IdEstado { get; set; }
        public string NombreEstado { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
    }
}
