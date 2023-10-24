using ETicaretAPI.Application.Abstractions.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Features.Commands.Products.UpdateStockQrCodeToProduct
{
    public class UpdateStockQrCodeToProductCommandHandler : IRequestHandler<UpdateStockQrCodeToProductCommandRequest, UpdateStockQrCodeToProductCommandResponse>
    {
        private readonly IProductService _productService;

        public UpdateStockQrCodeToProductCommandHandler(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<UpdateStockQrCodeToProductCommandResponse> Handle(UpdateStockQrCodeToProductCommandRequest request, CancellationToken cancellationToken)
        {
            await _productService.StockUpdateToProductAsync(request.ProductId, request.Stock);
            return new UpdateStockQrCodeToProductCommandResponse();
        }
    }
}
