using CleanArchitecture.NetCore.Dtos;
using CleanArchitecture.NetCore.Dtos.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.NetCore.InterfaceAdapters.Gateways
{
    public interface IUsuarioGateway
    {
        ResponseMessage CrearUsuario(UsuarioDto dto);
    }
}
