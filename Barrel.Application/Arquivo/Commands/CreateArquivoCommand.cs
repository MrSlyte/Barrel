using MediatR;

namespace Barrel.Application.Arquivo.Commands
{
    public record CreateArquivoCommand(string Nome, string Tipo, string Referencia, string UsuarioId) : IRequest<Guid>;
}