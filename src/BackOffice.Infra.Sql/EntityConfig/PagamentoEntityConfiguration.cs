using BackOffice.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BackOffice.Infra.Sql.EntityConfig;
public class PagamentoEntityConfiguration: BaseEntityConfiguration<PagamentoModel>
{
    public PagamentoEntityConfiguration(EntityTypeBuilder<PagamentoModel> builder)
    {
        base.ConfigureBase(builder);
        builder.ToTable("Pagamentos");
        //builder
        //    .Property(b => b.Descricao)
        //    .HasMaxLength(60)
        //    .IsRequired();

    }
}
