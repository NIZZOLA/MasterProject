using System.ComponentModel.DataAnnotations.Schema;

namespace BackOffice.Domain.Entities;

public class PedidoModel : BaseModel
{
    public Guid? RequestId { get; set; }
    public DateTime DataDaCompra { get; set; }
    public PedidoStatusEnum Status { get; set; }

    [ForeignKey("Cliente")]
    public int ClienteId { get; set; }
    public ClienteModel Cliente { get; set; }
    public ICollection<PedidoItemModel>? Itens { get; set; }
    public ICollection<PagamentoModel>? Pagamentos { get; set; }
}