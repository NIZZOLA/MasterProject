using BackOffice.Domain.Entities;
using BackOffice.Domain.Interfaces.Repository;
using BackOffice.Infra.Sql.Data;
using Microsoft.Extensions.Logging;

namespace BackOffice.Infra.Sql.Repository; 
public class PagamentoRepository: BaseRepository<PagamentoModel>, IPagamentoRepository 
{
    private readonly ILogger _logger;
	public PagamentoRepository(BackOfficeContext context, ILogger<PagamentoRepository> logger) : base(context, logger)
    {
        _logger= logger;
    }
}
