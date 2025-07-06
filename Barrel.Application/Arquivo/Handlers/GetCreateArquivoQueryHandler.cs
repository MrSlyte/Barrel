using Barrel.Application.Arquivo.Queries;
using MediatR;

namespace Barrel.Application.Arquivo.Handlers
{
    internal class GetCreateArquivoQueryHandler : IRequestHandler<GetCreateArquivoQuery, string>
    {
        public Task<string> Handle(GetCreateArquivoQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult("Hello World from CQRS + MediatR!");
        }
    }
}
