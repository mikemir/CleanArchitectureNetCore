using CleanArchitecture.NetCore.Domain;
using CleanArchitecture.NetCore.InterfaceAdapters.Infrastructure;
using CleanArchitecture.NetCore.InterfaceAdapters.Repositories;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CleanArchitecture.NetCore.UnitTests.InterfaceAdapters.Repositories
{
    public class UsuarioRepositoryTest
    {
        [Fact]
        void CuandoInsertoUnUsuario()
        {
            //Arrage
            var usuario = new Usuario();
            var fakeDataSource = new Mock<IUsuarioDataSource>();
            fakeDataSource.Setup(data => data.CrearUsuario(It.IsAny<Usuario>())).Returns(true);

            var repository = new UsuarioRepository(fakeDataSource.Object);

            //Act
            var result = repository.CrearUsuario(usuario);

            //Assert
            Assert.True(result);
        }
    }
}
