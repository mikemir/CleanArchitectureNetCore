using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.NetCore.Application.WebApi.Models.Users.Requests
{
    public class UsuarioRequest
    {
        public string Usuario { get; set; }
        public string Clave { get; set; }
    }
}
