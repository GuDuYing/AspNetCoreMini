
using System.Threading.Tasks;

namespace MiniHost{
    /*
    RequestDelegate是我们介绍的第二个核心对象。
    从命名可以看出这是一个委托（Delegate）对象，和上面介绍的HttpContext一样，我们也只有从管道的角度才能充分理解这个委托对象的本质。
    ASP.NET Core管道的设计就具有“简单”的特质：Pipeline = Server + Middlewares。
    但是“还能再简单点吗？”，其实是可以的：我们可以将多个Middleware构建成一个单一的“HttpHandler”，
    那么整个ASP.NET Core框架将具有更加简单的表达：Pipeline =Server + HttpHandler。
   */
    public delegate Task RequestDelegate(HttpContext context);
}