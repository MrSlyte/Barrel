using Barrel.Domain;
using Microsoft.EntityFrameworkCore;

namespace Barrel.Infrastructure.Data
{
    public class ArquivoDbContext(DbContextOptions<ArquivoDbContext> options) : DbContext(options)
    {
        public DbSet<Arquivo> Arquivos => Set<Arquivo>();
    }
}
