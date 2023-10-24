using MediatR;

namespace ETicaretAPI.Application.Features.Commands.Products.UpdateStockQrCodeToProduct
{
    public class UpdateStockQrCodeToProductCommandRequest:IRequest<UpdateStockQrCodeToProductCommandResponse>
    {
        public string ProductId { get; set; }
        public int Stock { get; set; }
    }
}