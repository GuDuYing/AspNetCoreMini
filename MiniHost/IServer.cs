
using System.Threading.Tasks;

namespace MiniHost{
    public interface IServer
    { 
        Task StartAsync(RequestDelegate handler);
    }
}