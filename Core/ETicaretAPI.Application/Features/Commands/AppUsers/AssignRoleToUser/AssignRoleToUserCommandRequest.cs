﻿using MediatR;

namespace ETicaretAPI.Application.Features.Commands.AppUsers.AssignRoleToUser
{
    public class AssignRoleToUserCommandRequest:IRequest<AssignRoleToUserCommandResponse>
    {
        public string UserId { get; set; }
        public string[] Roles { get; set; }
    }
}