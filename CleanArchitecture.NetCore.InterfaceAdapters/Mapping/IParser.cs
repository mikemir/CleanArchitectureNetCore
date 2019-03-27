using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.NetCore.InterfaceAdapters.Mapping
{
    public interface IParser
    {
        TResult Parse<TResult, TItem>(TItem item);
    }
}
