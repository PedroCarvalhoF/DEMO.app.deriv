using DEMO.app.deriv.services.Services.Helpers;
using DEMO.app.deriv.services.Urls;
using RestSharp;
using System;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

namespace DEMO.app.deriv.services.Services.ConexaoAPI
{
    public class ApiService : IApiService, IDisposable
    {
        private readonly string _urlBase;
        private readonly JsonSerializerOptions _options;

        public ApiService(string urlBase, JsonSerializerOptions options)
        {
            _urlBase = UrlsHelper.UrlApiDerivBase;
            _options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
        }

        public Task<string> Get(string token, string url, object objGet = null)
        {
            throw new NotImplementedException();
        }

        public async Task<string> Post(string token, string url, object objCreate = null)
        {
            try
            {
                url = _urlBase + url;
                using (RestClient client = new RestClient(url))
                {

                    RestRequest request = new RestRequest(url, Method.Post);
                    request.RequestFormat = DataFormat.Json;
                    request.AddHeader("authorization", "Bearer " + token);

                    if (objCreate != null)
                        request.AddBody(objCreate);

                    RestResponse response = await client.ExecuteAsync(request);                    

                    return StatusCodeHelpers.GetStatusCodeResponse(response);
                   
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public Task<string> Put(string token, string url, object objUpdate = null)
        {
            throw new NotImplementedException();
        }
        public Task<string> Delete(string token, string url, object objDelete = null)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
