using AutoMapper;
using CleanArchitecture.NetCore.Dtos;
using CleanArchitecture.NetCore.Dtos.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.NetCore.Configuration.Mapping.Profiles
{
    public class RequestToDtoProfile : Profile
    {
        public RequestToDtoProfile()
        {
            CreateMap<UsuarioRequest, UsuarioDto>().ReverseMap();
        }
    }
}
