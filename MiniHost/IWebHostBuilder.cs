
using System;

namespace MiniHost{
    public interface IWebHostBuilder
    {
        IWebHostBuilder UseServer(IServer server);
        IWebHostBuilder Configure(Action<IApplicationBuilder> configure);
        IWebHost Build();
    }
}