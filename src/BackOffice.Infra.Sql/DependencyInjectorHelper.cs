using BackOffice.Infra.Sql.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using BackOffice.Toolkit.Extensions;

namespace BackOffice.Infra.Sql;

public static class DependencyInjectorHelper
{
    public static void AddInfraSql(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<BackOfficeContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("PedidosBackOffice")), ServiceLifetime.Transient);

        services.ScanDependencyInjection(Assembly.GetExecutingAssembly(), "Repository");
    }
}
