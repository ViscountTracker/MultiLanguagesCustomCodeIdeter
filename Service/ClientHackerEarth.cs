using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SandboxForTasks.Service
{
    class ClientHackerEarth
    {
        HttpClient httpClient;
        private string clientId;
        private string clientSecretKey;

       public ClientHackerEarth()
        { 
            httpClient = new HttpClient();
            clientId = ConfigurationManager.AppSettings["clientId"];
            clientSecretKey = ConfigurationManager.AppSettings["clientSecretKey"];
        }
    }
}
