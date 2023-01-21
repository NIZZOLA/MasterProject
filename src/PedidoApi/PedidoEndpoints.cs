using BackOffice.Domain.Entities;
using BackOffice.Domain.Interfaces.Repository;
using BackOffice.Infra.Sql.Data;
using BackOffice.WebApi.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace PedidoApi;

public static class PedidoEndpoints
{
    public static void MapPedidosEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/Pedidos").WithTags("Pedidos");

        group.MapPost("/", async (PedidoRequestModel request, [FromServices] QueueService service) =>
        {
            request.RequestId = Guid.NewGuid();
            service.Publish(request);

            return TypedResults.Created($"/api/PedidoModel/{request.RequestId}", request);
        })
            .WithName("CreatePedidoModel");

        group.MapGet("/", async (BackOfficeContext pedidoRepository) =>
        {
            return pedidoRepository.Pedidos.ToList();
        })
            .WithName("GetPedidos");
    }


}
