﻿using ETicaretAPI.Application.Repositories.CompletedOrdersRepos;
using ETicaretAPI.Domain.Entities;
using ETicaretAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Persistence.Repositories.CompletedOrderRepos
{
    public class CompletedOrderWriteRepository : WriteRepository<CompletedOrder>, ICompletedOrderWriteRepository
    {
        public CompletedOrderWriteRepository(ETicaretAPIDbContext context) : base(context)
        {
        }
    }
}
