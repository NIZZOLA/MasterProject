using BackOffice.Domain.Interfaces.Repository;
using BackOffice.Infra.Sql.Data;

namespace BackOffice.Infra.Sql.Repository;

public class ProdutoRepository: BaseRepository, IProdutoRepository
{
	public ProdutoRepository(BackOfficeContext context) : base(context)
    {

    }
}
