using Microsoft.EntityFrameworkCore;
using TaxaDeJuros.Domain;

namespace TaxaDeJuros.Infra.Data
{
    public class TaxaDeJurosContext : DbContext, ITaxaDeJurosContext
    {
        public TaxaDeJurosContext(DbContextOptions<TaxaDeJurosContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TaxaDeJurosContext).Assembly);
            base.OnModelCreating(modelBuilder);
            
        }

        public DbSet<Domain.TaxaDeJuros> TaxaDeJuros { get; set; }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}