using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.NetCore.Domain;
using CleanArchitecture.NetCore.UseCases.InterfaceAdapters.Repository;

namespace CleanArchitecture.NetCore.UseCases.Usuarios
{
    public class UsuarioUseCases : IUsuarioUseCases
    {
        private readonly IUsuarioRepository _repository;

        public UsuarioUseCases(IUsuarioRepository repository)
        {
            _repository = repository;
        }

        public bool CrearUsuario(Usuario usuario)
        {
            return _repository.CrearUsuario(usuario);
        }
    }
}
