using Apptelink.Utils;
using System.ComponentModel.DataAnnotations;

namespace Apptelink.Entities.DAO.ClienteDAO
{
    public class ClienteDAO
    {
        public int IdCliente { get; set; }

        public string Identificacion { get; set; } = null!;

        public string Nombre { get; set; } = null!;

        public string Apellido { get; set; } = null!;

        public string? Direccion { get; set; }

        public string? Correo { get; set; }

        public string Estado { get; set; } = null!;

        public DateTime FechaCreacion { get; set; }

    }
}
