using CleanArchitecture.NetCore.Domain;
using CleanArchitecture.NetCore.UseCases.InterfaceAdapters.Repository;
using CleanArchitecture.NetCore.UseCases.Usuarios;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CleanArchitecture.NetCore.UnitTests.UseCases
{
    public class UsuarioUseCasesTest
    {
        [Fact]
        public void CuandoInserUnUsuario()
        {
            //Arrage
            var domain = new Usuario();
            var fakeRepository = new Mock<IUsuarioRepository>();
            fakeRepository.Setup(repo => repo.CrearUsuario(It.IsAny<Usuario>())).Returns(true);
            
            var useCases = new UsuarioUseCases(fakeRepository.Object);

            //Act
            var result = useCases.CrearUsuario(domain);

            //Assert
            Assert.True(result);
        }
    }
}
