using DataAccess.Library.EntityFramework;
using MarketPlace.Domain.Entities;
using MarketPlace.Infraestructure.Context;
using MarketPlace.Infraestructure.UnitOfWork;
using Microsoft.Extensions.DependencyInjection;

namespace MarketPlace.CrossCutting.DependencyInjection
{
    public static class RepositoriesServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient<IRepository<Customer, MarketPlaceContext>, Repository<Customer, MarketPlaceContext>>();
            services.AddTransient<IRepository<Establishment, MarketPlaceContext>, Repository<Establishment, MarketPlaceContext>>();
            services.AddTransient<IRepository<EstablishmentCategory, MarketPlaceContext>, Repository<EstablishmentCategory, MarketPlaceContext>>();
            services.AddTransient<IRepository<Merchant, MarketPlaceContext>, Repository<Merchant, MarketPlaceContext>>();
            services.AddTransient<IRepository<Product, MarketPlaceContext>, Repository<Product, MarketPlaceContext>>();
            services.AddTransient<IRepository<Rating, MarketPlaceContext>, Repository<Rating, MarketPlaceContext>>();

            return services;
        }
    }
}