using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.NetCore.InterfaceAdapters.Gateways
{
    public interface IUseCaseGateway<in TUseCaseRequest, out TUseCaseResponse>
    {
    }
}
