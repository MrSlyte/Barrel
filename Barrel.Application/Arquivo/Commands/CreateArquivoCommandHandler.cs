using Barrel.Domain;
using Barrel.Infrastructure.Messaging;
using Barrel.Infrastructure.Repositories;
using MediatR;

namespace Barrel.Application.Arquivo.Commands
{
    public class CreateArquivoCommandHandler(IArquivoRepository repo, IMessageBus bus) : IRequestHandler<CreateArquivoCommand, Guid>
    {
        private readonly IArquivoRepository _repo = repo;
        private readonly IMessageBus _bus = bus;

        public async Task<Guid> Handle(CreateArquivoCommand request, CancellationToken cancellationToken)
        {
            var arquivo = new Domain.Arquivo(request.Nome, request.Tipo, request.Referencia, request.UsuarioId);
            await _repo.AddAsync(arquivo);

            await _bus.PublishAsync("arquivo.criado", new { arquivo.Id, arquivo.Nome });

            return arquivo.Id;
        }
    }
}
