using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace SandboxForTasks.Models
{
    public class RequstSubmissionsModel
    {
        public string Lang { get; set; }
        public string Source { get; set; }
        public string Input { get; set; }
        public int MemoryLimit { get; set; }
        public int TimeLimit { get; set; }
        public string Context { get; set; }
        public string Callback { get; set; }

        public RequstSubmissionsModel( string lang, string source, string input, int memoryLimit, int timeLimit, string context, string callback) 
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
