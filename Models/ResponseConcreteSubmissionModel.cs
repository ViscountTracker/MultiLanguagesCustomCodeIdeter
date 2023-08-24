using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandboxForTasks.Models
{
    public class ResultConrete
    {
        [JsonProperty("run_status")]
        public RunStatusConrete RunStatusConrete { get; set; }

    }
    
    public class RunStatusConrete
    {
        [JsonProperty("stderr")]
        public string Stderr { get; set; }
        [JsonProperty("output")]
        public string Output { get; set; }
   
    }
    class ResponseConcreteSubmissionModel
    {
        [JsonProperty("result")]
        public ResultConrete ResultConrete { get; set; }

    }

}
