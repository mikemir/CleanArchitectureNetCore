using CleanArchitecture.NetCore.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.NetCore.UseCases.InterfaceAdapters.Repository
{
    public interface IUsuarioRepository
    {
        bool CrearUsuario(Usuario usuario);
    }
}
