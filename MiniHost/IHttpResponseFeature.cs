
using System.Collections.Specialized;
using System.IO;

namespace MiniHost{
    public interface IHttpResponseFeature
    {
        int StatusCode { get; set; }
        NameValueCollection Headers { get; }
        Stream Body { get; }
    }   
}