using CleanArchitecture.NetCore.Infrastructure.DataSources;
using CleanArchitecture.NetCore.Infrastructure.DataSources.DB.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CleanArchitecture.NetCore.UnitTests.Infraestructure.DataSources
{
    public class UsuarioDataSourceTest
    {
        [Fact]
        public void CuandoInsertoUnUsuario()
        {
            //Arrange
            var options = new DbContextOptionsBuilder<UsuarioDbContext>()
                .UseInMemoryDatabase(databaseName: "add_usuario")
                .Options;

            var fakeDb = new UsuarioDbContext(options);
            var dataSource = new UsuarioDataSource(fakeDb);
            //Act
            var result = dataSource.CrearUsuario(new Domain.Usuario { Alias = "mikemir", Clave = "Clav3!" });

            //Assert
            Assert.True(result);
        }
    }
}
