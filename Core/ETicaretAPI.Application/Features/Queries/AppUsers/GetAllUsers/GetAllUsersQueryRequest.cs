﻿using MediatR;

namespace ETicaretAPI.Application.Features.Queries.AppUsers.GetAllUsers
{
    public class GetAllUsersQueryRequest:IRequest<GetAllUsersQueryResponse>
    {
        public int Page { get; set; }
        public int Size { get; set; }
    }
}