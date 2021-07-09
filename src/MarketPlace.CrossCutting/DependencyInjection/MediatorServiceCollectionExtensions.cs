using System;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace MarketPlace.CrossCutting.DependencyInjection
{
    public static class MediatorServiceCollectionExtensions
    {
        public static IServiceCollection AddMediator(this IServiceCollection services)
        {
            var assembly = AppDomain.CurrentDomain.Load("MarketPlace.Application");
            services.AddMediatR(assembly);
            return services;
        }
    }
}