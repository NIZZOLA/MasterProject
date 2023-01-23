using BackOffice.Domain.Interfaces.Repository;
using BackOffice.Infra.Sql.Data;

namespace BackOffice.Infra.Sql.Repository;

public class BaseRepository: IBaseRepository
{
    internal BackOfficeContext _context;
	public BaseRepository(BackOfficeContext context)
	{
		_context = context;
	}
}
