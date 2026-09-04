using CleanArch.Application.Orders;
using CleanArch.Application.Products;
using CleanArch.Contracts;
using CleanArch.Domain.Orders.Repository;
using CleanArch.Domain.Products.Repository;
using CleanArch.Infrastructure;
using CleanArch.Infrastructure.Persistent.Memory;
using CleanArch.Infrastructure.Persistent.Memory.Orders;
using CleanArch.Infrastructure.Persistent.Memory.Products;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.Config;

public class ProjectBootstrapper
{
    public static void Init(IServiceCollection services)
    {
        services.AddTransient<IOrderService, OrderService>();   
        services.AddTransient<IProductService, ProductService>();
        
        services.AddTransient<IOrderRepository, OrderRepository>();
        services.AddTransient<IProductRepository, ProductRepository>();

        services.AddScoped<ISmsService, SmsService>();

        services.AddSingleton<Context>();
    }
}