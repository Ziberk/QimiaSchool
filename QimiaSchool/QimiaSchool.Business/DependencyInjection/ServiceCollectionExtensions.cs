using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using AutoMapper;
using QimiaSchool.Business.Abstractions;
using QimiaSchool.Business.Implementations;
using System.Reflection;


namespace QimiaSchool.Business.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {

        public static IServiceCollection AddBussinessLayer(this IServiceCollection serviceCollection)
        {
            AddMediatRHandlers(serviceCollection);
            AddMediatRHandlers(serviceCollection);
            AddManagers(serviceCollection);
            AddAutoMapper(serviceCollection);

            return serviceCollection;
        }
        private static void AddMediatRHandlers(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        }

        private static void AddManagers(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddScoped<IStudentManager, StudentManager>();
        }

        private static void AddAutoMapper(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddAutoMapper(Assembly.GetExecutingAssembly());
        }


    }
}
