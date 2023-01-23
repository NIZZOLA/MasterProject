
using BackOffice.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BackOffice.Infra.Sql.EntityConfig;

public class ProdutoEntityConfiguration: BaseEntityConfiguration<ProdutoModel>
{
	public ProdutoEntityConfiguration(EntityTypeBuilder<ProdutoModel> builder)
    {
        builder.ToTable("Produtos");
        base.ConfigureBase(builder);
        builder
            .Property(b => b.Descricao)
            .HasMaxLength(60)
            .IsRequired();

    }
}
