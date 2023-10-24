using MediatR;

namespace ETicaretAPI.Application.Features.Queries.AppUsers.GetRolesToUser
{
    public class GetRolesToUserQueryRequest:IRequest<GetRolesToUserQueryResponse>
    {
        public string UserId { get; set; }
    }
}