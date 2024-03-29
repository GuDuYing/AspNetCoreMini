
using System.Collections.Specialized;
using System.IO;

namespace MiniHost{

    public class HttpResponse{
        private readonly IHttpResponseFeature _feature;
        public HttpResponse(IFeatureCollection features) => _feature = features.Get<IHttpResponseFeature>();
        public  NameValueCollection Headers => _feature.Headers;
        public  Stream Body => _feature.Body;
        public int StatusCode { get => _feature.StatusCode; set => _feature.StatusCode = value; }
    }
    
}