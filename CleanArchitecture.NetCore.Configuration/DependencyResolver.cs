using CleanArchitecture.NetCore.Infrastructure.DataSources;
using CleanArchitecture.NetCore.Infrastructure.DataSources.DB.EntityFramework;
using CleanArchitecture.NetCore.InterfaceAdapters.Gateways;
using CleanArchitecture.NetCore.InterfaceAdapters.Infrastructure;
using CleanArchitecture.NetCore.InterfaceAdapters.Repositories;
using CleanArchitecture.NetCore.UseCases.InterfaceAdapters.Repository;
using CleanArchitecture.NetCore.UseCases.Usuarios;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using System.Reflection;
using CleanArchitecture.NetCore.InterfaceAdapters.Mapping;
using CleanArchitecture.NetCore.Infrastructure.Mapping;

namespace CleanArchitecture.NetCore.Configuration
{
    public static class DependencyResolver
    {
        public static int IUsuarioUseCase { get; private set; }

        public static IServiceCollection ConfigInfrastructure(this IServiceCollection services)
        {
            services.AddAutoMapper();
            var connectionString = @"Server=(localdb)\mssqllocaldb;Database=USERSDB;Trusted_Connection=True;ConnectRetryCount=0";
            services.AddDbContext<UsuarioDbContext>(opts => opts.UseSqlServer(connectionString)); //ToDo: Pendiente enviar parametros

            services.AddTransient<IParser, Parser>();
            services.AddTransient<IUsuarioDataSource, UsuarioDataSource>();

            return services;
        }

        public static IServiceCollection ConfigInterfaceAdapters(this IServiceCollection services)
        {
            services.AddTransient<IUsuarioGateway, UsuarioGateway>();
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();

            return services;
        }

        public static IServiceCollection ConfigUseCases(this IServiceCollection services)
        {
            services.AddTransient<IUsuarioUseCases, UsuarioUseCases>();

            return services;
        }
    }
}
