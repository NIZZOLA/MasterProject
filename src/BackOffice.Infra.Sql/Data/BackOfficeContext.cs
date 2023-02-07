using Microsoft.EntityFrameworkCore;

namespace BackOffice.Infra.Sql.Data;

public class BackOfficeContext : DbContext
{
    public BackOfficeContext (DbContextOptions<BackOfficeContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        var assembly = typeof(BackOfficeContext).Assembly;
        modelBuilder.ApplyConfigurationsFromAssembly(assembly);
    }

    public DbSet<BackOffice.Domain.Entities.ClienteModel> Clientes { get; set; } = default!;
    public DbSet<BackOffice.Domain.Entities.PedidoModel> Pedidos { get; set; } = default!;
    public DbSet<BackOffice.Domain.Entities.PedidoItemModel> PedidoItens { get; set; } = default!;
    public DbSet<BackOffice.Domain.Entities.PagamentoModel> Pagamentos { get; set; } = default!;
    public DbSet<BackOffice.Domain.Entities.ProdutoModel> Produtos { get; set; } = default!;
}
