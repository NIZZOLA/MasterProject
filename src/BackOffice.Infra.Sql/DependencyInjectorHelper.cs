using BackOffice.Infra.Sql.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BackOffice.Infra.Sql;

public static class DependencyInjectorHelper
{
    public static void AddInfraSql(this IServiceCollection services, IConfiguration configuration)
    {
        //https://codebuckets.com/2020/05/29/dynamically-loading-assemblies-for-dependency-injection-in-net-core/


        services.AddDbContext<BackOfficeContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("PedidosBackOffice")));

    }
}
