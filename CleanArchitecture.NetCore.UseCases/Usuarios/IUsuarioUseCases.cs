using System;
using System.Collections.Generic;
using System.Text;
using CleanArchitecture.NetCore.Domain;

namespace CleanArchitecture.NetCore.UseCases.Usuarios
{
    public interface IUsuarioUseCases
    {
        bool CrearUsuario(Usuario usuario);
    }
}
