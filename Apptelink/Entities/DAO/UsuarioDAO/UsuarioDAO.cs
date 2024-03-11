namespace Apptelink.Entities.DAO.UsuarioDAO
{
    public class UsuarioDAO
    {
        public int IdUsuario { get; set; }

        public string Username { get; set; } = null!;

        public string Contraseña { get; set; } = null!;

        public int? IntentosFallidos { get; set; }

        public string? Estado { get; set; }
    }
}
