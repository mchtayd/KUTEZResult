using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Shared
{
    public class ClientProcess
    {
        /// <summary>
        /// Execute Rest Client
        /// </summary>        
        /// <returns>Get Response Content</returns>
        public static async Task<string> ClientExecuteAsync(string url, Method method = Method.POST, object model = null)
        {
            string content = "-1";
            try
            {
                var client = new RestClient(url);
                client.AddDefaultHeader("User-Agent", "PostmanRuntime/7.28.4");
                client.AddDefaultHeader("Accept", "*/*");
                client.AddDefaultHeader("Connection", "keep-alive");

                var request = new RestRequest(method);
                if (method == Method.POST)
                {
                    request.AddJsonBody(model);
                }

                var response = await client.ExecuteAsync(request);
                content = response.Content;
                return content;
            }
            catch (Exception ex)
            {
                //LogService.GetInstance().Error(ex.Message, "Client Execute", $"Url: {url} / Method: {method} / Model: {model}");
                return content;
            }

        }
    }
}
