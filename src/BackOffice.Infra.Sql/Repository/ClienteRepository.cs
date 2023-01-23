using BackOffice.Domain.Interfaces.Repository;
using BackOffice.Infra.Sql.Data;

namespace BackOffice.Infra.Sql.Repository; 
public class ClienteRepository: BaseRepository, IClienteRepository 
{
	public ClienteRepository(BackOfficeContext context) : base(context)
	{

	}
}
