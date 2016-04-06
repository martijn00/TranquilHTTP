using System.Net.Http;

namespace TranquilHTTP
{
    public interface IHttpContentResolver
    {
        HttpContent ResolveHttpContent<TContent>(TContent content);
    }
}