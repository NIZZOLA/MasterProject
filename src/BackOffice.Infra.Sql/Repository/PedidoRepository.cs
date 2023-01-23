using BackOffice.Domain.Interfaces.Repository;
using BackOffice.Infra.Sql.Data;

namespace BackOffice.Infra.Sql.Repository; 
public class PedidoRepository: BaseRepository, IPedidoRepository 
{
	public PedidoRepository(BackOfficeContext context) : base(context)
    {

    }
}
