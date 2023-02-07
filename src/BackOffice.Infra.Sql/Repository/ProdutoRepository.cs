using BackOffice.Domain.Entities;
using BackOffice.Domain.Interfaces.Repository;
using BackOffice.Infra.Sql.Data;
using Microsoft.Extensions.Logging;

namespace BackOffice.Infra.Sql.Repository;

public class ProdutoRepository: BaseRepository<ProdutoModel>, IProdutoRepository
{
    private readonly ILogger _logger;
    public ProdutoRepository(BackOfficeContext context, ILogger<ProdutoRepository> logger) : base(context, logger)
    {
        _logger = logger;
    }
}
