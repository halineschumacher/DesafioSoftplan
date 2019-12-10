using TaxaDeJuros.Domain;
using Microsoft.EntityFrameworkCore;

namespace TaxaDeJuros.Infra.Data
{
    public interface ITaxaDeJurosContext
    {
        DbSet<Domain.TaxaDeJuros> TaxaDeJuros { get; set; }

        int SaveChanges();
    }
}