using System;
using System.Threading.Tasks;
using core.Models;
using Flurl;
using Flurl.Http;
namespace core.Services
{
    public class HttpHandler
    {
        public async Task<CatResponse> GetCatResponseAsync()
        {
            return await "https://cat-fact.herokuapp.com".AppendPathSegments("facts", "random").GetAsync().ReceiveJson<CatResponse>();
        }
    }
}
