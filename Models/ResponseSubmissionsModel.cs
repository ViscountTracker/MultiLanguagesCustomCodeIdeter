namespace SandboxForTasks.Models
{
    class ResponseSubmissionsModel
    {
        public RequstStatus RequestStatus { get; set; }
        public Result Result { get; set; }
        public string HeId { get; set; }
        public string Context { get; set; }
        public string StatusUrlCode { get; set; }

        public ResponseSubmissionsModel(string heId, string context, string statusUrlCode, Result result, RequstStatus requstStatus ) 
        {
            HeId = heId;
            Context = context;
            StatusUrlCode = statusUrlCode;
            RequestStatus = requstStatus;
            Result = result;
        }
    }
    public class RequstStatus
    {
        public string Message { get; set; }
        public string Code { get; set; }
        public RequstStatus(string message, string code) 
        {
            Message = message;
            Code = code;
        }
    }

    public class Result
    {
        public string RunStatus { get; set; }
        public string Status { get; set; }
        public string CompileStatus { get; set; }

        public Result(string runStatus,string status, string compileStatus) 
        {
            RunStatus = runStatus;
            Status = status;
            CompileStatus=compileStatus;
        }
    }
}
