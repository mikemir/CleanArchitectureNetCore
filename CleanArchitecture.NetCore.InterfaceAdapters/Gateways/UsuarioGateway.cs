using CleanArchitecture.NetCore.Domain;
using CleanArchitecture.NetCore.Dtos;
using CleanArchitecture.NetCore.Dtos.Responses;
using CleanArchitecture.NetCore.InterfaceAdapters.Mapping;
using CleanArchitecture.NetCore.UseCases.Usuarios;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.NetCore.InterfaceAdapters.Gateways
{
    public class UsuarioGateway : IUsuarioGateway
    {
        private readonly IUsuarioUseCases _useCases;
        private readonly IParser _parser;

        public UsuarioGateway(IUsuarioUseCases useCases, IParser parser)
        {
            _useCases = useCases;
            _parser = parser;
        }

        public ResponseMessage CrearUsuario(UsuarioDto dto)
        {            
            var domain = _parser.Parse<Usuario, UsuarioDto>(dto);
            var result = _useCases.CrearUsuario(domain);

            return new ResponseMessage(result, "Creado con éxito"); //ToDo: Implementar el devolver el obj insertado
        }
    }
}
