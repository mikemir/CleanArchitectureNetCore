using AutoMapper;
using CleanArchitecture.NetCore.InterfaceAdapters.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.NetCore.Infrastructure.Mapping
{
    public class Parser : IParser
    {
        private readonly IMapper _mapper;

        public Parser(IMapper mapper)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public TResult Parse<TResult, TItem>(TItem item)
        {
            return _mapper.Map<TResult>(item);
        }
    }
}
