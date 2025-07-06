using Barrel.Domain;
using Barrel.Infrastructure.Data;

namespace Barrel.Infrastructure.Repositories
{
    public class ArquivoRepository(ArquivoDbContext context) : IArquivoRepository
    {
        private readonly ArquivoDbContext _context = context;

        public async Task AddAsync(Arquivo arquivo)
        {
            _context.Arquivos.Add(arquivo);
            await _context.SaveChangesAsync();
        }
    }
}
