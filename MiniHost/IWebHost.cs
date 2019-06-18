
using System.Threading.Tasks;

namespace MiniHost{
    public interface IWebHost
    {
        Task StartAsync();
    }
}