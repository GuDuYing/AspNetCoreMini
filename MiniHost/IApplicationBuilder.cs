
using System;

namespace MiniHost{
    public interface IApplicationBuilder
    {
        IApplicationBuilder Use(Func<RequestDelegate, RequestDelegate> middleware);
        RequestDelegate Build();
    }
}