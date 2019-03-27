using CleanArchitecture.NetCore.Domain;
using CleanArchitecture.NetCore.InterfaceAdapters.Infrastructure;
using CleanArchitecture.NetCore.UseCases.InterfaceAdapters.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.NetCore.InterfaceAdapters.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly IUsuarioDataSource _dataSource;

        public UsuarioRepository(IUsuarioDataSource dataSource)
        {
            _dataSource = dataSource;
        }

        public bool CrearUsuario(Usuario usuario)
        {
            return _dataSource.CrearUsuario(usuario);
        }
    }
}
