using BackOffice.Domain.Entities;
using BackOffice.Domain.Interfaces.Repository;
using BackOffice.Infra.Sql.Data;
using Microsoft.Extensions.Logging;

namespace BackOffice.Infra.Sql.Repository; 
public class ClienteRepository: BaseRepository<ClienteModel>, IClienteRepository
{
	public ClienteRepository(BackOfficeContext context, ILogger<ClienteRepository> logger) : base(context, logger)
	{

	}
}
