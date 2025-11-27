using IFSPStore.App.Register;
using IFSPStore.App.ViewModels;
using IFSPStore.Domain.Base;
using IFSPStore.Domain.Entities;
using IFSPStore.Repository.Context;
using IFSPStore.Repository.Repository;
using IFSPStore.Service.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace IFSPStore.App.Infra;

internal static class ConfigureDI
{
    public static ServiceProvider serviceProvider;

    public static void ConfigureService()
    {
        var dbConfigFile = "Config/DbConfig.txt";
        var dbConnectionString = File.ReadAllText(dbConfigFile);

        var services = new ServiceCollection();

        services.AddDbContext<IFSPStoreDbContext>(options =>
        {
            options.LogTo(Console.WriteLine);
            options.UseNpgsql(dbConnectionString);
        });

        #region Repositories
        services.AddScoped<IBaseRepository<Category>, BaseRepository<Category>>();
        services.AddScoped<IBaseRepository<City>, BaseRepository<City>>();
        services.AddScoped<IBaseRepository<Customer>, BaseRepository<Customer>>();
        services.AddScoped<IBaseRepository<Product>, BaseRepository<Product>>();
        services.AddScoped<IBaseRepository<Sale>, BaseRepository<Sale>>();
        services.AddScoped<IBaseRepository<User>, BaseRepository<User>>();
        #endregion

        #region Services
        services.AddScoped<IBaseService<Category>, BaseService<Category>>();
        services.AddScoped<IBaseService<City>, BaseService<City>>();
        services.AddScoped<IBaseService<Customer>, BaseService<Customer>>();
        services.AddScoped<IBaseService<Product>, BaseService<Product>>();
        services.AddScoped<IBaseService<Sale>, BaseService<Sale>>();
        services.AddScoped<IBaseService<User>, BaseService<User>>();
        #endregion

        services.AddLogging();

        #region Mappers
        services.AddAutoMapper(config =>
        {
            config.CreateMap<User, UserModel>();
            config.CreateMap<Category, CategoryModel>();
            config.CreateMap<City, CityModel>()
                .ConstructUsing(src => new CityModel(
                    src.Id,
                    src.Name,
                    src.State,
                    $"{src.Name}/{src.State}"
                ));
            config.CreateMap<Customer, CustomerModel>()
                .ForMember(cm => cm.CityName, c => c.MapFrom(x => $"{x.City.Name}/{x.City.State}"))
                .ForMember(cm => cm.CityId, c => c.MapFrom(x => x.City.Id));
            config.CreateMap<Product, ProductModel>()
                .ForMember(pm => pm.GroupName, p => p.MapFrom(x => $"{x.Group.Name}"))
                .ForMember(pm => pm.GroupId, p => p.MapFrom(x => x.Group.Id));
            config.CreateMap<Sale, SaleModel>()
                .ForMember(sm => sm.SalesmanName, s => s.MapFrom(x => $"{x.Salesman.Name}"))
                .ForMember(sm => sm.SalesmanId, s => s.MapFrom(x => x.Salesman.Id))
                .ForMember(sm => sm.CustomerName, s => s.MapFrom(x => $"{x.Customer.Name}"))
                .ForMember(sm => sm.CustomerId, s => s.MapFrom(x => x.Customer.Id));
            config.CreateMap<SaleItem, SaleItemModel>()
                .ForMember(d => d.ProductId, d => d.MapFrom(x => x.Product.Id))
                .ForMember(d => d.Product, d => d.MapFrom(x => x.Product.Name));
        });
        #endregion

        #region Forms
        services.AddTransient<CategoryForm>();
        services.AddTransient<UserForm>();
        services.AddTransient<CityForm>();
        services.AddTransient<ProductForm>();
        services.AddTransient<CustomerForm>();
        services.AddTransient<SaleForm>();
        #endregion

        serviceProvider = services.BuildServiceProvider();
    }
}
