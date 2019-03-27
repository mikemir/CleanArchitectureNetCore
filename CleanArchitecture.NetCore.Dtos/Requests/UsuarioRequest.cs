using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.NetCore.Dtos.Requests
{
    public class UsuarioRequest
    {
        public string Alias { get; set; }
        public string Clave { get; set; }
    }
}
