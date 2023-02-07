using BackOffice.Infra.Sql.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Data;

namespace BackOffice.Infra.Sql.Repository;

public class BaseRepository<T> where T: class
{
    internal BackOfficeContext _context;
    protected readonly IDbConnection _connection;
    private readonly ILogger _logger;
    
    public BaseRepository(BackOfficeContext context, ILogger<BaseRepository<T>> logger)
	{
		_context = context;
        _logger= logger;
	}
    public async Task<IEnumerable<T>> GetAll()
    {
        try
        {
            return await _context.Set<T>().ToListAsync();
        }
        catch (Exception err)
        {
            // utilizado apenas para debugar as falhas durante processo de mapeamento, remover assim que validado EF
            throw;
        }
    }

    public virtual async Task<bool> SaveChanges()
    {
        try
        {
            await this._context.SaveChangesAsync();
            //return Result.Ok();
            return true;
        }
        catch (DbUpdateException ex)
        {
            //return Result.Fail(ex.Message.ToString());
            return false;
        }
    }

    public async Task Delete(T model)
    {
        _context.Set<T>().Remove(model);
    }

    public virtual async Task Create(T model)
    {
        await this._context.Set<T>().AddAsync(model);
    }

    public virtual Task Update(T model)
    {
        this._context.Entry(model).State = EntityState.Modified;
        return Task.CompletedTask;
    }
    /*
    protected async Task<TProject> QueryOne<TProject>(string sqlCommand, object parameters = null)
    {
        return await _connection.QuerySingleOrDefaultAsync<TProject>(sqlCommand, parameters);
    }

    protected async Task<IEnumerable<TProject>> QueryMany<TProject>(string sqlCommand, object parameters = null)
    {
        return await _connection.QueryAsync<TProject>(sqlCommand, parameters);
    }
    protected async Task<int> ExecuteEscalar(string sqlCommand, object parameters = null)
    {
        return await _connection.ExecuteScalarAsync<int>(sqlCommand, parameters);
    }
    
    */
}
