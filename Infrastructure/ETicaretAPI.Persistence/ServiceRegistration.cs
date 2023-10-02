﻿using Microsoft.EntityFrameworkCore;
using ETicaretAPI.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaretAPI.Application.Repositories.ProductRepos;
using ETicaretAPI.Persistence.Repositories.ProductRepos;
using ETicaretAPI.Application.Repositories.CustomerRepos;
using ETicaretAPI.Persistence.Repositories.CustomerRepos;
using ETicaretAPI.Application.Repositories.OrderRepos;
using ETicaretAPI.Persistence.Repositories.OrderRepos;
using ETicaretAPI.Application.Repositories.ProductImageFileRepos;
using ETicaretAPI.Persistence.Repositories.ProductImageFileRepos;
using ETicaretAPI.Application.Repositories.InvoiceFileRepos;
using ETicaretAPI.Persistence.Repositories.InvoiceFileRepos;
using ETicaretAPI.Application.Repositories.FileRepos;
using ETicaretAPI.Persistence.Repositories.FileRepos;

namespace ETicaretAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<ETicaretAPIDbContext>(options=>options.UseNpgsql(Configuration.ConnectionString));
            services.AddScoped<ICustomerReadRepository,CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository,CustomerWriteRepository>();
            services.AddScoped<IOrderReadRepository,OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository,OrderWriteRepository>();
            services.AddScoped<IProductReadRepository,ProductReadRepository>();
            services.AddScoped<IProductWriteRepository,ProductWriteRepository>();
            services.AddScoped<IProductImageFileReadRepository,ProductImageFileReadRepository>();
            services.AddScoped<IProductImageFileWriteRepository,ProductImageFileWriteRepository>();
            services.AddScoped<IInvoiceFileWriteRepository,InvoiceFileWriteRepository>();
            services.AddScoped<IInvoiceFileReadRepository,InvoiceFileReadRepository>();
            services.AddScoped<IFileReadRepository,FileReadRepository>();
            services.AddScoped<IFileWriteRepository,FileWriteRepository>();
        }
    }
}