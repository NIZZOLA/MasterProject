using BackOffice.Domain.Entities;
using BackOffice.Domain.Interfaces.Repository;
using BackOffice.Infra.Sql.Data;
using Microsoft.Extensions.Logging;

namespace BackOffice.Infra.Sql.Repository; 
public class PedidoRepository: BaseRepository<PedidoModel>, IPedidoRepository 
{
    private readonly ILogger _logger;
    public PedidoRepository(BackOfficeContext context, ILogger<PedidoRepository> logger) : base(context, logger)
    {
        _logger= logger;
    }
}
