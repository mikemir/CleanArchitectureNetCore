using CleanArchitecture.NetCore.Domain;
using CleanArchitecture.NetCore.Dtos;
using CleanArchitecture.NetCore.Dtos.Response;
using CleanArchitecture.NetCore.UseCases.Usuarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.NetCore.InterfaceAdapters.Gateways
{
    public class UsuarioGateway : IUsuarioGateway
    {
        private readonly IUsuarioUseCases _useCases;

        public UsuarioGateway(IUsuarioUseCases useCases)
        {
            _useCases = useCases;
        }

        public ResponseMessage CrearUsuario(UsuarioDto dto)
        {
            //ToDo: Implementar Interface Parse
            var domain = new Usuario { Alias = dto.Alias, Clave = dto.Clave };
            var result = _useCases.CrearUsuario(domain);

            return new ResponseMessage(result, "Creado con éxito"); //ToDo: Implementar el devolver el obj insertado
        }
    }
}
