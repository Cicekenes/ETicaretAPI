using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Features.Queries.Roles.GetRoles
{
    public class GetRolesQueryResponse
    {
        public object Datas { get; set; }
        public int TotalRoleCount { get; set; }
    }
}
