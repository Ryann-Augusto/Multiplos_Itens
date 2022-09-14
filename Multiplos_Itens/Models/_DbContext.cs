using Microsoft.EntityFrameworkCore;
using Multiplos_Itens.Models;

namespace Multiplos_Itens.Models
{
    public class _DbContext : DbContext
    {
        public _DbContext(DbContextOptions<_DbContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        }

        public DbSet<Produtos> Produtos { get; set; }

        public DbSet<Multiplos_Itens.Models.Fornecedor>? Fornecedor { get; set; }
    }
}
