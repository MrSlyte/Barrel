namespace Barrel.Domain
{
    public class Arquivo(string nome, string tipo, string referencia, string usuarioId)
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Nome { get; private set; } = nome;
        public string Tipo { get; private set; } = tipo;
        public string Referencia { get; private set; } = referencia;
        public string UsuarioId { get; private set; } = usuarioId;
        public DateTime CriadoEm { get; private set; } = DateTime.UtcNow;
    }
}
