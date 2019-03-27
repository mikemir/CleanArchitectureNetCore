using AutoMapper;
using CleanArchitecture.NetCore.Domain;
using CleanArchitecture.NetCore.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.NetCore.Configuration.Mapping.Profiles
{
    public class DtoToDomainProfile : Profile
    {
        public DtoToDomainProfile()
        {
            CreateMap<UsuarioDto, Usuario>().ReverseMap();
        }
    }
}
