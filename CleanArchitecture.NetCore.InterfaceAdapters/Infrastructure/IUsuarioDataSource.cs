using CleanArchitecture.NetCore.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.NetCore.InterfaceAdapters.Infrastructure
{
    public interface IUsuarioDataSource
    {
        bool CrearUsuario(Usuario usuario);
    }
}
