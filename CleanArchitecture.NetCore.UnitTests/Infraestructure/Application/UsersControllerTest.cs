using CleanArchitecture.NetCore.Application.WebApi.Controllers;
using CleanArchitecture.NetCore.Dtos;
using CleanArchitecture.NetCore.Dtos.Requests;
using CleanArchitecture.NetCore.Dtos.Responses;
using CleanArchitecture.NetCore.InterfaceAdapters.Gateways;
using CleanArchitecture.NetCore.InterfaceAdapters.Mapping;
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
            var usuario = new UsuarioRequest { Alias = "", Clave = "" };

            var response = new ResponseMessage(true, "Ingresado con éxito.");
            var fakeGateway = new Mock<IUsuarioGateway>();
            fakeGateway.Setup(fake => fake.CrearUsuario(It.IsAny<UsuarioDto>()))
                       .Returns(response);

            var fakeMapper = new Mock<IParser>();
            fakeMapper.Setup(map => map.Parse<UsuarioDto, UsuarioRequest>(It.IsAny<UsuarioRequest>()))
                       .Returns(new UsuarioDto { Alias = usuario.Alias, Clave = usuario.Clave });

            var controller = new UsersController(fakeGateway.Object, fakeMapper.Object);

            //Act
            var result = controller.Post(usuario);

            //Assert
            Assert.True((result as ObjectResult).StatusCode == (int)HttpStatusCode.OK);
        }
    }
}
