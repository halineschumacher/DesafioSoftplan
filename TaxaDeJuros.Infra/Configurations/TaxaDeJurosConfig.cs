using System.Collections.Immutable;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TaxaDeJuros.Infra.Configurations
{
    public class TaxaDeJurosConfig : IEntityTypeConfiguration<Domain.TaxaDeJuros>
    {
        public void Configure(EntityTypeBuilder<Domain.TaxaDeJuros> builder)
        {
            builder.HasKey(k => k.Id);
            builder.Property(p => p.Valor);
        }
    }
}