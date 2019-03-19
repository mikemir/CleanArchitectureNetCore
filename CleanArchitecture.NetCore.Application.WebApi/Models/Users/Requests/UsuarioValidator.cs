using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.NetCore.Application.WebApi.Models.Users.Requests
{
    public class UsuarioValidator : AbstractValidator<UsuarioRequest>
    {
        public UsuarioValidator()
        {
            RuleFor(x => x.Usuario).NotEmpty().NotNull();
            RuleFor(x => x.Clave).Length(1, 25).NotNull();
        }
    }
}
