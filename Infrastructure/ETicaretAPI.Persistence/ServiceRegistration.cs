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
using ETicaretAPI.Domain.Entities.Identity;
using ETicaretAPI.Application.Abstractions.Services;
using ETicaretAPI.Persistence.Services;
using ETicaretAPI.Application.Abstractions.Services.Authentications;
using ETicaretAPI.Application.Repositories.BasketItemRepos;
using ETicaretAPI.Persistence.Repositories.BasketItemRepos;
using ETicaretAPI.Application.Repositories.BasketRepos;
using ETicaretAPI.Persistence.Repositories.BasketRepos;
using Microsoft.AspNetCore.Identity;
using ETicaretAPI.Application.Repositories.CompletedOrdersRepos;
using ETicaretAPI.Persistence.Repositories.CompletedOrderRepos;
using ETicaretAPI.Application.Repositories.EndpointRepos;
using ETicaretAPI.Persistence.Repositories.EndpointRepos;
using ETicaretAPI.Application.Repositories.MenuRepos;
using ETicaretAPI.Persistence.Repositories.MenuRepos;

namespace ETicaretAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<ETicaretAPIDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));
            services.AddIdentity<AppUser, AppRole>(options =>
            {
                options.Password.RequiredLength = 3;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireUppercase = false;

            }).AddEntityFrameworkStores<ETicaretAPIDbContext>()
            .AddDefaultTokenProviders();


            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
            services.AddScoped<IProductImageFileReadRepository, ProductImageFileReadRepository>();
            services.AddScoped<IProductImageFileWriteRepository, ProductImageFileWriteRepository>();
            services.AddScoped<IInvoiceFileWriteRepository, InvoiceFileWriteRepository>();
            services.AddScoped<IInvoiceFileReadRepository, InvoiceFileReadRepository>();
            services.AddScoped<IFileReadRepository, FileReadRepository>();
            services.AddScoped<IFileWriteRepository, FileWriteRepository>();
            services.AddScoped<ICompletedOrderReadRepository, CompletedOrderReadRepository>();
            services.AddScoped<ICompletedOrderWriteRepository, CompletedOrderWriteRepository>();
            services.AddScoped<IEndpointReadRepository, EndpointReadRepository>();
            services.AddScoped<IEndpointWriteRepository, EndpointWriteRepository>();
            services.AddScoped<IMenuReadRepository, MenuReadRepository>();
            services.AddScoped<IMenuWriteRepository, MenuWriteRepository>();

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IBasketService, BasketService>();
            services.AddScoped<IExternalAuthentication, AuthService>();
            services.AddScoped<IInternalAuthentication, AuthService>();
            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IRoleService, RoleService>();
            services.AddScoped<IAuthorizationEndpointService, AuthorizationEndpointService>();
            services.AddScoped<IProductService, ProductService>();

            services.AddScoped<IBasketItemReadRepository, BasketItemReadRepository>();
            services.AddScoped<IBasketItemWriteRepository, BasketItemWriteRepository>();
            services.AddScoped<IBasketReadRepository, BasketReadRepository>();
            services.AddScoped<IBasketWriteRepository, BasketWriteRepository>();
        }
    }
}
