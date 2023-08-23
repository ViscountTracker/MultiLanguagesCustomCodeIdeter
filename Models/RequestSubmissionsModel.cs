
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace SandboxForTasks.Models
{
    public class RequestSubmissionsModel
    {
        [JsonProperty("lang")]        
        public string Lang { get; set; }
        [JsonProperty("source")]
        public string Source { get; set; }
        [JsonProperty("input")]
        public string Input { get; set; }
        [JsonProperty("memory_limit")]
        public int MemoryLimit { get; set; }
        [JsonProperty("time_limit")]
        public int TimeLimit { get; set; }
        [JsonProperty("context")]
        public string Context { get; set; }
        [JsonProperty("callback")]
        public string Callback { get; set; }

        public RequestSubmissionsModel( string lang, string source, string input, int memoryLimit, int timeLimit, string context, string callback) 
        {
            Lang = lang;
            Source = source;
            Input = input;
            MemoryLimit= memoryLimit;
            TimeLimit= timeLimit;
            Context = context;
            Callback = callback;
        }
    }
}
