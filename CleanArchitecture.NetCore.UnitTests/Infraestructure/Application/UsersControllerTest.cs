using CleanArchitecture.NetCore.Application.WebApi.Controllers;
using CleanArchitecture.NetCore.Application.WebApi.Models.Users.Requests;
using CleanArchitecture.NetCore.Dtos;
using CleanArchitecture.NetCore.Dtos.Response;
using CleanArchitecture.NetCore.InterfaceAdapters.Gateways;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Xunit;

namespace CleanArchitecture.NetCore.UnitTests.Infraestructure.Application
{
    public class UsersControllerTest
    {
        [Fact]
        public void CuandoHagoUnPostExitosoConUsuario()
        {
            //Arrange
            var usuario = new UsuarioRequest { Usuario = "", Clave = "" };

            var response = new ResponseMessage(true, "Ingresado con éxito.");
            var fakeGateway = new Mock<IUsuarioGateway>();
            fakeGateway.Setup(gate => gate.CrearUsuario(It.IsAny<UsuarioDto>()))
                       .Returns(response);

            var controller = new UsersController(fakeGateway.Object);

            //Act
            var result = controller.Post(usuario);

            //Assert
            Assert.True((result as ObjectResult).StatusCode == (int)HttpStatusCode.OK);
        }
    }
}
