using CleanArchitecture.NetCore.Domain;
using CleanArchitecture.NetCore.Infrastructure.DataSources.DB.EntityFramework;
using CleanArchitecture.NetCore.Infrastructure.DataSources.DB.EntityFramework.Model;
using CleanArchitecture.NetCore.InterfaceAdapters.Infrastructure;
using CleanArchitecture.NetCore.InterfaceAdapters.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.NetCore.Infrastructure.DataSources
{
    public class UsuarioDataSource : IUsuarioDataSource
    {
        private readonly UsuarioDbContext _dbContext;
        private readonly IParser _parser;

        public UsuarioDataSource(UsuarioDbContext dbContext, IParser parser)
        {
            _dbContext = dbContext;
            _parser = parser;
        }
        public bool CrearUsuario(Usuario usuario)
        {
            var result = false;
            var entity = _parser.Parse<UsuarioEntity, Usuario>(usuario);

            _dbContext.Usuarios.Add(entity);
            result = _dbContext.SaveChanges() == 1;

            return result;
        }
    }
}
