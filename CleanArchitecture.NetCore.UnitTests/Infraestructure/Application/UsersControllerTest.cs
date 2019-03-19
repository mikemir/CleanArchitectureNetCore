using CleanArchitecture.NetCore.Application.WebApi.Controllers;
using CleanArchitecture.NetCore.Application.WebApi.Models.Users.Requests;
using CleanArchitecture.NetCore.InterfaceAdapters.Gateways;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CleanArchitecture.NetCore.UnitTests.Infraestructure.Application
{
    public class UsersControllerTest
    {
        [Fact]
        public void CuandoHagoUnPostConUsuario()
        {
            //Arrange
            var usuario = new UsuarioRequest { Usuario = "", Clave = "" };

            var fakeGateway = new Mock<IUsuarioGateway>();

            var controller = new UsersController(fakeGateway.Object);

            //Act
            var result = controller.Post(usuario);

            //Assert
            
        }
    }
}
