using CleanArchitecture.NetCore.Dtos;
using CleanArchitecture.NetCore.Dtos.Response;
using CleanArchitecture.NetCore.UseCases.Usuario;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.NetCore.InterfaceAdapters.Gateways
{
    public class UsuarioGateway : IUsuarioGateway
    {
        public UsuarioGateway()
        {
        }

        public ResponseMessage CrearUsuario(UsuarioDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
