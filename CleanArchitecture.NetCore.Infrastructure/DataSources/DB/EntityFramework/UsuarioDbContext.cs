using CleanArchitecture.NetCore.Infrastructure.DataSources.DB.EntityFramework.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.NetCore.Infrastructure.DataSources.DB.EntityFramework
{
    public class UsuarioDbContext : DbContext
    {
        public UsuarioDbContext()
        {

        }

        public UsuarioDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<UsuarioEntity> Usuarios { get; set; }
    }
}
