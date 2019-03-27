using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitecture.NetCore.Dtos;
using CleanArchitecture.NetCore.Dtos.Requests;
using CleanArchitecture.NetCore.InterfaceAdapters.Gateways;
using CleanArchitecture.NetCore.InterfaceAdapters.Mapping;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.NetCore.Application.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsuarioGateway _usuarioGateway;
        private readonly IParser _parser;

        public UsersController(IUsuarioGateway usuarioGateway, IParser parser)
        {
            _usuarioGateway = usuarioGateway ?? throw new ArgumentNullException(nameof(usuarioGateway));
            _parser = parser ?? throw new ArgumentNullException(nameof(parser));
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] UsuarioRequest usuario)
        {
            ActionResult result = null;
            if (!ModelState.IsValid) BadRequest(usuario);

            var dto = _parser.Parse<UsuarioDto, UsuarioRequest>(usuario);
            var response =_usuarioGateway.CrearUsuario(dto);

            result = response.Success 
                    ? Ok(response.Message) 
                    : StatusCode(500, response.Message);

            return result;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
