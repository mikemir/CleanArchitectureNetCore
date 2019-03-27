using CleanArchitecture.NetCore.Domain;
using CleanArchitecture.NetCore.Dtos;
using CleanArchitecture.NetCore.InterfaceAdapters.Gateways;
using CleanArchitecture.NetCore.InterfaceAdapters.Mapping;
using CleanArchitecture.NetCore.UseCases.Usuarios;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CleanArchitecture.NetCore.UnitTests.InterfaceAdapters.Gateways
{
    public class UsuarioGatewayTest
    {
        [Fact]
        public void CuandoCreoUnUsuarioATravesDelCasoDeUso()
        {
            //Arrange
            var dto = new UsuarioDto { Alias = "mikemir", Clave = "Clav3!" };
            var fakeUseCase = new Mock<IUsuarioUseCases>();
            fakeUseCase.Setup(use => use.CrearUsuario(It.IsAny<Usuario>())).Returns(true);

            var fakeMapper = new Mock<IParser>();
            fakeMapper.Setup(map => map.Parse<Usuario, UsuarioDto>(It.IsAny<UsuarioDto>()))
                       .Returns(new Usuario { Alias = dto.Alias, Clave = dto.Clave });

            var gateway = new UsuarioGateway(fakeUseCase.Object, fakeMapper.Object);

            //Act
            var result = gateway.CrearUsuario(dto);

            //Assert
            Assert.True(result.Success);
        }
    }
}
