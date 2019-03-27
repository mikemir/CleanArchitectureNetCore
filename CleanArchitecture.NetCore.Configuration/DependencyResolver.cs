using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.NetCore.Configuration
{
    public static class DependencyResolver
    {
        public static IServiceCollection ConfigInterfaceAdapters(this IServiceCollection services)
        {
            return services;
        }

        public static IServiceCollection ConfigUseCases(this IServiceCollection services)
        {
            return services;
        }
    }
}
