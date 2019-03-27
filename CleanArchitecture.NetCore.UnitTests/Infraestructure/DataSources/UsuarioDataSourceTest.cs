using CleanArchitecture.NetCore.Domain;
using CleanArchitecture.NetCore.Infrastructure.DataSources;
using CleanArchitecture.NetCore.Infrastructure.DataSources.DB.EntityFramework;
using CleanArchitecture.NetCore.Infrastructure.DataSources.DB.EntityFramework.Model;
using CleanArchitecture.NetCore.InterfaceAdapters.Mapping;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CleanArchitecture.NetCore.UnitTests.Infraestructure.DataSources
{
    public class UsuarioDataSourceTest
    {
        [Fact]
        public async Task CuandoInsertoUnUsuario()
        {
            //Arrange
            var usuario = new Usuario { Alias = "mikemir", Clave = "Clav3!" };
            var options = new DbContextOptionsBuilder<UsuarioDbContext>()
                .UseInMemoryDatabase(databaseName: "add_usuario")
                .Options;

            var fakeDb = new UsuarioDbContext(options);
            var fakeMapper = new Mock<IParser>();
            fakeMapper.Setup(map => map.Parse<UsuarioEntity, Usuario>(It.IsAny<Usuario>()))
                       .Returns(new UsuarioEntity { Alias = usuario.Alias, Clave = usuario.Clave });

            var dataSource = new UsuarioDataSource(fakeDb, fakeMapper.Object);
            //Act
            var result = dataSource.CrearUsuario(usuario);

            //Assert
            var item = await fakeDb.Usuarios.FirstOrDefaultAsync();

            Assert.True(result);
            Assert.Equal(item.Alias, usuario.Alias);
            Assert.Equal(item.Clave, usuario.Clave);
        }
    }
}
