using Barrel.Domain;

namespace Barrel.Infrastructure.Repositories
{
    public interface IArquivoRepository
    {
        Task AddAsync(Arquivo arquivo);
    }
}
