
namespace MiniHost{
    /*
    HttpContext对象，它可以说是ASP.NET Core应用开发中使用频率最高的对象。
    要说明HttpContext的本质，还得从请求处理管道的层面来讲。
    对于由一个服务器和多个中间件构建的管道来说，面向传输层的服务器负责请求的监听、接收和最终的响应，
    当它接收到客户端发送的请求后，需要将它分发给后续中间件进行处理
     */
    public class HttpContext{
        public  HttpRequest Request { get; }
        public  HttpResponse Response { get; }
        public HttpContext(IFeatureCollection features)
        {
            Request = new HttpRequest(features);
            Response = new HttpResponse(features);
        }
    }
}