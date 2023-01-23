using BackOffice.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BackOffice.Infra.Sql.EntityConfig; 
public class PedidoItemEntityConfiguration : BaseEntityConfiguration<PedidoItemModel>
{
	public PedidoItemEntityConfiguration(EntityTypeBuilder<PedidoItemModel> builder)
	{
		base.ConfigureBase(builder);
		builder.ToTable("PedidoItens");
	}
}
