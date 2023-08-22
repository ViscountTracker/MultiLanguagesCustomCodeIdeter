using Newtonsoft.Json;
using System.Windows.Controls.Primitives;

namespace SandboxForTasks.Models
{
    class ResponseSubmissionsModel
    {
        [JsonProperty("request_status")]
        public RequestStatus RequestStatus { get; set; }
        [JsonProperty("result")]
        public Result Result { get; set; }
        [JsonProperty("he_id")]
        public string HeId { get; set; }
        [JsonProperty("status_update_url")]
        public string StatusUrlCode { get; set; }

        public ResponseSubmissionsModel(string heId, string statusUrlCode, Result result, RequestStatus requestStatus)
        {
            HeId = heId;
            StatusUrlCode = statusUrlCode;
            RequestStatus = requestStatus;
            Result = result;
        }
    }
    public class RequestStatus
    {
        [JsonProperty("code")]
        public string Code { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
       
        public RequestStatus(string message, string code)
        {
            Message = message;
            Code = code;
        }
    }
    public class Result
    {
        [JsonProperty("run_status")]
        public  RunStatus RunStatus { get; set; }
       
        [JsonProperty("compile_status")]
        public string CompileStatus { get; set; }

        public Result(RunStatus runStatus, string compileStatus)
        {
            RunStatus = runStatus;
            CompileStatus = compileStatus;
        }
    }

    public class RunStatus
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        public RunStatus(string status) 
        { 
            Status = status;   
        }
    }
}
