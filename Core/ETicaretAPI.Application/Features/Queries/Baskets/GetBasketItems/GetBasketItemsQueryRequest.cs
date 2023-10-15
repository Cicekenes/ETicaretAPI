using MediatR;

namespace ETicaretAPI.Application.Features.Queries.Baskets.GetBasketItems
{
    public class GetBasketItemsQueryRequest : IRequest<List<GetBasketItemsQueryResponse>>
    {
    }
}