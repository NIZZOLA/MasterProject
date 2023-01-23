using BackOffice.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BackOffice.Infra.Sql.EntityConfig; 
public class PedidoEntityConfiguration : BaseEntityConfiguration<PedidoModel>
{
	public PedidoEntityConfiguration(EntityTypeBuilder<PedidoModel> builder)
    {
		base.ConfigureBase(builder);
		builder.ToTable("Pedidos");
	}
}
