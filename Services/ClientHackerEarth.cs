using Newtonsoft.Json;
using SandboxForTasks.Models;
using System;
using System.Configuration;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SandboxForTasks.Service
{
    class ClientHackerEarth
    {
        HttpClient httpClient;
        private string clientId;
        private string clientSecretKey;

        private const int DEAFAULT_MEMORY_LIMIT = 999999;
        private const int DEAFAULT_TIME_LIMIT = 1000;
        private const string DEAFAULT_LANG = "PYTHON";
        private const string DEAFAULT_INPUT = "";
        private const string DEAFAULT_CONTEXT = "";
        private const string DEAFAULT_CALLBACK = "";

        public ClientHackerEarth()
        {
            httpClient = new HttpClient();
            clientId = ConfigurationManager.AppSettings["clientId"];
            clientSecretKey = ConfigurationManager.AppSettings["clientSecretKey"];

            if (clientId == null)
            {
                throw new Exception("In configuration required clientId not found");
            }
            if (clientSecretKey == null)
            {
                throw new Exception("In configuration required clientSecretKey  not found");
            }
        }

        public async Task<ResponseSubmissionsModel?> GetCodeValidation(string codeToValidate)
        {
            var httpClient = new HttpClient();
            var httpRequest = new HttpRequestMessage(HttpMethod.Post, "https://api.hackerearth.com/v4/partner/code-evaluation/submissions/");

            httpRequest.Headers.Add("client-secret", clientSecretKey);

            RequestSubmissionsModel request = new RequestSubmissionsModel(DEAFAULT_LANG, codeToValidate, DEAFAULT_INPUT, DEAFAULT_MEMORY_LIMIT, DEAFAULT_TIME_LIMIT, DEAFAULT_CONTEXT, DEAFAULT_CALLBACK);
            var requstBodyJson = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");
            //requstBodyJson.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            httpRequest.Content = requstBodyJson;

            HttpResponseMessage responseMessage = await httpClient.SendAsync(httpRequest);
            
            ResponseSubmissionsModel? item = null;
            if (responseMessage.IsSuccessStatusCode)
            {
                item = JsonConvert.DeserializeObject<ResponseSubmissionsModel>(responseMessage.Content.ReadAsStringAsync().Result);
            }
            Trace.WriteLine(responseMessage.Content.ReadAsStringAsync().Result);
            return item;
        }
    }
}
